using System;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents an entry in the array with all exported HTTP requests
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#entries
    /// </remarks>
    public class Entry : IAllowsComment
    {
        /// <summary>
        /// Constructs a default/empty entry
        /// </summary>
        /// <returns></returns>
        public Entry() : this(
            DateTimeOffset.MinValue,
            0,
            new Request(),
            new Response(),
            new Cache(),
            new Timings()
        )
        {
        }

        /// <summary>
        /// Constructs the minimally required entry
        /// </summary>
        /// <param name="startedDateTime"></param>
        /// <param name="time"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="cache"></param>
        /// <param name="timings"></param>
        public Entry(DateTimeOffset startedDateTime, int time, Request request, Response response, Cache cache, Timings timings)
        {
            StartedDateTime = startedDateTime;
            Time = time;
            Request = request;
            Response = response;
            Cache = cache;
            Timings = timings;
        }

        /// <summary>
        /// Unique reference to the parent page. 
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
        public DateTimeOffset StartedDateTime { get; set; }

        /// <summary>
        /// Total elapsed time of the request in milliseconds.
        /// </summary>
        /// <remarks>
        /// This is the sum of all timings available in the timings object (i.e. not including -1 values)
        /// </remarks>
        [JsonPropertyName("time")]
        public int Time { get; set; }

        /// <summary>
        /// Detailed info about the request. 
        /// </summary>
        [JsonPropertyName("request")]
        public Request Request { get; set; }

        /// <summary>
        /// Detailed info about the response. 
        /// </summary>
        [JsonPropertyName("response")]
        public Response Response { get; set; }

        /// <summary>
        /// Info about cache usage. 
        /// </summary>
        [JsonPropertyName("cache")]
        public Cache Cache { get; set; }

        /// <summary>
        /// Detailed timing info about request/response round trip.
        /// </summary>
        [JsonPropertyName("timings")]
        public Timings Timings { get; set; }

        /// <summary>
        /// IP address of the server that was connected (result of DNS resolution). 
        /// </summary>
        [JsonPropertyName("serverIPAddress")]
        public string? ServerIPAddress { get; set; }

        /// <summary>
        /// Unique ID of the parent TCP/IP connection
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
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
