using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object contains detailed info about the performed request.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#request
    /// </remarks>
    public class Request : IAllowsComment
    {
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
        /// Request HTTP Version. 
        /// </summary>
        [JsonPropertyName("httpVersion")]
        public string HttpVersion { get; set; }

        /// <summary>
        /// List of cookie objects.
        /// </summary>
        [JsonPropertyName("cookies")]
        public IList<Cookie> Cookies { get; set; }

        /// <summary>
        /// List of header objects. 
        /// </summary>
        [JsonPropertyName("headers")]
        public IList<Header> Headers { get; set; }

        /// <summary>
        /// List of query parameter objects. 
        /// </summary>
        [JsonPropertyName("queryString")]
        public IList<QueryStringPair> QueryString { get; set; }

        /// <summary>
        /// Posted data info.  
        /// </summary>
        [JsonPropertyName("postData")]
        public PostData PostData { get; set; }

        /// <summary>
        /// Total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonPropertyName("headersSize")]
        public int HeadersSize { get; set; }

        /// <summary>
        /// Size of the request body (POST data payload) in bytes.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonPropertyName("bodySize")]
        public int BodySize { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
