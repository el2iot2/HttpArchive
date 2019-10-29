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
    public abstract class Message : IAllowsComment
    {
        internal Message(string httpVersion, IEnumerable<Cookie>? cookies, IEnumerable<Header>? headers, int headersSize, int bodySize)
        {
            HttpVersion = httpVersion;
            Cookies = (cookies ?? Enumerable.Empty<Cookie>()).ToList();
            Headers = (headers ?? Enumerable.Empty<Header>()).ToList();
            HeadersSize = headersSize;
            BodySize = bodySize;
        }

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
        /// Total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonPropertyName("headersSize")]
        public int HeadersSize { get; set; }

        /// <summary>
        /// (new in 1.3) Number of bytes saved (for HTTP/2)
        /// </summary>
        /// <value></value>
        [JsonPropertyName("headersCompression")]
        public int? HeadersCompression { get; set;}

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
