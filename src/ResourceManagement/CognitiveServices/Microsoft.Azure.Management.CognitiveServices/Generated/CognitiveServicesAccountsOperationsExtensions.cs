
namespace Microsoft.Azure.Management.CognitiveServices
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for CognitiveServicesAccountsOperations.
    /// </summary>
    public static partial class CognitiveServicesAccountsOperationsExtensions
    {
            /// <summary>
            /// Create Cognitive Services Account. Accounts is a resource group wide
            /// resource type. It holds the keys for developer to access intelligent
            /// APIs. It's also the resource type for billing.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            public static CognitiveServicesAccount Create(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CognitiveServicesAccountCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).CreateAsync(resourceGroupName, accountName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Cognitive Services Account. Accounts is a resource group wide
            /// resource type. It holds the keys for developer to access intelligent
            /// APIs. It's also the resource type for billing.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccount> CreateAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CognitiveServicesAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Cognitive Services account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='sku'>
            /// </param>
            /// <param name='tags'>
            /// Gets or sets a list of key value pairs that describe the resource. These
            /// tags can be used in viewing and grouping this resource (across resource
            /// groups). A maximum of 15 tags can be provided for a resource. Each tag
            /// must have a key no greater than 128 characters and value no greater than
            /// 256 characters.
            /// </param>
            public static CognitiveServicesAccount Update(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).UpdateAsync(resourceGroupName, accountName, sku, tags), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Cognitive Services account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='sku'>
            /// </param>
            /// <param name='tags'>
            /// Gets or sets a list of key value pairs that describe the resource. These
            /// tags can be used in viewing and grouping this resource (across resource
            /// groups). A maximum of 15 tags can be provided for a resource. Each tag
            /// must have a key no greater than 128 characters and value no greater than
            /// 256 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccount> UpdateAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, sku, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Cognitive Services account from the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            public static void Delete(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName)
            {
                Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).DeleteAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Cognitive Services account from the resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Returns a Cognitive Services account specified by the parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            public static CognitiveServicesAccount GetProperties(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).GetPropertiesAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a Cognitive Services account specified by the parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccount> GetPropertiesAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all the resources of a particular type belonging to a resource
            /// group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static IEnumerable<CognitiveServicesAccount> ListByResourceGroup(this ICognitiveServicesAccountsOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all the resources of a particular type belonging to a resource
            /// group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<CognitiveServicesAccount>> ListByResourceGroupAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all the resources of a particular type belonging to a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<CognitiveServicesAccount> List(this ICognitiveServicesAccountsOperations operations)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all the resources of a particular type belonging to a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<CognitiveServicesAccount>> ListAsync(this ICognitiveServicesAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the account keys for the specified Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Congitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            public static CognitiveServicesAccountKeys ListKeys(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).ListKeysAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the account keys for the specified Cognitive Services account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Congitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccountKeys> ListKeysAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the specified account key for the specified Cognitive Services
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='keyName'>
            /// key name to generate (Key1|Key2). Possible values include: 'Key1', 'Key2'
            /// </param>
            public static CognitiveServicesAccountKeys RegenerateKey(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, KeyName? keyName = default(KeyName?))
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).RegenerateKeyAsync(resourceGroupName, accountName, keyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the specified account key for the specified Cognitive Services
            /// account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='keyName'>
            /// key name to generate (Key1|Key2). Possible values include: 'Key1', 'Key2'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccountKeys> RegenerateKeyAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, KeyName? keyName = default(KeyName?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List available SKUs for the requested Cognitive Services account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            public static CognitiveServicesAccountEnumerateSkusResult ListSkus(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((ICognitiveServicesAccountsOperations)s).ListSkusAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List available SKUs for the requested Cognitive Services account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the cognitive services account within the specified resource
            /// group. Cognitive Services account names must be between 3 and 24
            /// characters in length and use numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CognitiveServicesAccountEnumerateSkusResult> ListSkusAsync(this ICognitiveServicesAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
