using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object describes timings for various events (states) fired during the page load. 
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#pageTimings
    /// All times are specified in milliseconds. If a time info is not available appropriate field is set to -1.
    /// Depending on the browser, onContentLoad property represents DOMContentLoad event or document.readyState == interactive.
    /// </remarks>
    [JsonObject]
    public class PageTimings : ArchiveObject
    {
        /// <summary>
        /// Content of the page loaded. Number of milliseconds since page load started (page.startedDateTime). Use -1 if the timing does not apply to the current request. 
        /// </summary>
        [JsonProperty(PropertyName = "onContentLoad")]
        public int OnContentLoad { get; set; }

        /// <summary>
        /// Page is loaded (onLoad event fired). Number of milliseconds since page load started (page.startedDateTime). Use -1 if the timing does not apply to the current request. 
        /// </summary>
        [JsonProperty(PropertyName = "onLoad")]
        public int OnLoad { get; set; }

    }
}
