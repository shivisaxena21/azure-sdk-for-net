
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
    public partial class CognitiveServicesAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountCreateParameters class.
        /// </summary>
        public CognitiveServicesAccountCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountCreateParameters class.
        /// </summary>
        public CognitiveServicesAccountCreateParameters(Sku sku, Kind kind, string location, object properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            Kind = kind;
            Location = location;
            Tags = tags;
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Required. Indicates the type of cognitive service account.
        /// Possible values include: 'ComputerVision', 'Emotion', 'Face',
        /// 'LUIS', 'Recommendations', 'Speech', 'TextAnalytics', 'WebLM'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind Kind { get; set; }

        /// <summary>
        /// Required. Gets or sets the location of the resource. This will be
        /// one of the supported and registered Azure Geo Regions (e.g. West
        /// US, East US, Southeast Asia, etc.). The geo region of a resource
        /// cannot be changed once it is created, but if an identical geo
        /// region is specified on update the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

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
        /// Must exist in the request. Must not be null.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
        }
    }
}
