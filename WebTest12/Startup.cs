using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest12.Startup))]
namespace WebTest12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
