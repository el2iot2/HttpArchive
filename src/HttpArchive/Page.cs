using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents an entry in the list of exported pages.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#pages
    /// </remarks>
    public class Page : IComment
    {
        /// <summary>
        /// Date and time stamp for the beginning of the page load (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD, e.g. 2009-07-24T19:20:30.45+01:00). 
        /// </summary>
        [JsonPropertyName("startedDateTime")]
        public string StartedDateTime { get; set; }

        /// <summary>
        /// Unique identifier of a page within the log. Entries use it to refer the parent page.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Page title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Detailed timing info about page load. 
        /// </summary>
        [JsonPropertyName("pageTimings")]
        public PageTimings PageTimings { get; set; }

        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
