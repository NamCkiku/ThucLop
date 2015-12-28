using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThucLop.Startup))]
namespace ThucLop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
