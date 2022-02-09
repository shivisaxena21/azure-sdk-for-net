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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedBackupShortTermRetentionPolicy and their operations over its parent. </summary>
    public partial class ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>, IAsyncEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>
    {
        private readonly ClientDiagnostics _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedBackupShortTermRetentionPoliciesRestOperations _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceDatabaseBackupShortTermRetentionPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ManagedInstanceDatabaseBackupShortTermRetentionPolicy.ResourceType, out string managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient = new ManagedBackupShortTermRetentionPoliciesRestOperations(_managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_CreateOrUpdate
        /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> CreateOrUpdateAsync(bool waitForCompletion, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(new ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource(Client), _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_CreateOrUpdate
        /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> CreateOrUpdate(bool waitForCompletion, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(new ManagedInstanceDatabaseBackupShortTermRetentionPolicyOperationSource(Client), _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a managed database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> GetAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a managed database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> Get(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_ListByDatabase
        /// <summary> Gets a managed database&apos;s short term retention policy list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_ListByDatabase
        /// <summary> Gets a managed database&apos;s short term retention policy list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> GetIfExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> GetIfExists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> IAsyncEnumerable<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
