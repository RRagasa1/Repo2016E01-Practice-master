using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo2016E01_Website.Startup))]
namespace Repo2016E01_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
