using Newtonsoft.Json;

namespace Thread.NET.Common.DTO.Post
{
    public sealed class PostCreateDTO
    {
        [JsonIgnore]
        public int AuthorId { get; set; }

        public string PreviewImage { get; set; }
        public string Body { get; set; }
    }
}
