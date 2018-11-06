using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(customValMsgDemo.Startup))]
namespace customValMsgDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
