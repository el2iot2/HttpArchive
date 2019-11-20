using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Content"/> object
    /// </summary>
    public class ContentShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""size"": 33,
  ""compression"": 0,
  ""mimeType"": ""text/html; charset=utf-8"",
  ""text"": ""\n"",
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Content>(json);
            deserialized.Should().NotBeNull();
            deserialized.Size.Should().Be(33);
            deserialized.Compression.Should().Be(0);
            deserialized.MimeType.Should().Be("text/html; charset=utf-8");
            deserialized.Text.Should().Be("\n");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Content>(
                JsonSerializer.Serialize(new Content()));
            deserialized.Should().NotBeNull();
            deserialized.Size.Should().Be(0);
            deserialized.Compression.Should().BeNull();
            deserialized.MimeType.Should().Be("");
            deserialized.Text.Should().BeNull();
            deserialized.Comment.Should().BeNull();
        }
    }
}
