using System;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents an entry in the array with all exported HTTP requests
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.2.md#entries
    /// Depending on the browser, onContentLoad property represents 
    /// </remarks>
    public class Entry : IComment
    {
        /// <summary>
        /// Reference to the parent page. 
        /// </summary>
        /// <remarks>
        /// Leave out this field if the application does not support grouping by pages. 
        /// </remarks>
        [JsonPropertyName("pageref")]
        public string? PageRef { get; set; }

        /// <summary>
        /// Date and time stamp of the request start (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD). 
        /// </summary>
        [JsonPropertyName("startedDateTime")]
        public DateTimeOffset StartedDateTime { get; set; } = DateTimeOffset.MinValue;

        /// <summary>
        /// Total elapsed time of the request in milliseconds.
        /// </summary>
        /// <remarks>
        /// This is the sum of all timings available in the timings object (i.e. not including -1 values)
        /// </remarks>
        [JsonPropertyName("time")]
        public ulong Time { get; set; } = 0;


        /// <summary>
        /// Detailed info about the request. 
        /// </summary>
        [JsonPropertyName("request")]
        public Request Request { get; set; } = new Request();

        /// <summary>
        /// Detailed info about the response. 
        /// </summary>
        [JsonPropertyName("response")]
        public Response Response { get; set; } = new Response();

        /// <summary>
        /// Info about cache usage. 
        /// </summary>
        [JsonPropertyName("cache")]
        public Cache Cache { get; set; } = new Cache();

        /// <summary>
        /// Detailed timing info about request/response round trip.
        /// </summary>
        [JsonPropertyName("timings")]
        public Timings Timings { get; set; } = new Timings();

        /// <summary>
        /// (new in 1.2) - IP address of the server that was connected (result of DNS resolution). 
        /// </summary>
        [JsonPropertyName("serverIPAddress")]
        public string? ServerIPAddress { get; set; }

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
        [JsonPropertyName("connection")]
        public string? Connection { get; set; }

        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
