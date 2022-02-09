// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    internal class PrivateEndpointOperationSource : IOperationSource<PrivateEndpoint>
    {
        private readonly ArmClient _client;

        internal PrivateEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateEndpoint IOperationSource<PrivateEndpoint>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateEndpointData.DeserializePrivateEndpointData(document.RootElement);
            return new PrivateEndpoint(_client, data);
        }

        async ValueTask<PrivateEndpoint> IOperationSource<PrivateEndpoint>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateEndpointData.DeserializePrivateEndpointData(document.RootElement);
            return new PrivateEndpoint(_client, data);
        }
    }
}
