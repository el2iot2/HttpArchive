using System.Text.Json;
using Xunit;
using FluentAssertions;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the header object
    /// </summary>
    public class RequestShould
    {

        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
  ""method"": ""GET"",
  ""url"": ""http://www.example.com/path/?param=value"",
  ""httpVersion"": ""HTTP/1.1"",
  ""cookies"": [],
  ""headers"": [],
  ""queryString"" : [],
  ""postData"" : {},
  ""headersSize"" : 150,
  ""bodySize"" : 0,
  ""comment"" : """"
}";
            var deserialized = JsonSerializer.Deserialize<Request>(json);
            deserialized.Should().NotBeNull();
            deserialized.Method.Should().Be("GET");
            deserialized.Url.Should().Be("http://www.example.com/path/?param=value");
            deserialized.HttpVersion.Should().Be("HTTP/1.1");
            deserialized.Cookies.Should().NotBeNull();
            deserialized.Cookies.Should().BeEmpty();
            deserialized.Headers.Should().NotBeNull();
            deserialized.Headers.Should().BeEmpty();
            deserialized.QueryString.Should().NotBeNull();
            deserialized.QueryString.Should().BeEmpty();
            deserialized.PostData.Should().NotBeNull();
            deserialized.HeadersSize.Should().Be(150);
            deserialized.HeadersCompression.Should().BeNull();
            deserialized.BodySize.Should().Be(0);
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Request>(
                JsonSerializer.Serialize(new Request()));
            deserialized.Should().NotBeNull();
            deserialized.Method.Should().Be("");
            deserialized.Url.Should().Be("");
            deserialized.HttpVersion.Should().Be("");
            deserialized.Cookies.Should().NotBeNull();
            deserialized.Cookies.Should().BeEmpty();
            deserialized.Headers.Should().NotBeNull();
            deserialized.Headers.Should().BeEmpty();
            deserialized.QueryString.Should().NotBeNull();
            deserialized.QueryString.Should().BeEmpty();
            deserialized.PostData.Should().BeNull();
            deserialized.HeadersSize.Should().Be(-1);
            deserialized.HeadersCompression.Should().BeNull();
            deserialized.BodySize.Should().Be(-1);
            deserialized.Comment.Should().BeNull();
        }
    }
}
