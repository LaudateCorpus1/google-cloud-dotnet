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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegionNotificationEndpointsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient> mockGrpcClient = new moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NotificationEndpoint = "notification_endpointbe78db22",
            };
            NotificationEndpoint expectedResponse = new NotificationEndpoint
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                GrpcSettings = new NotificationEndpointGrpcSettings(),
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNotificationEndpointsClient client = new RegionNotificationEndpointsClientImpl(mockGrpcClient.Object, null);
            NotificationEndpoint response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient> mockGrpcClient = new moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NotificationEndpoint = "notification_endpointbe78db22",
            };
            NotificationEndpoint expectedResponse = new NotificationEndpoint
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                GrpcSettings = new NotificationEndpointGrpcSettings(),
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNotificationEndpointsClient client = new RegionNotificationEndpointsClientImpl(mockGrpcClient.Object, null);
            NotificationEndpoint responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationEndpoint responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient> mockGrpcClient = new moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NotificationEndpoint = "notification_endpointbe78db22",
            };
            NotificationEndpoint expectedResponse = new NotificationEndpoint
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                GrpcSettings = new NotificationEndpointGrpcSettings(),
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionNotificationEndpointsClient client = new RegionNotificationEndpointsClientImpl(mockGrpcClient.Object, null);
            NotificationEndpoint response = client.Get(request.Project, request.Region, request.NotificationEndpoint);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient> mockGrpcClient = new moq::Mock<RegionNotificationEndpoints.RegionNotificationEndpointsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionNotificationEndpointRequest request = new GetRegionNotificationEndpointRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                NotificationEndpoint = "notification_endpointbe78db22",
            };
            NotificationEndpoint expectedResponse = new NotificationEndpoint
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Description = "description2cf9da67",
                GrpcSettings = new NotificationEndpointGrpcSettings(),
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NotificationEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionNotificationEndpointsClient client = new RegionNotificationEndpointsClientImpl(mockGrpcClient.Object, null);
            NotificationEndpoint responseCallSettings = await client.GetAsync(request.Project, request.Region, request.NotificationEndpoint, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NotificationEndpoint responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.NotificationEndpoint, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
