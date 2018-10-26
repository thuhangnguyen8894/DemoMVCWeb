using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(displayNameDemo.Startup))]
namespace displayNameDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
