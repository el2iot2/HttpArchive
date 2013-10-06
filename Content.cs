using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object describes details about response content (embedded in response object).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#content
    /// </remarks>
    [JsonObject]
    public class Content : ArchiveObject
    {
        /// <summary>
        /// Length of the returned content in bytes.
        /// </summary>
        /// <remarks>
        /// Should be equal to response.bodySize if there is no compression and bigger when the content has been compressed. 
        /// </remarks>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        /// <summary>
        /// Number of bytes saved. Leave out this field if the information is not available. 
        /// </summary>
        [JsonProperty(PropertyName = "compression")]
        public int Compression { get; set; }

        /// <summary>
        /// MIME type of the response text (value of the Content-Type response header). The charset attribute of the MIME type is included (if available)
        /// </summary>
        [JsonProperty(PropertyName = "mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Response body sent from the server or loaded from the browser cache.
        /// </summary>
        /// <remarks>
        /// This field is populated with textual content only. The text field is either HTTP decoded text or a encoded (e.g. "base64") representation of the response body. Leave out this field if the information is not available. 
        /// </remarks>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// (new in 1.2) - Encoding used for response text field e.g "base64".
        /// </summary>
        /// <remarks>
        /// Leave out this field if the text field is HTTP decoded (decompressed & unchunked), than trans-coded from its original character set into UTF-8. 
        /// </remarks>
        [JsonProperty(PropertyName = "encoding")]
        public string Encoding { get; set; }
    }
}
