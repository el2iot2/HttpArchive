using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is represents a shared structure for named values.
    /// </summary>
    /// <remarks>
    /// Used for:
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// http://www.softwareishard.com/blog/har-12-spec/#headers
    /// http://www.softwareishard.com/blog/har-12-spec/#queryString
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    public class NamedValue : ArchiveObject
    {
        /// <summary>
        /// The name. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
