using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laboration_1.Startup))]
namespace Laboration_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
