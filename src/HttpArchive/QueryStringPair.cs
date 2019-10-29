using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is parameter/value pair in query string (used in request).
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#querystring
    /// </remarks>
    public class QueryStringPair : IRequiresNameValue
    {
        public QueryStringPair(): this ("","")
        {
            
        }

        public QueryStringPair(string name, string value)
        {   
            Name = name;
            Value = value;
        }
        /// <summary>
        /// The name. 
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
