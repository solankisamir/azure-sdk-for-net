// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation hybrid runbook worker group.  (see
    /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
    /// for more information)
    /// </summary>
    internal partial class HybridRunbookWorkerGroupOperations : IServiceOperations<AutomationManagementClient>, IHybridRunbookWorkerGroupOperations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HybridRunbookWorkerGroupOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal HybridRunbookWorkerGroupOperations(AutomationManagementClient client)
        {
            this._client = client;
        }
        
        private AutomationManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Automation.AutomationManagementClient.
        /// </summary>
        public AutomationManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Retrieve a list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public async Task<HybridRunbookWorkerGroupsListResponse> ListAsync(string resourceGroupName, string automationAccount, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (automationAccount == null)
            {
                throw new ArgumentNullException("automationAccount");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("automationAccount", automationAccount);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/automationAccounts/";
            url = url + Uri.EscapeDataString(automationAccount);
            url = url + "/hybridRunbookWorkerGroups";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-01-01-preview");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("ocp-referer", url);
                httpRequest.Headers.Add("x-ms-version", "2014-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    HybridRunbookWorkerGroupsListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new HybridRunbookWorkerGroupsListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    HybridRunbookWorkerGroup hybridRunbookWorkerGroupInstance = new HybridRunbookWorkerGroup();
                                    result.HybridRunbookWorkerGroups.Add(hybridRunbookWorkerGroupInstance);
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        hybridRunbookWorkerGroupInstance.Name = nameInstance;
                                    }
                                    
                                    JToken hybridRunbookWorkersArray = valueValue["hybridRunbookWorkers"];
                                    if (hybridRunbookWorkersArray != null && hybridRunbookWorkersArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken hybridRunbookWorkersValue in ((JArray)hybridRunbookWorkersArray))
                                        {
                                            HybridRunbookWorker hybridRunbookWorkerInstance = new HybridRunbookWorker();
                                            hybridRunbookWorkerGroupInstance.HybridRunbookWorkers.Add(hybridRunbookWorkerInstance);
                                            
                                            JToken nameValue2 = hybridRunbookWorkersValue["name"];
                                            if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                                            {
                                                string nameInstance2 = ((string)nameValue2);
                                                hybridRunbookWorkerInstance.Name = nameInstance2;
                                            }
                                            
                                            JToken ipAddressValue = hybridRunbookWorkersValue["ipAddress"];
                                            if (ipAddressValue != null && ipAddressValue.Type != JTokenType.Null)
                                            {
                                                string ipAddressInstance = ((string)ipAddressValue);
                                                hybridRunbookWorkerInstance.IpAddress = ipAddressInstance;
                                            }
                                            
                                            JToken registrationTimeValue = hybridRunbookWorkersValue["registrationTime"];
                                            if (registrationTimeValue != null && registrationTimeValue.Type != JTokenType.Null)
                                            {
                                                DateTimeOffset registrationTimeInstance = ((DateTimeOffset)registrationTimeValue);
                                                hybridRunbookWorkerInstance.RegistrationDateTime = registrationTimeInstance;
                                            }
                                        }
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = Regex.Match(((string)odatanextLinkValue), "^.*[&\\?]\\$skiptoken=([^&]*)(&.*)?").Groups[1].Value;
                                result.SkipToken = odatanextLinkInstance;
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                result.NextLink = nextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Retrieve next list of hybrid runbook worker groups.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list hybrid runbook worker groups.
        /// </returns>
        public async Task<HybridRunbookWorkerGroupsListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken)
        {
            // Validate
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextLink", nextLink);
                TracingAdapter.Enter(invocationId, this, "ListNextAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + nextLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("ocp-referer", url);
                httpRequest.Headers.Add("x-ms-version", "2014-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    HybridRunbookWorkerGroupsListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new HybridRunbookWorkerGroupsListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    HybridRunbookWorkerGroup hybridRunbookWorkerGroupInstance = new HybridRunbookWorkerGroup();
                                    result.HybridRunbookWorkerGroups.Add(hybridRunbookWorkerGroupInstance);
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        hybridRunbookWorkerGroupInstance.Name = nameInstance;
                                    }
                                    
                                    JToken hybridRunbookWorkersArray = valueValue["hybridRunbookWorkers"];
                                    if (hybridRunbookWorkersArray != null && hybridRunbookWorkersArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken hybridRunbookWorkersValue in ((JArray)hybridRunbookWorkersArray))
                                        {
                                            HybridRunbookWorker hybridRunbookWorkerInstance = new HybridRunbookWorker();
                                            hybridRunbookWorkerGroupInstance.HybridRunbookWorkers.Add(hybridRunbookWorkerInstance);
                                            
                                            JToken nameValue2 = hybridRunbookWorkersValue["name"];
                                            if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                                            {
                                                string nameInstance2 = ((string)nameValue2);
                                                hybridRunbookWorkerInstance.Name = nameInstance2;
                                            }
                                            
                                            JToken ipAddressValue = hybridRunbookWorkersValue["ipAddress"];
                                            if (ipAddressValue != null && ipAddressValue.Type != JTokenType.Null)
                                            {
                                                string ipAddressInstance = ((string)ipAddressValue);
                                                hybridRunbookWorkerInstance.IpAddress = ipAddressInstance;
                                            }
                                            
                                            JToken registrationTimeValue = hybridRunbookWorkersValue["registrationTime"];
                                            if (registrationTimeValue != null && registrationTimeValue.Type != JTokenType.Null)
                                            {
                                                DateTimeOffset registrationTimeInstance = ((DateTimeOffset)registrationTimeValue);
                                                hybridRunbookWorkerInstance.RegistrationDateTime = registrationTimeInstance;
                                            }
                                        }
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = Regex.Match(((string)odatanextLinkValue), "^.*[&\\?]\\$skiptoken=([^&]*)(&.*)?").Groups[1].Value;
                                result.SkipToken = odatanextLinkInstance;
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                result.NextLink = nextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
