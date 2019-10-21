using System;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object represents an entry in the list of exported pages.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#creator
    /// </remarks>
    public class Page : IAllowsComment
    {
        public Page() : this(startedDateTime: DateTimeOffset.MinValue, id:"", title: "", pageTimings: new PageTimings())
        {
        }

        public Page(DateTimeOffset startedDateTime, string id, string title, PageTimings pageTimings)
        {
            StartedDateTime = startedDateTime;
            Id = id;
            Title = title;
            PageTimings = pageTimings;
        }

        /// <summary>
        /// Date and time stamp for the beginning of the page load (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD, e.g. 2009-07-24T19:20:30.45+01:00). 
        /// </summary>
        [JsonPropertyName("startedDateTime")]
        public DateTimeOffset StartedDateTime { get; set; }

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
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
