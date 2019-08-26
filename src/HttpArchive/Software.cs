using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Creator and browser objects share the same structure.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#creator
    /// </remarks>
    public class Software : ArchiveObject
    {
        /// <summary>
        /// Name of the application/browser used to export the log. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the application/browser used to export the log. 
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
