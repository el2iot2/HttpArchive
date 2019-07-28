using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object represents an entry in the array with all exported HTTP requests
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#entries
    /// Depending on the browser, onContentLoad property represents 
    /// DOMContentLoad event or document.readyState == interactive.
    /// </remarks>
    [JsonObject]
    public class Entry : ArchiveObject
    {
        /// <summary>
        /// Reference to the parent page. 
        /// </summary>
        /// <remarks>
        /// Leave out this field if the application does not support grouping by pages. 
        /// </remarks>
        [JsonProperty(PropertyName = "pageref")]
        public string PageRef { get; set; }

        /// <summary>
        /// Date and time stamp of the request start (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD). 
        /// </summary>
        [JsonProperty(PropertyName = "startedDateTime")]
        public string StartedDateTime { get; set; }

        /// <summary>
        /// Detailed info about the request. 
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public Request Request { get; set; }

        /// <summary>
        /// Detailed info about the response. 
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public Response Response { get; set; }

        /// <summary>
        /// Info about cache usage. 
        /// </summary>
        [JsonProperty(PropertyName = "cache")]
        public Cache Cache { get; set; }

        /// <summary>
        /// Detailed timing info about request/response round trip.
        /// </summary>
        [JsonProperty(PropertyName = "timings")]
        public Timings Timings { get; set; }

        /// <summary>
        /// (new in 1.2) - IP address of the server that was connected (result of DNS resolution). 
        /// </summary>
        [JsonProperty(PropertyName = "serverIPAddress")]
        public string ServerIPAddress { get; set; }

        /// <summary>
        /// (new in 1.2) - Unique ID of the parent TCP/IP connection
        /// </summary>
        /// <remarks>
        /// Can be the client or server port number. 
        /// Note that a port number doesn't have to be unique identifier 
        /// in cases where the port is shared for more connections. 
        /// If the port isn't available for the application, 
        /// any other unique connection ID can be used instead 
        /// (e.g. connection index). Leave out this field if the application doesn't support this info.
        /// </remarks>
        [JsonProperty(PropertyName = "connection")]
        public string Connection { get; set; }
    }
}
