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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of ServiceBusAuthorizationRule and their operations over its parent. </summary>
    public partial class NamespaceAuthorizationRuleCollection : ArmCollection, IEnumerable<NamespaceAuthorizationRule>, IAsyncEnumerable<NamespaceAuthorizationRule>
    {
        private readonly ClientDiagnostics _namespaceAuthorizationRuleClientDiagnostics;
        private readonly NamespaceAuthorizationRulesRestOperations _namespaceAuthorizationRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceAuthorizationRuleCollection"/> class for mocking. </summary>
        protected NamespaceAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NamespaceAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceAuthorizationRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", NamespaceAuthorizationRule.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NamespaceAuthorizationRule.ResourceType, out string namespaceAuthorizationRuleApiVersion);
            _namespaceAuthorizationRuleRestClient = new NamespaceAuthorizationRulesRestOperations(_namespaceAuthorizationRuleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, namespaceAuthorizationRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespace.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_CreateOrUpdate
        /// <summary> Creates or updates an authorization rule for a namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<NamespaceAuthorizationRule>> CreateOrUpdateAsync(bool waitForCompletion, string authorizationRuleName, ServiceBusAuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _namespaceAuthorizationRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<NamespaceAuthorizationRule>(Response.FromValue(new NamespaceAuthorizationRule(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_CreateOrUpdate
        /// <summary> Creates or updates an authorization rule for a namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<NamespaceAuthorizationRule> CreateOrUpdate(bool waitForCompletion, string authorizationRuleName, ServiceBusAuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _namespaceAuthorizationRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, parameters, cancellationToken);
                var operation = new ServiceBusArmOperation<NamespaceAuthorizationRule>(Response.FromValue(new NamespaceAuthorizationRule(Client, response), response.GetRawResponse()));
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceAuthorizationRule>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespaceAuthorizationRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _namespaceAuthorizationRuleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NamespaceAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceAuthorizationRule> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _namespaceAuthorizationRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw _namespaceAuthorizationRuleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_List
        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceAuthorizationRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NamespaceAuthorizationRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceAuthorizationRuleRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NamespaceAuthorizationRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceAuthorizationRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_List
        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceAuthorizationRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NamespaceAuthorizationRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceAuthorizationRuleRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NamespaceAuthorizationRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceAuthorizationRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceAuthorizationRule>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _namespaceAuthorizationRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NamespaceAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/AuthorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// OperationId: NamespaceAuthorizationRules_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceAuthorizationRule> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceAuthorizationRuleClientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _namespaceAuthorizationRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NamespaceAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NamespaceAuthorizationRule> IEnumerable<NamespaceAuthorizationRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceAuthorizationRule> IAsyncEnumerable<NamespaceAuthorizationRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
