using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Cache"/> object
    /// </summary>
    public class CacheShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""beforeRequest"": {},
  ""afterRequest"": {},
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Cache>(json);
            deserialized.Should().NotBeNull();
            deserialized.BeforeRequest.Should().NotBeNull();
            deserialized.AfterRequest.Should().NotBeNull();
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Cache>(
                JsonSerializer.Serialize(new Cache()));
            deserialized.Should().NotBeNull();
            deserialized.BeforeRequest.Should().BeNull();
            deserialized.AfterRequest.Should().BeNull();
            deserialized.Comment.Should().BeNull();
        }
    }
}
