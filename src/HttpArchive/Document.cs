using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents the document wrapper needed to load the log file.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Version number of the format. If empty, string "1.1" is assumed by default.
        /// </summary>
        [JsonPropertyName("log")]
        public Log Log { get; set; }
    }
}
