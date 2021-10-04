using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHATHUB1.Startup))]
namespace CHATHUB1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
