using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes details about response content (embedded in response object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#content
    /// The text field is populated with textual content only
    /// The text field is either HTTP decoded text or a encoded (e.g. "base64") representation of the response body
    /// Leave out the encoding field if the text field is HTTP decoded (decompressed and unchunked), than trans-coded from its original character set into UTF-8
    /// Before setting the text field, the HTTP response is decoded (decompressed and unchunked), than trans-coded from its original character set into UTF-8.
    /// Additionally, it can be encoded using e.g. base64.
    /// Ideally, the application should be able to unencode a base64 blob and get a byte-for-byte identical resource to what the browser operated on.
    /// encoding field is useful for including binary responses (e.g. images) into the HAR file.
    /// </remarks>
    public class Content : IAllowsComment
    {
        /// <summary>
        /// Constructs an empty/defaulted Content object
        /// </summary>
        /// <returns></returns>
        public Content() : this(0, "")
        {

        }

        /// <summary>
        /// Constructs a Content object with all required properties.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="mimeType"></param>
        public Content(int size, string mimeType)
        {
            MimeType = mimeType;
            Size = size;
        }

        /// <summary>
        /// Length of the returned content in bytes.
        /// </summary>
        /// <remarks>
        /// Should be equal to response.bodySize if there is no compression and bigger when the content has been compressed. 
        /// </remarks>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// Number of bytes saved. Leave out this field if the information is not available. 
        /// </summary>
        [JsonPropertyName("compression")]
        public int? Compression { get; set; }

        /// <summary>
        /// MIME type of the response text (value of the Content-Type response header). The charset attribute of the MIME type is included (if available)
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

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
        /// Leave out this field if the text field is HTTP decoded (decompressed and unchunked), than trans-coded from its original character set into UTF-8. 
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
