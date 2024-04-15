using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAulaPOO.Startup))]
namespace WebAulaPOO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
