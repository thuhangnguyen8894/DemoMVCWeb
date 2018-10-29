using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dataTypeDemo.Startup))]
namespace dataTypeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
