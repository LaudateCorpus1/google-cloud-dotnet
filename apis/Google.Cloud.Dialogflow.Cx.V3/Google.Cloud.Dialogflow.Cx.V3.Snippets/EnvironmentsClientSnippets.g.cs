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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdcv = Google.Cloud.Dialogflow.Cx.V3;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsRequestObjectAsync()
        {
            // Snippet: ListEnvironmentsAsync(ListEnvironmentsRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironments()
        {
            // Snippet: ListEnvironments(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsAsync()
        {
            // Snippet: ListEnvironmentsAsync(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsResourceNames()
        {
            // Snippet: ListEnvironments(AgentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsResourceNamesAsync()
        {
            // Snippet: ListEnvironmentsAsync(AgentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListEnvironmentsResponse, gcdcv::Environment> response = environmentsClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdcv::Environment response = environmentsClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdcv::Environment response = await environmentsClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            gcdcv::Environment response = environmentsClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentAsync()
        {
            // Snippet: GetEnvironmentAsync(string, CallSettings)
            // Additional: GetEnvironmentAsync(string, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            gcdcv::Environment response = await environmentsClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentResourceNames()
        {
            // Snippet: GetEnvironment(EnvironmentName, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            gcdcv::Environment response = environmentsClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentResourceNamesAsync()
        {
            // Snippet: GetEnvironmentAsync(EnvironmentName, CallSettings)
            // Additional: GetEnvironmentAsync(EnvironmentName, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            gcdcv::Environment response = await environmentsClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentRequestObject()
        {
            // Snippet: CreateEnvironment(CreateEnvironmentRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Environment = new gcdcv::Environment(),
            };
            // Make the request
            Operation<gcdcv::Environment, Struct> response = environmentsClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Snippet: CreateEnvironmentAsync(CreateEnvironmentRequest, CallSettings)
            // Additional: CreateEnvironmentAsync(CreateEnvironmentRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Environment = new gcdcv::Environment(),
            };
            // Make the request
            Operation<gcdcv::Environment, Struct> response = await environmentsClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = await environmentsClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironment()
        {
            // Snippet: CreateEnvironment(string, Environment, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            gcdcv::Environment environment = new gcdcv::Environment();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = environmentsClient.CreateEnvironment(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentAsync()
        {
            // Snippet: CreateEnvironmentAsync(string, Environment, CallSettings)
            // Additional: CreateEnvironmentAsync(string, Environment, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            gcdcv::Environment environment = new gcdcv::Environment();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = await environmentsClient.CreateEnvironmentAsync(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = await environmentsClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentResourceNames()
        {
            // Snippet: CreateEnvironment(AgentName, Environment, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            gcdcv::Environment environment = new gcdcv::Environment();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = environmentsClient.CreateEnvironment(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentResourceNamesAsync()
        {
            // Snippet: CreateEnvironmentAsync(AgentName, Environment, CallSettings)
            // Additional: CreateEnvironmentAsync(AgentName, Environment, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            gcdcv::Environment environment = new gcdcv::Environment();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = await environmentsClient.CreateEnvironmentAsync(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = await environmentsClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironmentRequestObject()
        {
            // Snippet: UpdateEnvironment(UpdateEnvironmentRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            UpdateEnvironmentRequest request = new UpdateEnvironmentRequest
            {
                Environment = new gcdcv::Environment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcdcv::Environment, Struct> response = environmentsClient.UpdateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = environmentsClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentRequestObjectAsync()
        {
            // Snippet: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CallSettings)
            // Additional: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEnvironmentRequest request = new UpdateEnvironmentRequest
            {
                Environment = new gcdcv::Environment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcdcv::Environment, Struct> response = await environmentsClient.UpdateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = await environmentsClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironment()
        {
            // Snippet: UpdateEnvironment(Environment, FieldMask, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcdcv::Environment environment = new gcdcv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = environmentsClient.UpdateEnvironment(environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = environmentsClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentAsync()
        {
            // Snippet: UpdateEnvironmentAsync(Environment, FieldMask, CallSettings)
            // Additional: UpdateEnvironmentAsync(Environment, FieldMask, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcdcv::Environment environment = new gcdcv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdcv::Environment, Struct> response = await environmentsClient.UpdateEnvironmentAsync(environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdcv::Environment, Struct> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdcv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdcv::Environment, Struct> retrievedResponse = await environmentsClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdcv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentRequestObject()
        {
            // Snippet: DeleteEnvironment(DeleteEnvironmentRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            environmentsClient.DeleteEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentRequestObjectAsync()
        {
            // Snippet: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CallSettings)
            // Additional: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            await environmentsClient.DeleteEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironment()
        {
            // Snippet: DeleteEnvironment(string, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            environmentsClient.DeleteEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentAsync()
        {
            // Snippet: DeleteEnvironmentAsync(string, CallSettings)
            // Additional: DeleteEnvironmentAsync(string, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            await environmentsClient.DeleteEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentResourceNames()
        {
            // Snippet: DeleteEnvironment(EnvironmentName, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            environmentsClient.DeleteEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentResourceNamesAsync()
        {
            // Snippet: DeleteEnvironmentAsync(EnvironmentName, CallSettings)
            // Additional: DeleteEnvironmentAsync(EnvironmentName, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            await environmentsClient.DeleteEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistory</summary>
        public void LookupEnvironmentHistoryRequestObject()
        {
            // Snippet: LookupEnvironmentHistory(LookupEnvironmentHistoryRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistory(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupEnvironmentHistoryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistoryAsync</summary>
        public async Task LookupEnvironmentHistoryRequestObjectAsync()
        {
            // Snippet: LookupEnvironmentHistoryAsync(LookupEnvironmentHistoryRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            LookupEnvironmentHistoryRequest request = new LookupEnvironmentHistoryRequest
            {
                EnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistoryAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupEnvironmentHistoryResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistory</summary>
        public void LookupEnvironmentHistory()
        {
            // Snippet: LookupEnvironmentHistory(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistory(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupEnvironmentHistoryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistoryAsync</summary>
        public async Task LookupEnvironmentHistoryAsync()
        {
            // Snippet: LookupEnvironmentHistoryAsync(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistoryAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupEnvironmentHistoryResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistory</summary>
        public void LookupEnvironmentHistoryResourceNames()
        {
            // Snippet: LookupEnvironmentHistory(EnvironmentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistory(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdcv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupEnvironmentHistoryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEnvironmentHistoryAsync</summary>
        public async Task LookupEnvironmentHistoryResourceNamesAsync()
        {
            // Snippet: LookupEnvironmentHistoryAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName name = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<LookupEnvironmentHistoryResponse, gcdcv::Environment> response = environmentsClient.LookupEnvironmentHistoryAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdcv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupEnvironmentHistoryResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdcv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdcv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdcv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RunContinuousTest</summary>
        public void RunContinuousTestRequestObject()
        {
            // Snippet: RunContinuousTest(RunContinuousTestRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            RunContinuousTestRequest request = new RunContinuousTestRequest
            {
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> response = environmentsClient.RunContinuousTest(request);

            // Poll until the returned long-running operation is complete
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunContinuousTestResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> retrievedResponse = environmentsClient.PollOnceRunContinuousTest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunContinuousTestResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunContinuousTestAsync</summary>
        public async Task RunContinuousTestRequestObjectAsync()
        {
            // Snippet: RunContinuousTestAsync(RunContinuousTestRequest, CallSettings)
            // Additional: RunContinuousTestAsync(RunContinuousTestRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            RunContinuousTestRequest request = new RunContinuousTestRequest
            {
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> response = await environmentsClient.RunContinuousTestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunContinuousTestResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunContinuousTestResponse, RunContinuousTestMetadata> retrievedResponse = await environmentsClient.PollOnceRunContinuousTestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunContinuousTestResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResults</summary>
        public void ListContinuousTestResultsRequestObject()
        {
            // Snippet: ListContinuousTestResults(ListContinuousTestResultsRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContinuousTestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContinuousTestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResultsAsync</summary>
        public async Task ListContinuousTestResultsRequestObjectAsync()
        {
            // Snippet: ListContinuousTestResultsAsync(ListContinuousTestResultsRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            ListContinuousTestResultsRequest request = new ListContinuousTestResultsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContinuousTestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContinuousTestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResults</summary>
        public void ListContinuousTestResults()
        {
            // Snippet: ListContinuousTestResults(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContinuousTestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContinuousTestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResultsAsync</summary>
        public async Task ListContinuousTestResultsAsync()
        {
            // Snippet: ListContinuousTestResultsAsync(string, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContinuousTestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContinuousTestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResults</summary>
        public void ListContinuousTestResultsResourceNames()
        {
            // Snippet: ListContinuousTestResults(EnvironmentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContinuousTestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContinuousTestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContinuousTestResultsAsync</summary>
        public async Task ListContinuousTestResultsResourceNamesAsync()
        {
            // Snippet: ListContinuousTestResultsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<ListContinuousTestResultsResponse, ContinuousTestResult> response = environmentsClient.ListContinuousTestResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContinuousTestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContinuousTestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContinuousTestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContinuousTestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContinuousTestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeployFlow</summary>
        public void DeployFlowRequestObject()
        {
            // Snippet: DeployFlow(DeployFlowRequest, CallSettings)
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            DeployFlowRequest request = new DeployFlowRequest
            {
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            Operation<DeployFlowResponse, DeployFlowMetadata> response = environmentsClient.DeployFlow(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployFlowResponse, DeployFlowMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployFlowResponse, DeployFlowMetadata> retrievedResponse = environmentsClient.PollOnceDeployFlow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployFlowAsync</summary>
        public async Task DeployFlowRequestObjectAsync()
        {
            // Snippet: DeployFlowAsync(DeployFlowRequest, CallSettings)
            // Additional: DeployFlowAsync(DeployFlowRequest, CancellationToken)
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            DeployFlowRequest request = new DeployFlowRequest
            {
                EnvironmentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                FlowVersionAsVersionName = VersionName.FromProjectLocationAgentFlowVersion("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[VERSION]"),
            };
            // Make the request
            Operation<DeployFlowResponse, DeployFlowMetadata> response = await environmentsClient.DeployFlowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployFlowResponse, DeployFlowMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployFlowResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployFlowResponse, DeployFlowMetadata> retrievedResponse = await environmentsClient.PollOnceDeployFlowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployFlowResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
