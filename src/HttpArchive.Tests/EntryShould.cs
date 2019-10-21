using System.Text.Json;
using Xunit;
using FluentAssertions;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the creator object
    /// </summary>
    public class EntryShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
    ""pageref"": ""page_0"",
    ""startedDateTime"": ""2009-04-16T12:07:23.596Z"",
    ""time"": 50,
    ""request"": {},
    ""response"": {},
    ""cache"": {},
    ""timings"": {},
    ""serverIPAddress"": ""10.0.0.1"",
    ""connection"": ""52492"",
    ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Entry>(json);
            deserialized.Should().NotBeNull();
            deserialized.PageRef.Should().Be("page_0");
            deserialized.StartedDateTime.Should().Be(DateTimeOffset.Parse("2009-04-16T12:07:23.596Z"));
            deserialized.Time.Should().Be(50);
            deserialized.Request.Should().NotBeNull();
            deserialized.Response.Should().NotBeNull();
            deserialized.Cache.Should().NotBeNull();
            deserialized.Timings.Should().NotBeNull();
            deserialized.ServerIPAddress.Should().Be("10.0.0.1");
            deserialized.Connection.Should().Be("52492");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Entry>(
                JsonSerializer.Serialize(new Entry()));
            deserialized.Should().NotBeNull();
            deserialized.PageRef.Should().BeNull();
            deserialized.StartedDateTime.Should().Be(DateTimeOffset.MinValue);
            deserialized.Time.Should().Be(0);
            deserialized.Request.Should().NotBeNull();
            deserialized.Response.Should().NotBeNull();
            deserialized.Cache.Should().NotBeNull();
            deserialized.Timings.Should().NotBeNull();
            deserialized.ServerIPAddress.Should().BeNull();
            deserialized.Connection.Should().BeNull();
            deserialized.Comment.Should().BeNull();
        }
    }
}
