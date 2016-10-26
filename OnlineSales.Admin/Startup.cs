using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineSales.Admin.Startup))]
namespace OnlineSales.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
