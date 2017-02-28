using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualShop.Startup))]
namespace VirtualShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
