using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// An element in the list of posted parameters, if any (embedded in postData object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#params
    /// </remarks>
    public class PostDataParam : IRequiresName
    {
        /// <summary>
        /// Constructs a new/empty PostDataParam
        /// </summary>
        /// <returns></returns>
        public PostDataParam() : this("")
        {

        }

        /// <summary>
        /// Constructs a PostDataParam with all required parameters
        /// </summary>
        /// <param name="name"></param>
        public PostDataParam(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name of a posted file.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Content type of a posted file.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Name of a posted parameter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of a posted parameter or content of a posted file.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Encoding used for value field e.g "base64".
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
    }
}
