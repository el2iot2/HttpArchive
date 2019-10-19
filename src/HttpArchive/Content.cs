using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes details about response content (embedded in response object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.2.md#content
    /// </remarks>
    public class Content : IAllowsComment
    {
        /// <summary>
        /// Length of the returned content in bytes.
        /// </summary>
        /// <remarks>
        /// Should be equal to response.bodySize if there is no compression and bigger when the content has been compressed. 
        /// </remarks>
        [JsonPropertyName("size")]
        public int Size { get; set; } = 0;

        /// <summary>
        /// Number of bytes saved. Leave out this field if the information is not available. 
        /// </summary>
        [JsonPropertyName("compression")]
        public int? Compression { get; set; }

        /// <summary>
        /// MIME type of the response text (value of the Content-Type response header). The charset attribute of the MIME type is included (if available)
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; } = "";

        /// <summary>
        /// Response body sent from the server or loaded from the browser cache.
        /// </summary>
        /// <remarks>
        /// This field is populated with textual content only. The text field is either HTTP decoded text or a encoded (e.g. "base64") representation of the response body. Leave out this field if the information is not available. 
        /// </remarks>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Encoding used for response text field e.g "base64".
        /// </summary>
        /// <remarks>
        /// Leave out this field if the text field is HTTP decoded (decompressed & unchunked), than trans-coded from its original character set into UTF-8. 
        /// </remarks>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
