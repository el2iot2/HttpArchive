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
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Header>(
                JsonSerializer.Serialize(new Header()));
            deserialized.Comment.Should().BeNull();
            deserialized.Name.Should().Be("");
            deserialized.Value.Should().Be("");
        }
    }
}
