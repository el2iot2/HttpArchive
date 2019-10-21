using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object describes timings for various events (states) fired during the page load. 
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#creator
    /// All times are specified in milliseconds. If a time info is not available appropriate field is set to -1.
    /// Depending on the browser, onContentLoad property represents DOMContentLoad event or document.readyState == interactive.
    /// </remarks>
    public class PageTimings : IAllowsComment
    {
        /// <summary>
        /// Content of the page loaded. 
        /// </summary>
        /// <remarks>
        ///  Number of milliseconds since page load started (page.startedDateTime). Use -1 if the timing does not apply to the current request.
        /// </remarks>
        [JsonPropertyName("onContentLoad")]
        public int OnContentLoad { get; set; } = -1;

        /// <summary>
        /// Page is loaded (onLoad event fired).
        /// </summary>
        /// <remarks>
        ///  Number of milliseconds since page load started (page.startedDateTime). Use -1 if the timing does not apply to the current request. 
        /// </remarks>
        [JsonPropertyName("onLoad")]
        public int OnLoad { get; set; } = -1;

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
