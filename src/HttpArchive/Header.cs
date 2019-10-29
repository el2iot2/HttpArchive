using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is an entry in the list of all headers (used in request and response objects).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#headers
    /// </remarks>
    public class Header : IRequiresNameValue
    {
        /// <summary>
        /// Constructs a default/empty header
        /// </summary>
        /// <returns></returns>
        public Header() : this("", "")
        {
        }

        /// <summary>
        /// Constructs a header with all required values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public Header(string name, string value)
        {
            Name = name;
            Value = value;
        }

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
