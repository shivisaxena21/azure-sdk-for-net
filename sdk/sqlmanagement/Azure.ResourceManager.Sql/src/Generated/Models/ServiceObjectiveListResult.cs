// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the response to a get database service objectives request. </summary>
    internal partial class ServiceObjectiveListResult
    {
        /// <summary> Initializes a new instance of ServiceObjectiveListResult. </summary>
        /// <param name="value"> The list of database service objectives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ServiceObjectiveListResult(IEnumerable<ServiceObjectiveData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ServiceObjectiveListResult. </summary>
        /// <param name="value"> The list of database service objectives. </param>
        internal ServiceObjectiveListResult(IReadOnlyList<ServiceObjectiveData> value)
        {
            Value = value;
        }

        /// <summary> The list of database service objectives. </summary>
        public IReadOnlyList<ServiceObjectiveData> Value { get; }
    }
}
