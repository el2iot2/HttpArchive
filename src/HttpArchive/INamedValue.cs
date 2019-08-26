using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Represents a shared structure for named values.
    /// </summary>
    /// <remarks>
    /// Used for:
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// http://www.softwareishard.com/blog/har-12-spec/#headers
    /// http://www.softwareishard.com/blog/har-12-spec/#queryString
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    public interface INamedValue
    {
        /// <summary>
        /// The name. 
        /// </summary>
        [JsonPropertyName("name")]
        string Name { get; set; }

        /// <summary>
        /// The value.
        /// </summary>
        [JsonPropertyName("value")]
        string Value { get; set; }
    }
}
