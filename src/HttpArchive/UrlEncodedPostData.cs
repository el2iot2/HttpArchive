using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes URL encoded parameter posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#postdata
    /// </remarks>
    public class UrlEncodedPostData : PostData
    {
        /// <summary>
        /// Creates a default/empty post data object (with text)
        /// </summary>
        /// <returns></returns>
        public UrlEncodedPostData() : this("", null)
        {

        }

        /// <summary>
        /// Constructs an instance with params
        /// </summary>
        /// <param name="mimeType"></param>
        /// <param name="@params"></param>
        public UrlEncodedPostData(string mimeType, IEnumerable<PostDataParam>? @params) : base(mimeType: mimeType)
        {
            Params = (@params ?? Enumerable.Empty<PostDataParam>()).ToList();
        }

        /// <summary>
        /// List of posted parameters (in case of URL encoded parameters). 
        /// </summary>
        [JsonPropertyName("params")]
        public IList<PostDataParam> Params { get; set; }
    }
}
