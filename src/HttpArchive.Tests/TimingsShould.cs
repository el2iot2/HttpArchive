using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Timings"/> object
    /// </summary>
    public class TimingsShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""blocked"": 0,
  ""dns"": -1,
  ""connect"": 15,
  ""send"": 20,
  ""wait"": 38,
  ""receive"": 12,
  ""ssl"": -1,
  ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Timings>(json);
            deserialized.Should().NotBeNull();
            deserialized.Blocked.Should().Be(0);
            deserialized.Dns.Should().Be(-1);
            deserialized.Connect.Should().Be(15);
            deserialized.Send.Should().Be(20);
            deserialized.Wait.Should().Be(38);
            deserialized.Receive.Should().Be(12);
            deserialized.Ssl.Should().Be(-1);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Timings>(
                JsonSerializer.Serialize(new Timings()));
            deserialized.Blocked.Should().Be(-1);
            deserialized.Dns.Should().Be(-1);
            deserialized.Connect.Should().Be(-1);
            deserialized.Send.Should().Be(0);
            deserialized.Wait.Should().Be(0);
            deserialized.Receive.Should().Be(0);
            deserialized.Ssl.Should().Be(-1);
            deserialized.Comment.Should().BeNull();
        }
    }
}
