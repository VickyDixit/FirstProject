using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavaScript_Modal.Startup))]
namespace JavaScript_Modal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
