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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedQueryServiceClientSnippets
    {
        /// <summary>Snippet for QueryTimeSeries</summary>
        public void QueryTimeSeriesRequestObject()
        {
            // Snippet: QueryTimeSeries(QueryTimeSeriesRequest, CallSettings)
            // Create client
            QueryServiceClient queryServiceClient = QueryServiceClient.Create();
            // Initialize request argument(s)
            QueryTimeSeriesRequest request = new QueryTimeSeriesRequest { Name = "", Query = "", };
            // Make the request
            PagedEnumerable<QueryTimeSeriesResponse, TimeSeriesData> response = queryServiceClient.QueryTimeSeries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeriesData item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesData item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesData> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesData item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTimeSeriesAsync</summary>
        public async Task QueryTimeSeriesRequestObjectAsync()
        {
            // Snippet: QueryTimeSeriesAsync(QueryTimeSeriesRequest, CallSettings)
            // Create client
            QueryServiceClient queryServiceClient = await QueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryTimeSeriesRequest request = new QueryTimeSeriesRequest { Name = "", Query = "", };
            // Make the request
            PagedAsyncEnumerable<QueryTimeSeriesResponse, TimeSeriesData> response = queryServiceClient.QueryTimeSeriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeriesData item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesData item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesData> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesData item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
