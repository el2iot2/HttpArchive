using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the header object
    /// </summary>
    public class LogShould
    {

        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""version"" : ""1.2"",
  ""creator"" : {},
  ""browser"" : {},
  ""pages"": [],
  ""entries"": [],
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Log>(json);
            deserialized.Should().NotBeNull();
            deserialized.Version.Should().Be("1.2");
            deserialized.Creator.Should().NotBeNull();
            deserialized.Browser.Should().NotBeNull();
            deserialized.Pages.Should().NotBeNull();
            deserialized.Pages.Should().HaveCount(0);
            deserialized.Entries.Should().NotBeNull();
            deserialized.Entries.Should().HaveCount(0);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Log>(
                JsonSerializer.Serialize(new Log()));
            deserialized.Comment.Should().BeNull();
            deserialized.Creator.Should().NotBeNull();
            deserialized.Browser.Should().BeNull();
            deserialized.Pages.Should().BeNull();
            deserialized.Entries.Should().NotBeNull();
            deserialized.Entries.Should().BeEmpty();
        }
    }
}
