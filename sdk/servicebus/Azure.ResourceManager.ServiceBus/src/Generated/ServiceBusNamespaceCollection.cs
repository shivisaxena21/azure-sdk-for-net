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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of ServiceBusNamespace and their operations over its parent. </summary>
    public partial class ServiceBusNamespaceCollection : ArmCollection, IEnumerable<ServiceBusNamespace>, IAsyncEnumerable<ServiceBusNamespace>
    {
        private readonly ClientDiagnostics _serviceBusNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _serviceBusNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceCollection"/> class for mocking. </summary>
        protected ServiceBusNamespaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusNamespaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusNamespace.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ServiceBusNamespace.ResourceType, out string serviceBusNamespaceNamespacesApiVersion);
            _serviceBusNamespaceNamespacesRestClient = new NamespacesRestOperations(_serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serviceBusNamespaceNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_CreateOrUpdate
        /// <summary> Creates or updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="parameters"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ServiceBusNamespace>> CreateOrUpdateAsync(bool waitForCompletion, string namespaceName, ServiceBusNamespaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusNamespace>(new ServiceBusNamespaceOperationSource(Client), _serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_CreateOrUpdate
        /// <summary> Creates or updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="parameters"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ServiceBusNamespace> CreateOrUpdate(bool waitForCompletion, string namespaceName, ServiceBusNamespaceData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusNamespace>(new ServiceBusNamespaceOperationSource(Client), _serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Gets a description for the specified namespace. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> GetAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serviceBusNamespaceNamespacesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Gets a description for the specified namespace. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> Get(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken);
                if (response.Value == null)
                    throw _serviceBusNamespaceNamespacesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_ListByResourceGroup
        /// <summary> Gets the available namespaces within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusNamespace> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceBusNamespace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceBusNamespace>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_ListByResourceGroup
        /// <summary> Gets the available namespaces within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusNamespace> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceBusNamespace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusNamespaceNamespacesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceBusNamespace> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(namespaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> GetIfExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusNamespace>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Namespaces_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> GetIfExists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServiceBusNamespace>(null, response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusNamespace> IEnumerable<ServiceBusNamespace>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusNamespace> IAsyncEnumerable<ServiceBusNamespace>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
