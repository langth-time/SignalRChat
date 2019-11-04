using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        /// <summary>
        /// 发送消息给所有用户
        /// </summary>
        /// <param name="user">发送者</param>
        /// <param name="message">发送消息</param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            //test1
            //test2
            //test3
        }
    }
}