using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// An element in the list of posted parameters, if any (embedded in postData object).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    public class PostDataParam : NamedValue
    {
        /// <summary>
        /// Name of a posted file.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Content type of a posted file.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    }
}
