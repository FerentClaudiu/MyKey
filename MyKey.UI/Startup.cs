using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyKey.UI.Startup))]
namespace MyKey.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
