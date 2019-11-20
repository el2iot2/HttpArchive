using System.Text.Json;
using Xunit;
using FluentAssertions;

namespace HttpArchive
{
    /// <summary>
    /// Unit tests for the <see cref="PostDataParam"/> object
    /// </summary>
    public class PostDataParamShould
    {
        [Fact]
        public void DeserializeSchemaExample()
        {
            var json =
@"{
""name"": ""paramName"",
""value"": ""paramValue"",
""fileName"": ""example.pdf"",
""contentType"": ""application/pdf"",
""comment"": """"
}";
            var deserialized = JsonSerializer.Deserialize<PostDataParam>(json);
            deserialized.Should().NotBeNull();
            deserialized.Name.Should().Be("paramName");
            deserialized.Value.Should().Be("paramValue");
            deserialized.FileName.Should().Be("example.pdf");
            deserialized.ContentType.Should().Be("application/pdf");
            deserialized.Comment.Should().Be("");
        }

        [Fact]
        public void RoundtripDefault()
        {
            var deserialized = JsonSerializer.Deserialize<PostDataParam>(
                JsonSerializer.Serialize(new PostDataParam()));
            deserialized.Name.Should().Be("");
            deserialized.Value.Should().BeNull();
            deserialized.FileName.Should().BeNull();
            deserialized.ContentType.Should().BeNull();
            deserialized.Comment.Should().BeNull();
        }
    }
}
