using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeshawarBazar.Startup))]
namespace PeshawarBazar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
