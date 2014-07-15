using Microsoft.AspNet.SignalR;

namespace SqlSignalR
{
    public class infoHub : Hub
    {
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<infoHub>();
            context.Clients.All.displayStatus();
        }
    }
}