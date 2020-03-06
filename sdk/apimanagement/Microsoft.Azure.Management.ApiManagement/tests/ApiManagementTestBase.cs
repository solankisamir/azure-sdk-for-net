// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 

using System;
using System.Linq;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Collections.Generic;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Network;
using Xunit;
using Microsoft.Azure.Management.EventHub;

namespace ApiManagement.Tests
{
    public class ApiManagementTestBase : TestBase
    {
        private const string SubIdKey = "SubId";
        private const string ServiceNameKey = "ServiceName";
        private const string ResourceGroupNameKey = "ResourceGroup";
        private const string LocationKey = "Location";
        private const string TestCertificateKey = "TestCertificate";
        private const string TestCertificatePasswordKey = "TestCertificatePassword";

        public string location { get; set; }
        public string subscriptionId { get; set; }
        public ApiManagementClient client { get; set; }
        public ResourceManagementClient resourcesClient { get; set; }
        public StorageManagementClient storageClient { get; set; }
        public NetworkManagementClient networkClient { get; set; }
        public EventHubManagementClient eventHubClient { get; set; }
        public string rgName { get; internal set; }
        public Dictionary<string, string> tags { get; internal set; }
        public string serviceName { get; internal set; }
        public ApiManagementServiceResource serviceProperties { get; internal set; }
        public string base64EncodedTestCertificateData { get; internal set; }
        public string testCertificatePassword { get; internal set; }

        public ApiManagementTestBase(MockContext context)
        {
            //smapi: vfedonkintodo remove:
            //Environment.SetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION", "SubscriptionId=bab08e11-7b12-4354-9fd1-4b5d64d40b68;Environment=Prod;ServicePrincipal=c01e8df8-1cb8-47a9-9931-887b594b1332;ServicePrincipalSecret=gAzOUmitZ1BmBM@NBNjs?:R:5dBQ7ds9;AADTenant=72f988bf-86f1-41af-91ab-2d7cd011db47;HttpRecorderMode=Record;ServiceName=sdktestservice;ResourceGroup=Api-Default-CentralUS;Location=CentralUS;TestCertificate=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;TestCertificatePassword=Password");

            Environment.SetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION", "SubscriptionId=74f34d9c-50ed-4d7a-a1a8-88d2aed13ac3;Environment=Dogfood;ServicePrincipal=60740602-c7dd-4030-b95d-e2e344812bc4;ServicePrincipalSecret=ljNF392kEoiFfj?-A=xm[KXVb5SPz8::;Location=eastus;AADTenant=f686d426-8d16-42db-81b7-ab578e110ccd;HttpRecorderMode=Record;ServiceName=sdktestservicemapi;ResourceGroup=ApiM-SDK-EastUS;Location=eastus;TestCertificate=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;TestCertificatePassword=Password");


            //rp: vfedonkintodo remove:
            //Environment.SetEnvironmentVariable("TEST_CSM_ORGID_AUTHENTICATION", "SubscriptionId=bab08e11-7b12-4354-9fd1-4b5d64d40b68;Environment=Prod;ServicePrincipal=c01e8df8-1cb8-47a9-9931-887b594b1332;ServicePrincipalSecret=SC0yDKW8dClPdosHVeV0/ZX5oRSJGie6ZTHv6WQ7DV4=;AADTenant=72f988bf-86f1-41af-91ab-2d7cd011db47;HttpRecorderMode=Record;TestCertificate=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;TestCertificatePassword=Password");
            this.client = context.GetServiceClient<ApiManagementClient>();
            this.resourcesClient = context.GetServiceClient<ResourceManagementClient>();
            this.storageClient = context.GetServiceClient<StorageManagementClient>();
            this.networkClient = context.GetServiceClient<NetworkManagementClient>();
            this.eventHubClient = context.GetServiceClient<EventHubManagementClient>();

            Initialize();
        }

        private void Initialize()
        {
            var testEnv = TestEnvironmentFactory.GetTestEnvironment();

            if (HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                if (!testEnv.ConnectionString.KeyValuePairs.TryGetValue(ServiceNameKey, out string apimServiceName))
                {
                    this.serviceName = TestUtilities.GenerateName("sdktestapim");
                }
                else
                {
                    this.serviceName = apimServiceName;
                }

                if (!testEnv.ConnectionString.KeyValuePairs.TryGetValue(LocationKey, out string apimLocation))
                {
                    this.location = GetLocation();
                }
                else
                {
                    this.location = apimLocation;
                }

                if (!testEnv.ConnectionString.KeyValuePairs.TryGetValue(ResourceGroupNameKey, out string resourceGroupName))
                {
                    rgName = TestUtilities.GenerateName("sdktestrg");
                    resourcesClient.ResourceGroups.CreateOrUpdate(rgName, new ResourceGroup { Location = this.location });
                }
                else
                {
                    this.rgName = resourceGroupName;
                }

                if (testEnv.ConnectionString.KeyValuePairs.TryGetValue(TestCertificateKey, out string base64EncodedCertificate))
                {
                    this.base64EncodedTestCertificateData = base64EncodedCertificate;
                    HttpMockServer.Variables[TestCertificateKey] = base64EncodedTestCertificateData;
                }

                if (testEnv.ConnectionString.KeyValuePairs.TryGetValue(TestCertificatePasswordKey, out string testCertificatePassword))
                {
                    this.testCertificatePassword = testCertificatePassword;
                    HttpMockServer.Variables[TestCertificatePasswordKey] = testCertificatePassword;
                }

                this.subscriptionId = testEnv.SubscriptionId;
                HttpMockServer.Variables[SubIdKey] = subscriptionId;
                HttpMockServer.Variables[ServiceNameKey] = this.serviceName;
                HttpMockServer.Variables[LocationKey] = this.location;
                HttpMockServer.Variables[ResourceGroupNameKey] = this.rgName;
            }
            else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
            {
                this.subscriptionId = testEnv.SubscriptionId;
                subscriptionId = HttpMockServer.Variables[SubIdKey];
                rgName = HttpMockServer.Variables[ResourceGroupNameKey];
                serviceName = HttpMockServer.Variables[ServiceNameKey];
                location = HttpMockServer.Variables[LocationKey];
                HttpMockServer.Variables.TryGetValue(TestCertificateKey, out var testcertificate);
                if (!string.IsNullOrEmpty(testcertificate))
                {
                    this.base64EncodedTestCertificateData = testcertificate;
                }
                HttpMockServer.Variables.TryGetValue(TestCertificatePasswordKey, out var testCertificatePwd);
                if (!string.IsNullOrEmpty(testCertificatePwd))
                {
                    this.testCertificatePassword = testCertificatePwd;
                }
            }

            tags = new Dictionary<string, string> { { "tag1", "value1" }, { "tag2", "value2" }, { "tag3", "value3" } };

            serviceProperties = new ApiManagementServiceResource
            {
                Sku = new ApiManagementServiceSkuProperties
                {
                    Name = SkuType.Developer,
                    Capacity = 1
                },
                Location = location,
                PublisherEmail = "apim@autorestsdk.com",
                PublisherName = "autorestsdk",
                Tags = tags
            };
        }

        public void TryCreateApiManagementService()
        {
            this.client.ApiManagementService.CreateOrUpdate(
                resourceGroupName: this.rgName,
                serviceName: this.serviceName,
                parameters: this.serviceProperties);

            var service = this.client.ApiManagementService.Get(this.rgName, this.serviceName);
            Assert.Equal(this.serviceName, service.Name);
        }


        public string GetOpenIdMetadataEndpointUrl()
        {
            return "https://" + TestUtilities.GenerateName("provider") + "." + TestUtilities.GenerateName("endpoint");
        }

        public string GetLocation(string regionIn = "US")
        {
            var provider = this.resourcesClient.Providers.Get("Microsoft.ApiManagement");
            return provider.ResourceTypes.Where(
                (resType) =>
                {
                    if (resType.ResourceType == "service")
                        return true;
                    else
                        return false;
                }
                ).First().Locations.Where(l => l.Contains(regionIn)).FirstOrDefault();
        }

        public static byte[] RandomBytes(int length)
        {
            if (HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                var bytes = new byte[length];
                Random rnd = new Random();
                rnd.NextBytes(bytes);
                HttpMockServer.Variables["RandomBytes"] = Convert.ToBase64String(bytes);
                return bytes;
            }
            else
            {
                return Convert.FromBase64String(HttpMockServer.Variables["RandomBytes"]);
            }
        }

        public OperationContract CreateOperationContract(string httpMethod)
        {
            return new OperationContract
            {
                DisplayName = "operation_" + TestUtilities.GenerateName(),
                Description = "description_" + TestUtilities.GenerateName(),
                UrlTemplate = "template_" + TestUtilities.GenerateName(),
                Method = httpMethod,
                Request = new RequestContract
                {
                    Description = "description_" + TestUtilities.GenerateName(),
                    Headers = new[]
                    {
                        new ParameterContract
                        {
                            Name = "param_" + TestUtilities.GenerateName(),
                            Description = "description_" + TestUtilities.GenerateName(),
                            Type = "int",
                            DefaultValue = "b",
                            Required = true,
                            Values = new[] { "a", "b", "c" }
                        },
                        new ParameterContract
                        {
                            Name = "param_" + TestUtilities.GenerateName(),
                            Description = "description_" + TestUtilities.GenerateName(),
                            Type = "bool",
                            DefaultValue = "e",
                            Required = false,
                            Values = new[] { "d", "e", "f" }
                        }
                    },
                    Representations = new[]
                    {
                        new RepresentationContract
                        {
                            ContentType = "text/plain",
                            Sample = "sample_" + TestUtilities.GenerateName(),
                        },
                        new RepresentationContract
                        {
                            ContentType = "application/xml",
                            Sample = "sample_" + TestUtilities.GenerateName(),
                        }
                    }
                },
                Responses = new[]
                {
                    new ResponseContract
                    {
                        StatusCode = 200,
                        Description = "description_" + TestUtilities.GenerateName(),
                        Representations = new[]
                        {
                            new RepresentationContract
                            {
                                ContentType = "application/json",
                                Sample = "sample_" + TestUtilities.GenerateName()
                            },
                            new RepresentationContract
                            {
                                ContentType = "application/xml",
                                Sample = "sample_" + TestUtilities.GenerateName()
                            }
                        }
                    }
                }
            };
        }
    }
}