using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcModelDemo.Startup))]
namespace mvcModelDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
