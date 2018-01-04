using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OneOff.WebAPI.Startup))]

namespace OneOff.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
