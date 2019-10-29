using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object contains detailed info about the response.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#response
    /// </remarks>
    public class Response : Message
    {
        /// <summary>
        /// Create new default/empty response
        /// </summary>
        /// <returns></returns>
        public Response() : this(0, "", "", null, null, new Content(), "", -1, -1)
        {
        }

        /// <summary>
        /// Create new Response with required properties
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statusText"></param>
        /// <param name="httpVersion"></param>
        /// <param name="cookies"></param>
        /// <param name="headers"></param>
        /// <param name="content"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="headersSize"></param>
        /// <param name="bodySize"></param>
        public Response(int status, string statusText, string httpVersion, IEnumerable<Cookie>? cookies, IEnumerable<Header>? headers, Content content, string redirectUrl, int headersSize, int bodySize)
        : base(httpVersion: httpVersion, cookies: cookies, headers: headers, headersSize: headersSize, bodySize: bodySize)
        {
            Status = status;
            StatusText = statusText;
            HttpVersion = httpVersion;
            Content = content;
            RedirectUrl = redirectUrl;
        }

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
        /// Details about the response body.  
        /// </summary>
        [JsonPropertyName("content")]
        public Content Content { get; set; }

        /// <summary>
        /// Redirection target URL from the Location response header.
        /// </summary>
        [JsonPropertyName("redirectURL")]
        public string RedirectUrl { get; set; }
    }
}
