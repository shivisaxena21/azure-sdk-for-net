
namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuTier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuTier
    {
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Premium")]
        Premium
    }
}
