// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Reference to RouteTableV3 associated with the connection. </summary>
    public partial class RoutingConfigurationNfvSubResource
    {
        /// <summary> Initializes a new instance of RoutingConfigurationNfvSubResource. </summary>
        public RoutingConfigurationNfvSubResource()
        {
        }

        /// <summary> Initializes a new instance of RoutingConfigurationNfvSubResource. </summary>
        /// <param name="resourceUri"> Resource ID. </param>
        internal RoutingConfigurationNfvSubResource(Uri resourceUri)
        {
            ResourceUri = resourceUri;
        }

        /// <summary> Resource ID. </summary>
        public Uri ResourceUri { get; set; }
    }
}
