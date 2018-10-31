using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(customValAttrDemo.Startup))]
namespace customValAttrDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
