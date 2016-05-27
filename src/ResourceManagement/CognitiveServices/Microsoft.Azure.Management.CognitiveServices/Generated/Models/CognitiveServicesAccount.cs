
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
    /// Cognitive Services Account is an Azure resource representing the
    /// provisioned account, its type, location and SKU.
    /// </summary>
    [JsonTransformation]
    public partial class CognitiveServicesAccount : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccount class.
        /// </summary>
        public CognitiveServicesAccount() { }

        /// <summary>
        /// Initializes a new instance of the CognitiveServicesAccount class.
        /// </summary>
        public CognitiveServicesAccount(string etag = default(string), string id = default(string), string kind = default(string), string location = default(string), string name = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), string endpoint = default(string), Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>), string type = default(string))
        {
            Etag = etag;
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            Sku = sku;
            Tags = tags;
            Type = type;
        }

        /// <summary>
        /// Entity Tag
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The id of the created account
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Type of cognitive service account.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// The location of the resource
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// The name of the created account
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the status of the cognitive services account at the time the
        /// operation was called. Possible values include: 'Creating',
        /// 'ResolvingDNS', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Endpoint of the created account
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; set; }

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
        /// Resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

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
