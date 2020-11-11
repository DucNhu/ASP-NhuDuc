using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContentManagement54.Startup))]
namespace ContentManagement54
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
