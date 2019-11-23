using System.Text.Json;
using Xunit;
using FluentAssertions;
using System.IO;
using System.Threading.Tasks;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Document"/> object
    /// </summary>
    public class DocumentShould
    {
        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Document>(
                JsonSerializer.Serialize(new Document()));
            deserialized.Log.Should().NotBeNull();
            deserialized.Log.Comment.Should().BeNull();
            deserialized.Log.Creator.Should().NotBeNull();
            deserialized.Log.Creator.Name.Should().Be("");
            deserialized.Log.Creator.Version.Should().Be("");
            deserialized.Log.Browser.Should().BeNull();
            deserialized.Log.Pages.Should().BeNull();
            deserialized.Log.Entries.Should().NotBeNull();
            deserialized.Log.Entries.Should().BeEmpty();
        }

        [Fact]
        public async Task LoadSampleHarAsync()
        {
            var deserialized = await JsonSerializer.DeserializeAsync<Document>(utf8Json: File.OpenRead("sample.har"));
            deserialized.Log.Should().NotBeNull();
            // deserialized.Log.Comment.Should().BeNull();
            // deserialized.Log.Creator.Should().NotBeNull();
            // deserialized.Log.Creator.Name.Should().Be("");
            // deserialized.Log.Creator.Version.Should().Be("");
            // deserialized.Log.Browser.Should().BeNull();
            // deserialized.Log.Pages.Should().BeNull();
            // deserialized.Log.Entries.Should().NotBeNull();
            // deserialized.Log.Entries.Should().BeEmpty();
        }
    }
}
