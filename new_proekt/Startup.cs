using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(new_proekt.Startup))]
namespace new_proekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
