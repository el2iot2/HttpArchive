using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object represents the document wrapper needed to load the log file.
    /// </summary>
    [JsonObject]
    public class Document
    {
        /// <summary>
        /// Version number of the format. If empty, string "1.1" is assumed by default.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public Log Log { get; set; }
    }
}
