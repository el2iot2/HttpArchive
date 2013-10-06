using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object is the base type for objects that support comments
    /// </summary>
    [JsonObject]
    public class ArchiveObject
    {
        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
    }
}
