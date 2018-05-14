// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TestJobStreamsOperations operations.
    /// </summary>
    public partial interface ITestJobStreamsOperations
    {
        /// <summary>
        /// Retrieve a test job stream of the test job identified by runbook
        /// name and stream id.
        /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='jobStreamId'>
        /// The job stream id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobStream>> GetWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, string jobStreamId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a list of test job streams identified by runbook name.
        /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobStream>>> ListByTestJobWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a list of test job streams identified by runbook name.
        /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobStream>>> ListByTestJobNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
