namespace Thread_.NET.Common.DTO.Comment
{
    public sealed class NewCommentDTO
    {
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }
    }
}
