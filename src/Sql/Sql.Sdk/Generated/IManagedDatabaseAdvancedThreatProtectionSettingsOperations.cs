// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ManagedDatabaseAdvancedThreatProtectionSettingsOperations operations.
    /// </summary>
    public partial interface IManagedDatabaseAdvancedThreatProtectionSettingsOperations
    {
        /// <summary>
        /// Gets a list of managed database's Advanced Threat Protection
        /// states.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ManagedDatabaseAdvancedThreatProtection>>> ListByDatabaseWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a managed database's Advanced Threat Protection state.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedDatabaseAdvancedThreatProtection>> GetWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a managed database's Advanced Threat Protection
        /// state.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='parameters'>
        /// The managed database Advanced Threat Protection state.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ManagedDatabaseAdvancedThreatProtection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string managedInstanceName, string databaseName, ManagedDatabaseAdvancedThreatProtection parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of managed database's Advanced Threat Protection
        /// states.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ManagedDatabaseAdvancedThreatProtection>>> ListByDatabaseNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
