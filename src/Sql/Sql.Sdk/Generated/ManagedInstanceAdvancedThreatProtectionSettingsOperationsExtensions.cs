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
    /// Extension methods for ManagedInstanceAdvancedThreatProtectionSettingsOperations.
    /// </summary>
    public static partial class ManagedInstanceAdvancedThreatProtectionSettingsOperationsExtensions
    {
            /// <summary>
            /// Get the managed instance's Advanced Threat Protection settings.
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
            public static IPage<ManagedInstanceAdvancedThreatProtection> ListByInstance(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.ListByInstanceAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the managed instance's Advanced Threat Protection settings.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedInstanceAdvancedThreatProtection>> ListByInstanceAsync(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a managed instance's Advanced Threat Protection state.
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
            public static ManagedInstanceAdvancedThreatProtection Get(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a managed instance's Advanced Threat Protection state.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdvancedThreatProtection> GetAsync(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates Advanced Threat Protection settings.
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
            /// <param name='parameters'>
            /// The managed instance Advanced Threat Protection state.
            /// </param>
            public static ManagedInstanceAdvancedThreatProtection CreateOrUpdate(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdvancedThreatProtection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates Advanced Threat Protection settings.
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
            /// <param name='parameters'>
            /// The managed instance Advanced Threat Protection state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdvancedThreatProtection> CreateOrUpdateAsync(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdvancedThreatProtection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates Advanced Threat Protection settings.
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
            /// <param name='parameters'>
            /// The managed instance Advanced Threat Protection state.
            /// </param>
            public static ManagedInstanceAdvancedThreatProtection BeginCreateOrUpdate(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdvancedThreatProtection parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, managedInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates Advanced Threat Protection settings.
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
            /// <param name='parameters'>
            /// The managed instance Advanced Threat Protection state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceAdvancedThreatProtection> BeginCreateOrUpdateAsync(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string resourceGroupName, string managedInstanceName, ManagedInstanceAdvancedThreatProtection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the managed instance's Advanced Threat Protection settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedInstanceAdvancedThreatProtection> ListByInstanceNext(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string nextPageLink)
            {
                return operations.ListByInstanceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the managed instance's Advanced Threat Protection settings.
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
            public static async Task<IPage<ManagedInstanceAdvancedThreatProtection>> ListByInstanceNextAsync(this IManagedInstanceAdvancedThreatProtectionSettingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByInstanceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
