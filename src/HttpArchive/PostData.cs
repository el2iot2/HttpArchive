using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#postdata
    /// </remarks>
    public abstract class PostData : IAllowsComment
    {
        internal PostData(string mimeType)
        {
            MimeType = mimeType;
        }
        /// <summary>
        /// Mime type of posted data. 
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Encoding used for request text field e.g "base64".
        /// </summary>
        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }
        
        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
