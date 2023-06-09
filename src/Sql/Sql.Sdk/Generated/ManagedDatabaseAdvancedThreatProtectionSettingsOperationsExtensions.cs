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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedDatabaseAdvancedThreatProtectionSettingsOperations.
    /// </summary>
    public static partial class ManagedDatabaseAdvancedThreatProtectionSettingsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of managed database's Advanced Threat Protection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static IPage<ManagedDatabaseAdvancedThreatProtection> ListByDatabase(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed database's Advanced Threat Protection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedDatabaseAdvancedThreatProtection>> ListByDatabaseAsync(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a managed database's Advanced Threat Protection state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static ManagedDatabaseAdvancedThreatProtection Get(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a managed database's Advanced Threat Protection state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedDatabaseAdvancedThreatProtection> GetAsync(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a managed database's Advanced Threat Protection state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
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
            public static ManagedDatabaseAdvancedThreatProtection CreateOrUpdate(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedDatabaseAdvancedThreatProtection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, databaseName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a managed database's Advanced Threat Protection state.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedDatabaseAdvancedThreatProtection> CreateOrUpdateAsync(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, ManagedDatabaseAdvancedThreatProtection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of managed database's Advanced Threat Protection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedDatabaseAdvancedThreatProtection> ListByDatabaseNext(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string nextPageLink)
            {
                return operations.ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of managed database's Advanced Threat Protection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedDatabaseAdvancedThreatProtection>> ListByDatabaseNextAsync(this IManagedDatabaseAdvancedThreatProtectionSettingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
