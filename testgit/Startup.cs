using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testgit.Startup))]
namespace testgit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
