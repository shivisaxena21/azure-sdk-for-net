
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
    /// The SKU of the cognitive services account.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku(SkuName name, SkuTier? tier = default(SkuTier?))
        {
            Name = name;
            Tier = tier;
        }

        /// <summary>
        /// Gets or sets the sku name. Required for account creation, optional
        /// for update. Possible values include: 'F0', 'S0', 'S1', 'S2',
        /// 'S3', 'S4'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets the sku tier. This is based on the SKU name. Possible values
        /// include: 'Free', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public SkuTier? Tier { get; private set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
