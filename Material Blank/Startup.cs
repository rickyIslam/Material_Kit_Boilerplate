using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Material_Blank.Startup))]
namespace Material_Blank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
