using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Details of the creator <see cref="ISoftware"/>
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#creator
    /// </remarks>
    public class Creator : ISoftware
    {
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
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
