using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes plain text encoded posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#postdata
    /// </remarks>
    public class TextPostData : PostData
    {
        /// <summary>
        /// Creates a default/empty post data object (with text)
        /// </summary>
        /// <returns></returns>
        public TextPostData() : this("", "")
        {
        }

        /// <summary>
        /// Constructs an instance with text
        /// </summary>
        /// <param name="mimeType"></param>
        /// <param name="text"></param>
        public TextPostData(string mimeType, string text) : base(mimeType: mimeType)
        {
            Text = text;
        }

        /// <summary>
        /// Plain text posted data.  
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}
