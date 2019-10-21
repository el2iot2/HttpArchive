using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents the root of exported data.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#log
    /// </remarks>
    public class Log : IAllowsComment
    {
        /// <summary>
        /// Internal default constructor used for serialization
        /// </summary>
        /// <returns></returns>
        public Log() : this (new Creator())
        {
        }

        public Log(Creator creator, params Entry[] entries) :
            this(version: "1.3", creator: creator, entries: entries)
        {
        }

        public Log(string version, Creator creator, params Entry[] entries)
        {
            Version = version;
            Creator = creator;
            Entries = entries.ToList();
        }

        /// <summary>
        /// Version number of the format.
        /// </summary>
        /// <remarks>
        /// If empty, string "1.1" is assumed by default.
        /// </remarks>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// Name and version info of the log creator application.
        /// </summary>
        [JsonPropertyName("creator")]
        public Creator Creator { get; set; }

        /// <summary>
        /// Name and version info of used browser.
        /// </summary>
        [JsonPropertyName("browser")]
        public Browser? Browser { get; set; }

        /// <summary>
        /// List of all exported (tracked) pages. Leave out this field if the application does not support grouping by pages.
        /// </summary>
        [JsonPropertyName("pages")]
        public IList<Page>? Pages { get; set; }

        /// <summary>
        /// List of all exported (tracked) requests.
        /// </summary>
        [JsonPropertyName("entries")]
        public IList<Entry> Entries { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
