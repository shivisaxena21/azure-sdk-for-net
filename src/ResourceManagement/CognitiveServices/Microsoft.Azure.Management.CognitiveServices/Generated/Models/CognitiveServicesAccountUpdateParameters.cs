
namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    public partial class CognitiveServicesAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountUpdateParameters class.
        /// </summary>
        public CognitiveServicesAccountUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountUpdateParameters class.
        /// </summary>
        public CognitiveServicesAccountUpdateParameters(Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            Tags = tags;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided
        /// for a resource. Each tag must have a key no greater than 128
        /// characters and value no greater than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
        }
    }
}
