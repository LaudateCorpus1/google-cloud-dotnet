﻿// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Tools.Common;
using Google.Cloud.Tools.ReleaseManager.History;
using LibGit2Sharp;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.BatchRelease
{
    public sealed class KnownCommitsCriterion : IBatchCriterion
    {
        /// <summary>
        /// If set, override the natural history with this text.
        /// (The "header" from the natural history is preserved.)
        /// </summary>
        public string HistoryOverride { get; set; }

        /// <summary>
        /// The set of commits to expect. Only libraries with exactly this set of
        /// commits since the previous release are bumped.
        /// </summary>
        public HashSet<string> Commits { get; set; }

        IEnumerable<ReleaseProposal> IBatchCriterion.GetProposals(ApiCatalog catalog)
        {
            var root = DirectoryLayout.DetermineRootDirectory();
            using var repo = new Repository(root);
            var pendingChangesByApi = GitHelpers.GetPendingChangesByApi(repo, catalog);

            foreach (var api in catalog.Apis)
            {
                var pendingChanges = pendingChangesByApi[api];
                var pendingCommits = pendingChanges.Commits.Select(commit => commit.HashPrefix);
                if (!Commits.SetEquals(pendingCommits))
                {
                    continue;
                }
                var newVersion = api.StructuredVersion.AfterIncrement();
                var proposal = ReleaseProposal.CreateFromHistory(repo, api.Id, newVersion);

                // Potentially replace the natural history with an override
                if (!string.IsNullOrEmpty(HistoryOverride) && proposal.NewHistorySection is HistoryFile.Section newSection)
                {
                    var naturalLines = newSection.Lines;
                    var overrideLines = HistoryOverride.Split('\n');
                    var lines = naturalLines.Take(2).Concat(overrideLines).ToList();
                    // We always add a blank line at the end of each section.
                    lines.Add("");
                    proposal.NewHistorySection = new HistoryFile.Section(newVersion, lines);
                }
                yield return proposal;
            }
        }
    }
}
