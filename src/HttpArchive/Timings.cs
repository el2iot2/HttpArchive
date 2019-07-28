using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace HttpArchive
{
    /// <summary>
    /// This object describes various phases within request-response round trip. All times are specified in milliseconds.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#timings
    /// </remarks>
    [JsonObject]
    public class Timings : ArchiveObject
    {
        /// <summary>
        /// Time spent in a queue waiting for a network connection.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonProperty(PropertyName = "blocked")]
        public int Blocked { get; set; }

        /// <summary>
        /// DNS resolution time. The time required to resolve a host name.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonProperty(PropertyName = "dns")]
        public int Dns { get; set; }

        /// <summary>
        /// Time required to create TCP connection.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonProperty(PropertyName = "connect")]
        public int Connect { get; set; }

        /// <summary>
        /// Time required to send HTTP request to the server.
        /// </summary>
        [JsonProperty(PropertyName = "send")]
        public int Send { get; set; }

        /// <summary>
        /// Time required to read entire response from the server (or cache). 
        /// </summary>
        [JsonProperty(PropertyName = "receive")]
        public int Receive { get; set; }

        /// <summary>
        /// (new in 1.2) - Time required for SSL/TLS negotiation.
        /// </summary>
        /// <remarks>
        /// If this field is defined then the time is also included in the connect field (to ensure backward compatibility with HAR 1.1). 
        /// Use -1 if the timing does not apply to the current request.  
        /// </remarks>
        [JsonProperty(PropertyName = "ssl")]
        public int Ssl { get; set; }
    }
}
