using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(displayFormatDemo.Startup))]
namespace displayFormatDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
