using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// This objects contains info about a request coming from browser cache.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#cache
    /// </remarks>
    public class Cache
    {
        /// <summary>
        /// State of a cache entry before the request. 
        /// </summary>
        /// <remarks>
        /// Leave out this field if the information is not available.
        /// </remarks>
        [JsonPropertyName("BeforeRequest")]
        public CacheEntry BeforeRequest {get; set;}

        /// <summary>
        /// State of a cache entry after the request.
        /// </summary>
        /// <remarks>
        /// Leave out this field if the information is not available.
        /// </remarks>
        [JsonPropertyName("afterRequest")]
        public CacheEntry AfterRequest {get; set;}
    }
}
