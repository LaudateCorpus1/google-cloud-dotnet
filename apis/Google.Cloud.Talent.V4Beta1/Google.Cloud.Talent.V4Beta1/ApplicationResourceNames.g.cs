// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gctv = Google.Cloud.Talent.V4Beta1;
using sys = System;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Resource name for the <c>Application</c> resource.</summary>
    public sealed partial class ApplicationName : gax::IResourceName, sys::IEquatable<ApplicationName>
    {
        /// <summary>The possible contents of <see cref="ApplicationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
            /// </summary>
            ProjectTenantProfileApplication = 1,
        }

        private static gax::PathTemplate s_projectTenantProfileApplication = new gax::PathTemplate("projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}");

        /// <summary>Creates a <see cref="ApplicationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ApplicationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ApplicationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ApplicationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ApplicationName"/> with the pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ApplicationName"/> constructed from the provided ids.</returns>
        public static ApplicationName FromProjectTenantProfileApplication(string projectId, string tenantId, string profileId, string applicationId) =>
            new ApplicationName(ResourceNameType.ProjectTenantProfileApplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
        /// </returns>
        public static string Format(string projectId, string tenantId, string profileId, string applicationId) =>
            FormatProjectTenantProfileApplication(projectId, tenantId, profileId, applicationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ApplicationName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>.
        /// </returns>
        public static string FormatProjectTenantProfileApplication(string projectId, string tenantId, string profileId, string applicationId) =>
            s_projectTenantProfileApplication.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ApplicationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApplicationName"/> if successful.</returns>
        public static ApplicationName Parse(string applicationName) => Parse(applicationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ApplicationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ApplicationName"/> if successful.</returns>
        public static ApplicationName Parse(string applicationName, bool allowUnparsed) =>
            TryParse(applicationName, allowUnparsed, out ApplicationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationName, out ApplicationName result) =>
            TryParse(applicationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ApplicationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="applicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ApplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationName, bool allowUnparsed, out ApplicationName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationName, nameof(applicationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTenantProfileApplication.TryParseName(applicationName, out resourceName))
            {
                result = FromProjectTenantProfileApplication(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(applicationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ApplicationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string profileId = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            ProfileId = profileId;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ApplicationName"/> class from the component parts of pattern
        /// <c>projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="profileId">The <c>Profile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        public ApplicationName(string projectId, string tenantId, string profileId, string applicationId) : this(ResourceNameType.ProjectTenantProfileApplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), profileId: gax::GaxPreconditions.CheckNotNullOrEmpty(profileId, nameof(profileId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

        /// <summary>
        /// The <c>Profile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProfileId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tenant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TenantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTenantProfileApplication: return s_projectTenantProfileApplication.Expand(ProjectId, TenantId, ProfileId, ApplicationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ApplicationName);

        /// <inheritdoc/>
        public bool Equals(ApplicationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ApplicationName a, ApplicationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ApplicationName a, ApplicationName b) => !(a == b);
    }

    public partial class Application
    {
        /// <summary>
        /// <see cref="gctv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="JobName"/>-typed view over the <see cref="Job"/> resource name property.</summary>
        public JobName JobAsJobName
        {
            get => string.IsNullOrEmpty(Job) ? null : JobName.Parse(Job, allowUnparsed: true);
            set => Job = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public CompanyName CompanyAsCompanyName
        {
            get => string.IsNullOrEmpty(Company) ? null : CompanyName.Parse(Company, allowUnparsed: true);
            set => Company = value?.ToString() ?? "";
        }
    }
}
