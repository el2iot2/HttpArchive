using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the creator object
    /// </summary>
    public class CreatorShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""name"": ""Firebug"",
  ""version"": ""1.6"",
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Creator>(json);
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("Firebug");
            deserialized.Version.Should().Be("1.6");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Creator>(
                JsonSerializer.Serialize(new Creator()));
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("");
            deserialized.Version.Should().Be("");
        }
    }
}
