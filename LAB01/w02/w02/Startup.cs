using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w02.Startup))]
namespace w02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
