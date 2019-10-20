using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the header object
    /// </summary>
    public class HeaderShould
    {
        [Fact]
        public void DeserializeMinimal()
        {
            var json = 
@"{
    ""name"": ""name"",
    ""value"": ""value""
}";
            var deserialized = JsonSerializer.Deserialize<Header>(json);
            deserialized.Comment.Should().BeNull();
            deserialized.Name.Should().Be("name");
            deserialized.Value.Should().Be("value");
        }

        [Fact]
        public void RoundtripMinimal()
        {
            var value = new Header("name", "value");
            var deserialized = JsonSerializer.Deserialize<Header>(
                JsonSerializer.Serialize(value));
            deserialized.Comment.Should().BeNull();
            deserialized.Name.Should().Be("name");
            deserialized.Value.Should().Be("value");
        }
    }
}
