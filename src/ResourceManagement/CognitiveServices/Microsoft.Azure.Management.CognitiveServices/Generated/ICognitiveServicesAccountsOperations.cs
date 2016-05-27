
namespace Microsoft.Azure.Management.CognitiveServices
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// CognitiveServicesAccountsOperations operations.
    /// </summary>
    public partial interface ICognitiveServicesAccountsOperations
    {
        /// <summary>
        /// Create Cognitive Services Account. Accounts is a resource group
        /// wide resource type. It holds the keys for developer to access
        /// intelligent APIs. It's also the resource type for billing.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide for the created account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccount>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, CognitiveServicesAccountCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a Cognitive Services account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='sku'>
        /// </param>
        /// <param name='tags'>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided
        /// for a resource. Each tag must have a key no greater than 128
        /// characters and value no greater than 256 characters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccount>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Cognitive Services account from the resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccount>> GetPropertiesWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all the resources of a particular type belonging to a
        /// resource group
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<CognitiveServicesAccount>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all the resources of a particular type belonging to a
        /// subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<CognitiveServicesAccount>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the account keys for the specified Cognitive Services
        /// account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Congitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccountKeys>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerates the specified account key for the specified Cognitive
        /// Services account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='keyName'>
        /// key name to generate (Key1|Key2). Possible values include: 'Key1',
        /// 'Key2'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccountKeys>> RegenerateKeyWithHttpMessagesAsync(string resourceGroupName, string accountName, KeyName? keyName = default(KeyName?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List available SKUs for the requested Cognitive Services account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the cognitive services account within the specified
        /// resource group. Cognitive Services account names must be between
        /// 3 and 24 characters in length and use numbers and lower-case
        /// letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CognitiveServicesAccountEnumerateSkusResult>> ListSkusWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
