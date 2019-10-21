﻿using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is an entry in the list of all headers (used in request and response objects).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#headers
    /// </remarks>
    public class Header : IRequiresNameValue
    {
        public Header() : this ("", "")
        {
        }
        
        public Header(string name, string value)
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
