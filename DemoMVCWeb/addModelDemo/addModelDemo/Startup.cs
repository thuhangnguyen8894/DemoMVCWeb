using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(addModelDemo.Startup))]
namespace addModelDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
