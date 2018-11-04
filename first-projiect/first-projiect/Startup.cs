using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_projiect.Startup))]
namespace first_projiect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
