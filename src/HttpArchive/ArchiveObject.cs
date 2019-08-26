using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is the base type for objects that support comments
    /// </summary>
    public class ArchiveObject
    {
        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
