using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Represents a shared structure for named values.
    /// </summary>
    /// <remarks>
    /// Used for:
    /// http://www.softwareishard.com/blog/har-12-spec/#cookies
    /// http://www.softwareishard.com/blog/har-12-spec/#headers
    /// http://www.softwareishard.com/blog/har-12-spec/#queryString
    /// http://www.softwareishard.com/blog/har-12-spec/#params
    /// </remarks>
    public interface IRequiresNameValue : IRequiresName
    {
        /// <summary>
        /// The value.
        /// </summary>
        string Value { get; set; }
    }
}
