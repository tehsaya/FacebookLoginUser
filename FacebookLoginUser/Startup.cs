using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacebookLoginUser.Startup))]
namespace FacebookLoginUser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
