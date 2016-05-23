using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNet4._5.Startup))]
namespace AspNet4._5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
