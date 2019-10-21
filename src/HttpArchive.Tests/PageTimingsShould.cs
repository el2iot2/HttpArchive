using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the header object
    /// </summary>
    public class PageTimingsShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""onContentLoad"": 1720,
  ""onLoad"": 2500,
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<PageTimings>(json);
            deserialized.Should().NotBeNull();
            deserialized.OnContentLoad.Should().Be(1720);
            deserialized.OnLoad.Should().Be(2500);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<PageTimings>(
                JsonSerializer.Serialize(new PageTimings()));
            deserialized.Should().NotBeNull();
            deserialized.OnContentLoad.Should().Be(-1);
            deserialized.OnLoad.Should().Be(-1);
            deserialized.Comment.Should().BeNull();
        }
    }
}
