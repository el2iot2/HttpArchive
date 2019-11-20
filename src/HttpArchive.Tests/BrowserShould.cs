using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Browser"/> object
    /// </summary>
    public class BrowserShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""name"": ""Firefox"",
  ""version"": ""3.6"",
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Creator>(json);
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("Firefox");
            deserialized.Version.Should().Be("3.6");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Browser>(
                JsonSerializer.Serialize(new Browser()));
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("");
            deserialized.Version.Should().Be("");
        }
    }
}
