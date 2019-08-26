using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Represents an object that support a comment
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// (new in 1.2) - A comment provided by the user or the application.
        /// </summary>
        string Comment { get; set; }
    }
}
