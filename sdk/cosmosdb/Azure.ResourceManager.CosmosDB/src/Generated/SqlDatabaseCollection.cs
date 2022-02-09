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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlDatabase and their operations over its parent. </summary>
    public partial class SqlDatabaseCollection : ArmCollection, IEnumerable<SqlDatabase>, IAsyncEnumerable<SqlDatabase>
    {
        private readonly ClientDiagnostics _sqlDatabaseSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlDatabaseSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseCollection"/> class for mocking. </summary>
        protected SqlDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlDatabaseSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", SqlDatabase.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SqlDatabase.ResourceType, out string sqlDatabaseSqlResourcesApiVersion);
            _sqlDatabaseSqlResourcesRestClient = new SqlResourcesRestOperations(_sqlDatabaseSqlResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlDatabaseSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccount.ResourceType), nameof(id));
        }

        /// <summary> Create or update an Azure Cosmos DB SQL database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateSqlDatabaseParameters"> The parameters to provide for the current SQL database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateSqlDatabaseParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SqlDatabase>> CreateOrUpdateAsync(bool waitForCompletion, string databaseName, SqlDatabaseCreateUpdateOptions createUpdateSqlDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (createUpdateSqlDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlDatabaseParameters));
            }

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSqlResourcesRestClient.CreateUpdateSqlDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<SqlDatabase>(new SqlDatabaseOperationSource(Client), _sqlDatabaseSqlResourcesClientDiagnostics, Pipeline, _sqlDatabaseSqlResourcesRestClient.CreateCreateUpdateSqlDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Create or update an Azure Cosmos DB SQL database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateSqlDatabaseParameters"> The parameters to provide for the current SQL database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateSqlDatabaseParameters"/> is null. </exception>
        public virtual ArmOperation<SqlDatabase> CreateOrUpdate(bool waitForCompletion, string databaseName, SqlDatabaseCreateUpdateOptions createUpdateSqlDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (createUpdateSqlDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlDatabaseParameters));
            }

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSqlResourcesRestClient.CreateUpdateSqlDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<SqlDatabase>(new SqlDatabaseOperationSource(Client), _sqlDatabaseSqlResourcesClientDiagnostics, Pipeline, _sqlDatabaseSqlResourcesRestClient.CreateCreateUpdateSqlDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateSqlDatabaseParameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> Gets the SQL database under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSqlResourcesRestClient.GetSqlDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlDatabaseSqlResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL database under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSqlResourcesRestClient.GetSqlDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw _sqlDatabaseSqlResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlDatabase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlDatabaseSqlResourcesRestClient.ListSqlDatabasesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlDatabase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlDatabaseSqlResourcesRestClient.ListSqlDatabases(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(databaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlDatabaseSqlResourcesRestClient.GetSqlDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _sqlDatabaseSqlResourcesClientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlDatabaseSqlResourcesRestClient.GetSqlDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlDatabase> IEnumerable<SqlDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlDatabase> IAsyncEnumerable<SqlDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
