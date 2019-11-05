using System;
using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Both beforeRequest and afterRequest object share the following structure.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#beforerequest--afterrequest
    /// </remarks>
    public class CacheEntryState : IAllowsComment
    {

        /// <summary>
        /// Constructs an empty/default CacheEntryState
        /// </summary>
        /// <returns></returns>
        public CacheEntryState() : this(DateTimeOffset.MinValue, "", 0)
        {

        }

        /// <summary>
        /// Constructs a CacheEntryState with all required properties
        /// </summary>
        /// <param name="lastAccess"></param>
        /// <param name="etag"></param>
        /// <param name="hitCount"></param>
        public CacheEntryState(DateTimeOffset lastAccess, string etag, int hitCount)
        {
            LastAccess = lastAccess;
            Etag = etag;
            HitCount = hitCount;
        }

        /// <summary>
        /// Expiration time of the cache entry. 
        /// </summary>
        [JsonPropertyName("expires")]
        DateTimeOffset? Expires { get; set; }

        /// <summary>
        /// The last time the cache entry was opened. 
        /// </summary>
        [JsonPropertyName("lastAccess")]
        DateTimeOffset LastAccess { get; set; }

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
        /// A comment provided by the user or the application.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
