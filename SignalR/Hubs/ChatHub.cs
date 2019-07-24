using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var content = $"{user} 於{DateTime.Now.ToShortTimeString()}說：{message}";

            await Clients.All.SendAsync("ReceiveMessage", content);
        }
    }
}
