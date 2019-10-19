using System.Text.Json.Serialization;

namespace HttpArchive
{
    /// <summary>
    /// Represents an object that has a mandatory name
    /// </summary>
    public interface IRequiresName
    {
        /// <summary>
        /// The mandatory name of the object.
        /// </summary>
        string Name { get; set; }
    }
}
