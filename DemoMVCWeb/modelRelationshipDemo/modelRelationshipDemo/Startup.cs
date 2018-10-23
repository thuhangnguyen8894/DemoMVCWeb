using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(modelRelationshipDemo.Startup))]
namespace modelRelationshipDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
