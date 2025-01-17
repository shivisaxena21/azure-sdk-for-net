// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class JobSecretsCollection
    {
        internal static JobSecretsCollection DeserializeJobSecretsCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppWritableSecret> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new JobSecretsCollection(value);
        }
    }
}
