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
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public partial class AutomationManagementClient : ServiceClient<AutomationManagementClient>, IAutomationManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _resourceNamespace;
        
        /// <summary>
        /// Gets or sets the resource namespace.
        /// </summary>
        public string ResourceNamespace
        {
            get { return this._resourceNamespace; }
            set { this._resourceNamespace = value; }
        }
        
        private IActivityOperations _activities;
        
        /// <summary>
        /// Service operation for automation activities.  (see
        /// http://aka.ms/azureautomationsdk/activityoperations for more
        /// information)
        /// </summary>
        public virtual IActivityOperations Activities
        {
            get { return this._activities; }
        }
        
        private IAgentRegistrationOperation _agentRegistrationInformation;
        
        /// <summary>
        /// Service operation for automation agent registration information.
        /// (see http://aka.ms/azureautomationsdk/agentregistrationoperations
        /// for more information)
        /// </summary>
        public virtual IAgentRegistrationOperation AgentRegistrationInformation
        {
            get { return this._agentRegistrationInformation; }
        }
        
        private IAutomationAccountOperations _automationAccounts;
        
        /// <summary>
        /// Service operation for automation accounts.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        public virtual IAutomationAccountOperations AutomationAccounts
        {
            get { return this._automationAccounts; }
        }
        
        private ICertificateOperations _certificates;
        
        /// <summary>
        /// Service operation for automation certificates.  (see
        /// http://aka.ms/azureautomationsdk/certificateoperations for more
        /// information)
        /// </summary>
        public virtual ICertificateOperations Certificates
        {
            get { return this._certificates; }
        }
        
        private IConnectionOperations _connections;
        
        /// <summary>
        /// Service operation for automation connections.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        public virtual IConnectionOperations Connections
        {
            get { return this._connections; }
        }
        
        private IConnectionTypeOperations _connectionTypes;
        
        /// <summary>
        /// Service operation for automation connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        public virtual IConnectionTypeOperations ConnectionTypes
        {
            get { return this._connectionTypes; }
        }
        
        private ICredentialOperations _psCredentials;
        
        /// <summary>
        /// Service operation for automation credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        public virtual ICredentialOperations PsCredentials
        {
            get { return this._psCredentials; }
        }
        
        private IDscCompilationJobOperations _compilationJobs;
        
        /// <summary>
        /// Service operation for automation dsc configuration compile jobs.
        /// (see
        /// http://aka.ms/azureautomationsdk/dscccompilationjoboperations for
        /// more information)
        /// </summary>
        public virtual IDscCompilationJobOperations CompilationJobs
        {
            get { return this._compilationJobs; }
        }
        
        private IDscConfigurationOperations _configurations;
        
        /// <summary>
        /// Service operation for configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        public virtual IDscConfigurationOperations Configurations
        {
            get { return this._configurations; }
        }
        
        private IDscNodeConfigurationOperations _nodeConfigurations;
        
        /// <summary>
        /// Service operation for automation dsc node configurations.  (see
        /// http://aka.ms/azureautomationsdk/dscnodeconfigurations for more
        /// information)
        /// </summary>
        public virtual IDscNodeConfigurationOperations NodeConfigurations
        {
            get { return this._nodeConfigurations; }
        }
        
        private IDscNodeOperations _nodes;
        
        /// <summary>
        /// Service operation for dsc nodes.  (see
        /// http://aka.ms/azureautomationsdk/dscnodeoperations for more
        /// information)
        /// </summary>
        public virtual IDscNodeOperations Nodes
        {
            get { return this._nodes; }
        }
        
        private IDscNodeReportsOperations _nodeReports;
        
        /// <summary>
        /// Service operation for node reports.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        public virtual IDscNodeReportsOperations NodeReports
        {
            get { return this._nodeReports; }
        }
        
        private IHybridRunbookWorkerGroupOperations _hybridRunbookWorkerGroups;
        
        /// <summary>
        /// Service operation for automation hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        public virtual IHybridRunbookWorkerGroupOperations HybridRunbookWorkerGroups
        {
            get { return this._hybridRunbookWorkerGroups; }
        }
        
        private IJobOperations _jobs;
        
        /// <summary>
        /// Service operation for automation jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        public virtual IJobOperations Jobs
        {
            get { return this._jobs; }
        }
        
        private IJobScheduleOperations _jobSchedules;
        
        /// <summary>
        /// Service operation for automation job schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        public virtual IJobScheduleOperations JobSchedules
        {
            get { return this._jobSchedules; }
        }
        
        private IJobStreamOperations _jobStreams;
        
        /// <summary>
        /// Service operation for automation job streams.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        public virtual IJobStreamOperations JobStreams
        {
            get { return this._jobStreams; }
        }
        
        private IModuleOperations _modules;
        
        /// <summary>
        /// Service operation for automation modules.  (see
        /// http://aka.ms/azureautomationsdk/moduleoperations for more
        /// information)
        /// </summary>
        public virtual IModuleOperations Modules
        {
            get { return this._modules; }
        }
        
        private IRunbookDraftOperations _runbookDraft;
        
        /// <summary>
        /// Service operation for automation runbook draft.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        public virtual IRunbookDraftOperations RunbookDraft
        {
            get { return this._runbookDraft; }
        }
        
        private IRunbookOperations _runbooks;
        
        /// <summary>
        /// Service operation for automation runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        public virtual IRunbookOperations Runbooks
        {
            get { return this._runbooks; }
        }
        
        private IScheduleOperations _schedules;
        
        /// <summary>
        /// Service operation for automation schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        public virtual IScheduleOperations Schedules
        {
            get { return this._schedules; }
        }
        
        private ITestJobOperations _testJobs;
        
        /// <summary>
        /// Service operation for automation test jobs.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        public virtual ITestJobOperations TestJobs
        {
            get { return this._testJobs; }
        }
        
        private IVariableOperations _variables;
        
        /// <summary>
        /// Service operation for automation variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        public virtual IVariableOperations Variables
        {
            get { return this._variables; }
        }
        
        private IWebhookOperations _webhooks;
        
        /// <summary>
        /// Service operation for automation webhook.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        public virtual IWebhookOperations Webhooks
        {
            get { return this._webhooks; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        public AutomationManagementClient()
            : base()
        {
            this._activities = new ActivityOperations(this);
            this._agentRegistrationInformation = new AgentRegistrationOperation(this);
            this._automationAccounts = new AutomationAccountOperations(this);
            this._certificates = new CertificateOperations(this);
            this._connections = new ConnectionOperations(this);
            this._connectionTypes = new ConnectionTypeOperations(this);
            this._psCredentials = new CredentialOperations(this);
            this._compilationJobs = new DscCompilationJobOperations(this);
            this._configurations = new DscConfigurationOperations(this);
            this._nodeConfigurations = new DscNodeConfigurationOperations(this);
            this._nodes = new DscNodeOperations(this);
            this._nodeReports = new DscNodeReportsOperations(this);
            this._hybridRunbookWorkerGroups = new HybridRunbookWorkerGroupOperations(this);
            this._jobs = new JobOperations(this);
            this._jobSchedules = new JobScheduleOperations(this);
            this._jobStreams = new JobStreamOperations(this);
            this._modules = new ModuleOperations(this);
            this._runbookDraft = new RunbookDraftOperations(this);
            this._runbooks = new RunbookOperations(this);
            this._schedules = new ScheduleOperations(this);
            this._testJobs = new TestJobOperations(this);
            this._variables = new VariableOperations(this);
            this._webhooks = new WebhookOperations(this);
            this._resourceNamespace = "Microsoft.Automation";
            this._apiVersion = "2014-06-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public AutomationManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public AutomationManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AutomationManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._activities = new ActivityOperations(this);
            this._agentRegistrationInformation = new AgentRegistrationOperation(this);
            this._automationAccounts = new AutomationAccountOperations(this);
            this._certificates = new CertificateOperations(this);
            this._connections = new ConnectionOperations(this);
            this._connectionTypes = new ConnectionTypeOperations(this);
            this._psCredentials = new CredentialOperations(this);
            this._compilationJobs = new DscCompilationJobOperations(this);
            this._configurations = new DscConfigurationOperations(this);
            this._nodeConfigurations = new DscNodeConfigurationOperations(this);
            this._nodes = new DscNodeOperations(this);
            this._nodeReports = new DscNodeReportsOperations(this);
            this._hybridRunbookWorkerGroups = new HybridRunbookWorkerGroupOperations(this);
            this._jobs = new JobOperations(this);
            this._jobSchedules = new JobScheduleOperations(this);
            this._jobStreams = new JobStreamOperations(this);
            this._modules = new ModuleOperations(this);
            this._runbookDraft = new RunbookDraftOperations(this);
            this._runbooks = new RunbookOperations(this);
            this._schedules = new ScheduleOperations(this);
            this._testJobs = new TestJobOperations(this);
            this._variables = new VariableOperations(this);
            this._webhooks = new WebhookOperations(this);
            this._resourceNamespace = "Microsoft.Automation";
            this._apiVersion = "2014-06-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AutomationManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the AutomationManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public AutomationManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// AutomationManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of AutomationManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<AutomationManagementClient> client)
        {
            base.Clone(client);
            
            if (client is AutomationManagementClient)
            {
                AutomationManagementClient clonedClient = ((AutomationManagementClient)client);
                
                clonedClient._resourceNamespace = this._resourceNamespace;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public async Task<LongRunningOperationResultResponse> GetOperationResultStatusAsync(string operationStatusLink, CancellationToken cancellationToken)
        {
            // Validate
            if (operationStatusLink == null)
            {
                throw new ArgumentNullException("operationStatusLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationStatusLink", operationStatusLink);
                TracingAdapter.Enter(invocationId, this, "GetOperationResultStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + operationStatusLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2014-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Created && statusCode != HttpStatusCode.NoContent)
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
                    LongRunningOperationResultResponse result = null;
                    // Deserialize Response
                    result = new LongRunningOperationResultResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (statusCode == HttpStatusCode.BadRequest)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.Created)
                    {
                        result.Status = OperationStatus.Succeeded;
                    }
                    if (statusCode == HttpStatusCode.NoContent)
                    {
                        result.Status = OperationStatus.Succeeded;
                    }
                    if (statusCode == HttpStatusCode.OK)
                    {
                        result.Status = OperationStatus.Succeeded;
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
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// Required. The request ID for the request you wish to track. The
        /// request ID is returned in the x-ms-request-id response header for
        /// every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<LongRunningOperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken)
        {
            // Validate
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("requestId", requestId);
                TracingAdapter.Enter(invocationId, this, "GetOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Credentials.SubscriptionId);
            }
            url = url + "/operations/";
            url = url + Uri.EscapeDataString(requestId);
            string baseUrl = this.BaseUri.AbsoluteUri;
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
                httpRequest.Headers.Add("x-ms-version", "2014-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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
                    LongRunningOperationStatusResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new LongRunningOperationStatusResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement operationElement = responseDoc.Element(XName.Get("Operation", "http://schemas.microsoft.com/windowsazure"));
                        if (operationElement != null)
                        {
                            XElement idElement = operationElement.Element(XName.Get("ID", "http://schemas.microsoft.com/windowsazure"));
                            if (idElement != null)
                            {
                                string idInstance = idElement.Value;
                                result.Id = idInstance;
                            }
                            
                            XElement statusElement = operationElement.Element(XName.Get("Status", "http://schemas.microsoft.com/windowsazure"));
                            if (statusElement != null)
                            {
                                OperationStatus statusInstance = ((OperationStatus)Enum.Parse(typeof(OperationStatus), statusElement.Value, true));
                                result.Status = statusInstance;
                            }
                            
                            XElement httpStatusCodeElement = operationElement.Element(XName.Get("HttpStatusCode", "http://schemas.microsoft.com/windowsazure"));
                            if (httpStatusCodeElement != null)
                            {
                                HttpStatusCode httpStatusCodeInstance = ((HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), httpStatusCodeElement.Value, true));
                                result.HttpStatusCode = httpStatusCodeInstance;
                            }
                            
                            XElement errorElement = operationElement.Element(XName.Get("Error", "http://schemas.microsoft.com/windowsazure"));
                            if (errorElement != null)
                            {
                                LongRunningOperationStatusResponse.ErrorDetails errorInstance = new LongRunningOperationStatusResponse.ErrorDetails();
                                result.Error = errorInstance;
                                
                                XElement codeElement = errorElement.Element(XName.Get("Code", "http://schemas.microsoft.com/windowsazure"));
                                if (codeElement != null)
                                {
                                    string codeInstance = codeElement.Value;
                                    errorInstance.Code = codeInstance;
                                }
                                
                                XElement messageElement = errorElement.Element(XName.Get("Message", "http://schemas.microsoft.com/windowsazure"));
                                if (messageElement != null)
                                {
                                    string messageInstance = messageElement.Value;
                                    errorInstance.Message = messageInstance;
                                }
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
