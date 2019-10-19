using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Represents an object that supports a comment
    /// </summary>
    public interface IAllowsComment
    {
        /// <summary>
        /// A comment provided by the user or the application.
        /// </summary>
        string? Comment { get; set; }
    }
}
