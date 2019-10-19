using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Creator and browser objects share the same structure.
    /// </summary>
    /// <remarks>
    /// http://www.softwareishard.com/blog/har-12-spec/#creator
    /// </remarks>
    public interface ISoftware : IRequiresName, IAllowsComment
    {
        /// <summary>
        /// Version of the software. 
        /// </summary>
        string Version { get; set; }
    }
}
