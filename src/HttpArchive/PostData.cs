using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object describes posted data, if any (embedded in request object).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#postData
    /// </remarks>
    [JsonObject]
    public class PostData : ArchiveObject
    {
        /// <summary>
        /// Mime type of posted data. 
        /// </summary>
        [JsonProperty(PropertyName = "mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// List of posted parameters (in case of URL encoded parameters). 
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public IList<PostDataParam> Params { get; set; }

        /// <summary>
        /// Plain text posted data.  
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
