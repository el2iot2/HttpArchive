using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object is represents a shared structure for named values.
    /// </summary>
    /// <remarks>
    /// Used for:
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// http://www.softwareishard.com/blog/har-12-spec/#headers
    /// http://www.softwareishard.com/blog/har-12-spec/#queryString
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    [JsonObject]
    public class NamedValue : ArchiveObject
    {
        /// <summary>
        /// The name. 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
