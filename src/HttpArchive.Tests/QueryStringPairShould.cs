using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="QueryStringPair"/> object
    /// </summary>
    public class QueryStringPairShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
    ""name"": ""param1"",
    ""value"": ""value1"",
    ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<QueryStringPair>(json);
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("param1");
            deserialized.Value.Should().Be("value1");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<QueryStringPair>(
                JsonSerializer.Serialize(new QueryStringPair()));
            deserialized.Name.Should().Be("");
            deserialized.Value.Should().Be("");
            deserialized.Comment.Should().BeNull();
        }
    }
}
