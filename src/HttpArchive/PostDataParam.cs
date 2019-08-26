using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// An element in the list of posted parameters, if any (embedded in postData object).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    public class PostDataParam : INamedValue
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
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Value { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
