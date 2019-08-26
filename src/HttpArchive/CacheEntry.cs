using System;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Both beforeRequest and afterRequest object share the following structure.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#cache
    /// </remarks>
    public class CacheEntry : IComment
    {
        /// <summary>
        /// Expiration time of the cache entry. 
        /// </summary>
        [JsonPropertyName("expires")]
        DateTime? Expires { get; set; }

        /// <summary>
        /// The last time the cache entry was opened. 
        /// </summary>
        [JsonPropertyName("lastAccess")]
        DateTime LastAccess { get; set; }

        /// <summary>
        /// Etag 
        /// </summary>
        [JsonPropertyName("eTag")]
        string Etag { get; set; }

        /// <summary>
        /// The number of times the cache entry has been opened.
        /// </summary>
        [JsonPropertyName("hitCount")]
        int HitCount { get; set; }

        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
