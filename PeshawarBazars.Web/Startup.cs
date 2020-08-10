using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeshawarBazars.Web.Startup))]
namespace PeshawarBazars.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
