using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object represents an entry in the list of exported pages.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#pages
    /// </remarks>
    [JsonObject]
    public class Page : ArchiveObject
    {
        /// <summary>
        /// Date and time stamp for the beginning of the page load (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD, e.g. 2009-07-24T19:20:30.45+01:00). 
        /// </summary>
        [JsonProperty(PropertyName = "startedDateTime")]
        public string StartedDateTime { get; set; }

        /// <summary>
        /// Unique identifier of a page within the log. Entries use it to refer the parent page.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Detailed timing info about page load. 
        /// </summary>
        [JsonProperty(PropertyName = "pageTimings")]
        public PageTimings PageTimings { get; set; }

    }
}
