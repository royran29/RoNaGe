using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MahoganyASP.UI.Startup))]
namespace MahoganyASP.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
