using System.Text.Json;
using Xunit;
using FluentAssertions;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="BeforeRequest"/> object
    /// </summary>
    public class BeforeRequestShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""expires"": ""2009-04-16T15:50:36"",
  ""lastAccess"": ""2009-02-16T15:50:34"",
  ""eTag"": """",
  ""hitCount"": 0,
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<BeforeRequest>(json);
            deserialized.Should().NotBeNull();
            deserialized.Expires.Should().Be(DateTimeOffset.Parse("2009-04-16T15:50:36"));
            deserialized.LastAccess.Should().Be(DateTimeOffset.Parse("2009-02-16T15:50:34"));
            deserialized.Etag.Should().Be("");
            deserialized.HitCount.Should().Be(0);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<BeforeRequest>(
                JsonSerializer.Serialize(new BeforeRequest()));
            deserialized.Expires.Should().BeNull();
            deserialized.LastAccess.Should().Be(DateTimeOffset.MinValue);
            deserialized.Etag.Should().Be("");
            deserialized.HitCount.Should().Be(0);
            deserialized.Comment.Should().BeNull();
        }
    }
}
