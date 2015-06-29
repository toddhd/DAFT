using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DAFT.Startup))]
namespace DAFT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
