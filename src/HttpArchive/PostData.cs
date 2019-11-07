using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#postdata
    /// </remarks>
    public class PostData : IAllowsComment
    {
        /// <summary>
        /// Creates a default/empty post data object (with text)
        /// </summary>
        /// <returns></returns>
        public PostData() : this("", Enumerable.Empty<PostDataParam>())
        {
        }

        /// <summary>
        /// Constructs an instance with text
        /// </summary>
        /// <param name="mimeType"></param>
        /// <param name="text"></param>
        public PostData(string mimeType, string text)
        {
            Text = text;
            MimeType = mimeType;
        }

        /// <summary>
        /// Constructs an instance with params
        /// </summary>
        /// <param name="mimeType"></param>
        /// <param name="@params"></param>
        public PostData(string mimeType, IEnumerable<PostDataParam> @params)
        {
            Params = @params.ToList();
            MimeType = mimeType;
        }

        /// <summary>
        /// List of posted parameters (in case of URL encoded parameters). 
        /// </summary>
        [JsonPropertyName("params")]
        public IList<PostDataParam>? Params { get; set; }

        /// <summary>
        /// Plain text posted data.  
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

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
