using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleIdentity.Startup))]
namespace sampleIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
