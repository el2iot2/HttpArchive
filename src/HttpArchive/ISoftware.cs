using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Creator and browser objects share the same structure.
    /// </summary>
    /// <remarks>
    /// https://github.com/ahmadnassri/har-spec/blob/master/versions/1.3.md#creator
    /// </remarks>
    public interface ISoftware : IRequiresName, IAllowsComment
    {
        /// <summary>
        /// Version of the software. 
        /// </summary>
        string Version { get; set; }
    }
}
