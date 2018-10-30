using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(validationDemo.Startup))]
namespace validationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
