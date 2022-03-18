using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(big_school_ntk.Startup))]
namespace big_school_ntk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
