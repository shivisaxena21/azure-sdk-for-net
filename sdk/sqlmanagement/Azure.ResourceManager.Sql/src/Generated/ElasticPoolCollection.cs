// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ElasticPool and their operations over its parent. </summary>
    public partial class ElasticPoolCollection : ArmCollection, IEnumerable<ElasticPool>, IAsyncEnumerable<ElasticPool>
    {
        private readonly ClientDiagnostics _elasticPoolClientDiagnostics;
        private readonly ElasticPoolsRestOperations _elasticPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class for mocking. </summary>
        protected ElasticPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ElasticPool.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ElasticPool.ResourceType, out string elasticPoolApiVersion);
            _elasticPoolRestClient = new ElasticPoolsRestOperations(_elasticPoolClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, elasticPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_CreateOrUpdate
        /// <summary> Creates or updates an elastic pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ElasticPool>> CreateOrUpdateAsync(bool waitForCompletion, string elasticPoolName, ElasticPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ElasticPool>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_CreateOrUpdate
        /// <summary> Creates or updates an elastic pool. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ElasticPool> CreateOrUpdate(bool waitForCompletion, string elasticPoolName, ElasticPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ElasticPool>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Gets an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<ElasticPool>> GetAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _elasticPoolClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ElasticPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Gets an elastic pool. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPool> Get(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken);
                if (response.Value == null)
                    throw _elasticPoolClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_ListByServer
        /// <summary> Gets all elastic pools in a server. </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticPool> GetAllAsync(int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ElasticPool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ElasticPool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_ListByServer
        /// <summary> Gets all elastic pools in a server. </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticPool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticPool> GetAll(int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ElasticPool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ElasticPool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(elasticPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public async virtual Task<Response<ElasticPool>> GetIfExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ElasticPool>(null, response.GetRawResponse());
                return Response.FromValue(new ElasticPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ElasticPools_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPool> GetIfExists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ElasticPool>(null, response.GetRawResponse());
                return Response.FromValue(new ElasticPool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticPool> IEnumerable<ElasticPool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticPool> IAsyncEnumerable<ElasticPool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
