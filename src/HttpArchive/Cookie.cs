using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Automatonic.HttpArchive
{
    /// <summary>
    /// This object is an entry in the list of all cookies (used in request and response objects).
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// </remarks>
    [JsonObject]
    public class Cookie : NamedValue
    {
        /// <summary>
        /// The path pertaining to the cookie.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The host of the cookie. 
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Cookie expiration time. (ISO 8601 - YYYY-MM-DDThh:mm:ss.sTZD, e.g. 2009-07-24T19:20:30.123+02:00). 
        /// </summary>
        [JsonProperty(PropertyName = "expires")]
        public string Expires { get; set; }

        /// <summary>
        /// Set to true if the cookie is HTTP only, false otherwise.  
        /// </summary>
        [JsonProperty(PropertyName = "httpOnly")]
        public bool HttpOnly { get; set; }

        /// <summary>
        /// (new in 1.2) - True if the cookie was transmitted over ssl, false otherwise.   
        /// </summary>
        [JsonProperty(PropertyName = "secure")]
        public bool Secure { get; set; }
    }
}
