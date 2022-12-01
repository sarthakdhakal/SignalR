using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalR.Models;

namespace SignalR.Hubs
{
    public class MessageHubs:Hub
    {
        public async Task NewMessage(Message message)
        {
            await Clients.All.SendAsync("MessageReceived", message);  
        }
    }
}