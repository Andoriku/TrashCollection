using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trash_Collecter_Main.Startup))]
namespace Trash_Collecter_Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
