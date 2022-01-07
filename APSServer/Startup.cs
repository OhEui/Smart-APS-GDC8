using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(APSServer.Startup))]

namespace APSServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
