using System.Text.Json.Serialization;

namespace example.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum  RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}