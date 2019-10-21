using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object contains detailed info about the performed request.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#creator
    /// The total request size sent can be computed as follows (if both values are available):
    /// let totalSize = entry.request.headersSize + entry.request.bodySize
    /// </remarks>
    public class Request : Message
    {
        public Request() : this("", "", "", null, null, null, -1, -1)
        {
        }
        public Request(string method, string url, string httpVersion, IEnumerable<Cookie>? cookies, IEnumerable<Header>? headers, IEnumerable<QueryStringPair>? queryString, int headersSize, int bodySize) :
            base(httpVersion: httpVersion, cookies: cookies, headers: headers, headersSize: headersSize, bodySize: bodySize)
        {
            Method = method;
            Url = url;
            QueryString = (queryString ?? Enumerable.Empty<QueryStringPair>()).ToList();
            HeadersSize = headersSize;
            BodySize = bodySize;
        }

        /// <summary>
        /// Request method (GET, POST, ...). 
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Absolute URL of the request (fragments are not included).
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// List of query parameter objects. 
        /// </summary>
        [JsonPropertyName("queryString")]
        public IList<QueryStringPair> QueryString { get; set; }

        /// <summary>
        /// Posted data info.  
        /// </summary>
        [JsonPropertyName("postData")]
        public PostData? PostData { get; set; }
    }
}
