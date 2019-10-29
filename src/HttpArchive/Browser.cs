using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Details of the browser software
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#browser
    /// </remarks>
    public class Browser : ISoftware
    {
        /// <summary>
        /// Constructs a default/minimal browser software
        /// </summary>
        /// <returns></returns>
        public Browser() : this("", "")
        {
        }

        /// <summary>
        /// Construct the browser with all required info
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        public Browser(string name, string version)
        {
            Name = name;
            Version = version;
        }

        /// <summary>
        /// Name of the browser used to export the log. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the browser used to export the log. 
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
