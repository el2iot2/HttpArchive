using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents the root of exported data.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#log
    /// </remarks>
    public class Log : ArchiveObject
    {
        /// <summary>
        /// Version number of the format. If empty, string "1.1" is assumed by default.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// Name and version info of the log creator application.
        /// </summary>
        [JsonPropertyName("creator")]
        public Software Creator { get; set; }

        /// <summary>
        /// Name and version info of used browser.
        /// </summary>
        [JsonPropertyName("browser")]
        public Software Browser { get; set; }

        /// <summary>
        /// List of all exported (tracked) pages. Leave out this field if the application does not support grouping by pages.
        /// </summary>
        [JsonPropertyName("pages")]
        public IList<Page> Pages { get; set; }

        /// <summary>
        /// List of all exported (tracked) requests.
        /// </summary>
        [JsonPropertyName("entries")]
        public IList<Entry> Entries { get; set; }

    }
}
