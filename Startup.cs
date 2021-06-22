using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AptechProject.Startup))]
namespace AptechProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
