using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This object is an entry in the list of all cookies (used in request and response objects).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// </remarks>
    public class Cookie : INamedValue
    {
        /// <summary>
        /// The path pertaining to the cookie.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// The host of the cookie. 
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Cookie expiration time. (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD, e.g. 2009-07-24T19:20:30.123+02:00). 
        /// </summary>
        [JsonPropertyName("expires")]
        public string Expires { get; set; }

        /// <summary>
        /// Set to true if the cookie is HTTP only, false otherwise.  
        /// </summary>
        [JsonPropertyName("httpOnly")]
        public bool HttpOnly { get; set; }

        /// <summary>
        /// (new in 1.2) - True if the cookie was transmitted over ssl, false otherwise.   
        /// </summary>
        [JsonPropertyName("secure")]
        public bool Secure { get; set; }
        
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
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
