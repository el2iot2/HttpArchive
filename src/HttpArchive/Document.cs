using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents the JSON document/container.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md
    /// </remarks>
    public class Document
    {
        /// <summary>
        /// Internal default constructor used for serialization
        /// </summary>
        /// <returns></returns>
        public Document() : this (new Log())
        {
        }

        /// <summary>
        /// Constructs a new document with the required properties
        /// </summary>
        /// <param name="log"></param>
        public Document(Log log)
        {
            Log = log;
        }

        /// <summary>
        /// The root of exported data.
        /// </summary>
        [JsonPropertyName("log")]
        public Log Log { get; set; }
    }
}
