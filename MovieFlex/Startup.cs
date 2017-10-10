using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieFlex.Startup))]
namespace MovieFlex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
