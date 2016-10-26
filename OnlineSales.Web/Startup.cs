using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineSales.Web.Startup))]
namespace OnlineSales.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
