using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadmoreNew.Startup))]
namespace ReadmoreNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
