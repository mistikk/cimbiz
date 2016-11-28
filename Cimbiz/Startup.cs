using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cimbiz.Startup))]
namespace Cimbiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
