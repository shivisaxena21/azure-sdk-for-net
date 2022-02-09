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
    /// <summary> A class representing collection of FailoverGroup and their operations over its parent. </summary>
    public partial class FailoverGroupCollection : ArmCollection, IEnumerable<FailoverGroup>, IAsyncEnumerable<FailoverGroup>
    {
        private readonly ClientDiagnostics _failoverGroupClientDiagnostics;
        private readonly FailoverGroupsRestOperations _failoverGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="FailoverGroupCollection"/> class for mocking. </summary>
        protected FailoverGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FailoverGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FailoverGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _failoverGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", FailoverGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(FailoverGroup.ResourceType, out string failoverGroupApiVersion);
            _failoverGroupRestClient = new FailoverGroupsRestOperations(_failoverGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, failoverGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_CreateOrUpdate
        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<FailoverGroup>> CreateOrUpdateAsync(bool waitForCompletion, string failoverGroupName, FailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<FailoverGroup>(new FailoverGroupOperationSource(Client), _failoverGroupClientDiagnostics, Pipeline, _failoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_CreateOrUpdate
        /// <summary> Creates or updates a failover group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="parameters"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<FailoverGroup> CreateOrUpdate(bool waitForCompletion, string failoverGroupName, FailoverGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters, cancellationToken);
                var operation = new SqlArmOperation<FailoverGroup>(new FailoverGroupOperationSource(Client), _failoverGroupClientDiagnostics, Pipeline, _failoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<FailoverGroup>> GetAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _failoverGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Gets a failover group. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<FailoverGroup> Get(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken);
                if (response.Value == null)
                    throw _failoverGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_ListByServer
        /// <summary> Lists the failover groups in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FailoverGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FailoverGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _failoverGroupRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FailoverGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _failoverGroupRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_ListByServer
        /// <summary> Lists the failover groups in a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FailoverGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FailoverGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FailoverGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _failoverGroupRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FailoverGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _failoverGroupRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FailoverGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(failoverGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public async virtual Task<Response<FailoverGroup>> GetIfExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FailoverGroup>(null, response.GetRawResponse());
                return Response.FromValue(new FailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: FailoverGroups_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<FailoverGroup> GetIfExists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FailoverGroup>(null, response.GetRawResponse());
                return Response.FromValue(new FailoverGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FailoverGroup> IEnumerable<FailoverGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FailoverGroup> IAsyncEnumerable<FailoverGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
