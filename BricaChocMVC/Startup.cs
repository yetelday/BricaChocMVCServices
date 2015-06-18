using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BricaChocMVC.Startup))]
namespace BricaChocMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
