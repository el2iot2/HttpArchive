using System.Text.Json;
using Xunit;
using FluentAssertions;
using System;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the header object
    /// </summary>
    public class PageShould
    {

        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
    ""startedDateTime"": ""2009-04-16T12:07:25.123+01:00"",
    ""id"": ""page_0"",
    ""title"": ""Test Page"",
    ""pageTimings"": {},
    ""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<Page>(json);
            deserialized.Should().NotBeNull();
            deserialized.StartedDateTime.Should().Be(DateTimeOffset.Parse("2009-04-16T12:07:25.123+01:00"));
            deserialized.Id.Should().Be("page_0");
            deserialized.PageTimings.Should().NotBeNull();
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<Page>(
                JsonSerializer.Serialize(new Page()));
            deserialized.Comment.Should().BeNull();
            deserialized.StartedDateTime.Should().Be(DateTimeOffset.MinValue);
            deserialized.Id.Should().Be("");
            deserialized.PageTimings.Should().NotBeNull();
        }
    }
}
