using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is parameter/value pair in query string (used in request and response objects).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#queryString
    /// </remarks>
    public class QueryStringPair : IRequiresNameValue
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

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
