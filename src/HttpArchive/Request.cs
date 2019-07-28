using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object contains detailed info about the performed request.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#request
    /// </remarks>
    [JsonObject]
    public class Request
    {
        /// <summary>
        /// Request method (GET, POST, ...). 
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Absolute URL of the request (fragments are not included).
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Request HTTP Version. 
        /// </summary>
        [JsonProperty(PropertyName = "httpVersion")]
        public string HttpVersion { get; set; }

        /// <summary>
        /// List of cookie objects.
        /// </summary>
        [JsonProperty(PropertyName = "cookies")]
        public IList<Cookie> Cookies { get; set; }

        /// <summary>
        /// List of header objects. 
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<NamedValue> Headers { get; set; }

        /// <summary>
        /// List of query parameter objects. 
        /// </summary>
        [JsonProperty(PropertyName = "queryString")]
        public IList<NamedValue> QueryString { get; set; }

        /// <summary>
        /// Posted data info.  
        /// </summary>
        [JsonProperty(PropertyName = "postData")]
        public PostData PostData { get; set; }

        /// <summary>
        /// Total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonProperty(PropertyName = "headersSize")]
        public int HeadersSize { get; set; }

        /// <summary>
        /// Size of the request body (POST data payload) in bytes.
        /// </summary>
        /// <remarks>
        /// Set to -1 if the info is not available. 
        /// </remarks>
        [JsonProperty(PropertyName = "bodySize")]
        public int BodySize { get; set; }

        
    }
}
