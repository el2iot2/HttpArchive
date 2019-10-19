using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Details of the browser software
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.2.md#browser
    /// </remarks>
    public class Browser : ISoftware
    {
        /// <summary>
        /// Name of the browser used to export the log. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Version of the browser used to export the log. 
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; } = "";

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
