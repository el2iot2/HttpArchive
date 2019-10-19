using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#postData
    /// </remarks>
    public class PostData : IAllowsComment
    {
        /// <summary>
        /// Mime type of posted data. 
        /// </summary>
        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// List of posted parameters (in case of URL encoded parameters). 
        /// </summary>
        [JsonPropertyName("params")]
        public IList<PostDataParam> Params { get; set; }

        /// <summary>
        /// Plain text posted data.  
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
