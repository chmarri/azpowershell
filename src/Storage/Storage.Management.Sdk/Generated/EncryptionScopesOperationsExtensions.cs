// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EncryptionScopesOperations.
    /// </summary>
    public static partial class EncryptionScopesOperationsExtensions
    {
            /// <summary>
            /// Synchronously creates or updates an encryption scope under the specified
            /// storage account. If an encryption scope is already created and a subsequent
            /// request is issued with different properties, the encryption scope
            /// properties will be updated per the specified request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='encryptionScope'>
            /// Encryption scope properties to be used for the create or update.
            /// </param>
            public static EncryptionScope Put(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScope encryptionScope)
            {
                return operations.PutAsync(resourceGroupName, accountName, encryptionScopeName, encryptionScope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Synchronously creates or updates an encryption scope under the specified
            /// storage account. If an encryption scope is already created and a subsequent
            /// request is issued with different properties, the encryption scope
            /// properties will be updated per the specified request.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='encryptionScope'>
            /// Encryption scope properties to be used for the create or update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EncryptionScope> PutAsync(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScope encryptionScope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(resourceGroupName, accountName, encryptionScopeName, encryptionScope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update encryption scope properties as specified in the request body. Update
            /// fails if the specified encryption scope does not already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='encryptionScope'>
            /// Encryption scope properties to be used for the update.
            /// </param>
            public static EncryptionScope Patch(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScope encryptionScope)
            {
                return operations.PatchAsync(resourceGroupName, accountName, encryptionScopeName, encryptionScope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update encryption scope properties as specified in the request body. Update
            /// fails if the specified encryption scope does not already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='encryptionScope'>
            /// Encryption scope properties to be used for the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EncryptionScope> PatchAsync(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName, EncryptionScope encryptionScope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, accountName, encryptionScopeName, encryptionScope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the properties for the specified encryption scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            public static EncryptionScope Get(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName)
            {
                return operations.GetAsync(resourceGroupName, accountName, encryptionScopeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the properties for the specified encryption scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='encryptionScopeName'>
            /// The name of the encryption scope within the specified storage account.
            /// Encryption scope names must be between 3 and 63 characters in length and
            /// use numbers, lower-case letters and dash (-) only. Every dash (-) character
            /// must be immediately preceded and followed by a letter or number.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EncryptionScope> GetAsync(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, string encryptionScopeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, encryptionScopeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the encryption scopes available under the specified storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='maxpagesize'>
            /// Optional, specifies the maximum number of encryption scopes that will be
            /// included in the list response.
            /// </param>
            /// <param name='filter'>
            /// Optional. When specified, only encryption scope names starting with the
            /// filter will be listed.
            /// </param>
            /// <param name='include'>
            /// Optional, when specified, will list encryption scopes with the specific
            /// state. Defaults to All. Possible values include: 'All', 'Enabled',
            /// 'Disabled'
            /// </param>
            public static IPage<EncryptionScope> List(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, int? maxpagesize = default(int?), string filter = default(string), string include = default(string))
            {
                return operations.ListAsync(resourceGroupName, accountName, maxpagesize, filter, include).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the encryption scopes available under the specified storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='maxpagesize'>
            /// Optional, specifies the maximum number of encryption scopes that will be
            /// included in the list response.
            /// </param>
            /// <param name='filter'>
            /// Optional. When specified, only encryption scope names starting with the
            /// filter will be listed.
            /// </param>
            /// <param name='include'>
            /// Optional, when specified, will list encryption scopes with the specific
            /// state. Defaults to All. Possible values include: 'All', 'Enabled',
            /// 'Disabled'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EncryptionScope>> ListAsync(this IEncryptionScopesOperations operations, string resourceGroupName, string accountName, int? maxpagesize = default(int?), string filter = default(string), string include = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, maxpagesize, filter, include, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the encryption scopes available under the specified storage
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EncryptionScope> ListNext(this IEncryptionScopesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the encryption scopes available under the specified storage
            /// account.
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
            public static async Task<IPage<EncryptionScope>> ListNextAsync(this IEncryptionScopesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
