using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sa380915MIS4200.Startup))]
namespace sa380915MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
