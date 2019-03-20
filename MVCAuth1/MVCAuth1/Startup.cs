using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuth1.Startup))]
namespace MVCAuth1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
