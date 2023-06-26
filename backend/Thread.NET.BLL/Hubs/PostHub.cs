using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Thread.NET.Common.DTO.Post;

namespace Thread.NET.BLL.Hubs
{
    public sealed class PostHub : Hub
    {
        public async Task Send(PostDTO post)
        {
            await Clients.All.SendAsync("NewPost", post);
        }
    }
}
