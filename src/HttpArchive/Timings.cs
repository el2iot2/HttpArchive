using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes various phases within request-response round trip. All times are specified in milliseconds.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#timings
    /// </remarks>
    public class Timings : IAllowsComment
    {
        /// <summary>
        /// Time spent in a queue waiting for a network connection.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonPropertyName("blocked")]
        public int Blocked { get; set; }

        /// <summary>
        /// DNS resolution time. The time required to resolve a host name.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonPropertyName("dns")]
        public int Dns { get; set; }

        /// <summary>
        /// Time required to create TCP connection.
        /// </summary>
        /// <remarks>
        /// Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonPropertyName("connect")]
        public int Connect { get; set; }

        /// <summary>
        /// Time required to send HTTP request to the server.
        /// </summary>
        [JsonPropertyName("send")]
        public int Send { get; set; }

        /// <summary>
        /// Time required to read entire response from the server (or cache). 
        /// </summary>
        [JsonPropertyName("receive")]
        public int Receive { get; set; }

        /// <summary>
        /// Time required for SSL/TLS negotiation.
        /// </summary>
        /// <remarks>
        /// If this field is defined then the time is also included in the connect field (to ensure backward compatibility with HAR 1.1). 
        /// Use -1 if the timing does not apply to the current request.  
        /// </remarks>
        [JsonPropertyName("ssl")]
        public int Ssl { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
