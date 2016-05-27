
namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class CognitiveServicesResourceAndSku
    {
        /// <summary>
        /// Initializes a new instance of the CognitiveServicesResourceAndSku
        /// class.
        /// </summary>
        public CognitiveServicesResourceAndSku() { }

        /// <summary>
        /// Initializes a new instance of the CognitiveServicesResourceAndSku
        /// class.
        /// </summary>
        public CognitiveServicesResourceAndSku(string resourceType = default(string), Sku sku = default(Sku))
        {
            ResourceType = resourceType;
            Sku = sku;
        }

        /// <summary>
        /// Resource Namespace and Type
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

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
