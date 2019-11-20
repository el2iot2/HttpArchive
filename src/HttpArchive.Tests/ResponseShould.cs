using System.Text.Json;
using Xunit;
using FluentAssertions;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="Response"/> object
    /// </summary>
    public class ResponseShould
    {

        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""status"": 200,
  ""statusText"": ""OK"",
  ""httpVersion"": ""HTTP/1.1"",
  ""cookies"": [],
  ""headers"": [],
  ""content"": {},
  ""redirectURL"": """",
  ""headersSize"" : 160,
  ""bodySize"" : 850,
  ""comment"" : """"
}";
            var deserialized = JsonSerializer.Deserialize<Response>(json);
            deserialized.Should().NotBeNull();
            deserialized.Status.Should().Be(200);
            deserialized.StatusText.Should().Be("OK");
            deserialized.HttpVersion.Should().Be("HTTP/1.1");
            deserialized.Cookies.Should().NotBeNull();
            deserialized.Cookies.Should().BeEmpty();
            deserialized.Headers.Should().NotBeNull();
            deserialized.Headers.Should().BeEmpty();
            deserialized.Content.Should().NotBeNull();
            deserialized.HeadersSize.Should().Be(160);
            deserialized.HeadersCompression.Should().BeNull();
            deserialized.BodySize.Should().Be(850);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Response>(
                JsonSerializer.Serialize(new Response()));
            deserialized.Should().NotBeNull();
            deserialized.Status.Should().Be(0);
            deserialized.StatusText.Should().Be("");
            deserialized.HttpVersion.Should().Be("");
            deserialized.Cookies.Should().NotBeNull();
            deserialized.Cookies.Should().BeEmpty();
            deserialized.Headers.Should().NotBeNull();
            deserialized.Headers.Should().BeEmpty();
            deserialized.Content.Should().NotBeNull();
            deserialized.HeadersSize.Should().Be(-1);
            deserialized.HeadersCompression.Should().BeNull();
            deserialized.BodySize.Should().Be(-1);
            deserialized.Comment.Should().BeNull();
        }
    }
}
