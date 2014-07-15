using Microsoft.Owin;
using Owin;
using SqlSignalR;

[assembly: OwinStartup(typeof (startup))]

namespace SqlSignalR
{
    public class startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}