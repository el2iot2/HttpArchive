using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object contains detailed info about the response.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#response
    /// </remarks>
    public class Response : ArchiveObject
    {
        /// <summary>
        /// Response status. 
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// Response status description.
        /// </summary>
        [JsonPropertyName("statusText")]
        public string StatusText { get; set; }

        /// <summary>
        /// Response HTTP Version. 
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
        public IList<NamedValue> Headers { get; set; }

        /// <summary>
        /// Details about the response body.  
        /// </summary>
        [JsonPropertyName("content")]
        public Content Content { get; set; }

        /// <summary>
        /// Redirection target URL from the Location response header.
        /// </summary>
        [JsonPropertyName("redirectURL")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// The size of received response-headers is computed only from headers that are really received from the server. 
        /// Additional headers appended by the browser are not included in this number, but they appear in the list of header objects.
        /// The total response size received can be computed as follows (if both values are available):
        /// var totalSize = entry.response.headersSize + entry.response.bodySize;
        /// </remarks>
        [JsonPropertyName("headersSize")]
        public int HeadersSize { get; set; }

        /// <summary>
        /// Size of the received response body in bytes.
        /// </summary>
        /// <remarks>
        /// Set to zero in case of responses coming from the cache (304). 
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonPropertyName("bodySize")]
        public int BodySize { get; set; }
    }
}
