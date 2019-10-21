using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Details of the creator software
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#creator
    /// </remarks>
    public class Creator : ISoftware
    {
        public Creator() : this("", "")
        {

        }
        public Creator(string name, string version)
        {
            Name = name;
            Version = version;
        }

        /// <summary>
        /// Name of the application used to export the log. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the application used to export the log. 
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
