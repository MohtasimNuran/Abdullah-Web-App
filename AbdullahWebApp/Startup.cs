using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbdullahWebApp.Startup))]
namespace AbdullahWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
