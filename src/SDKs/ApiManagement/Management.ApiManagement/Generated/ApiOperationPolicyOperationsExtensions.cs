// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiOperationPolicyOperations.
    /// </summary>
    public static partial class ApiOperationPolicyOperationsExtensions
    {
            /// <summary>
            /// Get the list of policy configuration at the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static PolicyCollection ListByOperation(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId)
            {
                return operations.ListByOperationAsync(resourceGroupName, serviceName, apiId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of policy configuration at the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyCollection> ListByOperationAsync(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByOperationWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the API operation policy specified
            /// by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static ApiOperationPolicyGetEntityTagHeaders GetEntityTag(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, apiId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the API operation policy specified
            /// by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiOperationPolicyGetEntityTagHeaders> GetEntityTagAsync(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get the policy configuration at the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            public static PolicyContract Get(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, apiId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the policy configuration at the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyContract> GetAsync(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates policy configuration for the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// The policy contents to apply.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static PolicyContract CreateOrUpdate(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, PolicyContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, apiId, operationId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates policy configuration for the API Operation level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API revision identifier. Must be unique in the current API Management
            /// service instance. Non-current revision has ;rev=n as a suffix where n is
            /// the revision number.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='parameters'>
            /// The policy contents to apply.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyContract> CreateOrUpdateAsync(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, PolicyContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, operationId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the policy configuration at the Api Operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, apiId, operationId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the policy configuration at the Api Operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='apiId'>
            /// API identifier. Must be unique in the current API Management service
            /// instance.
            /// </param>
            /// <param name='operationId'>
            /// Operation identifier within an API. Must be unique in the current API
            /// Management service instance.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApiOperationPolicyOperations operations, string resourceGroupName, string serviceName, string apiId, string operationId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, apiId, operationId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
