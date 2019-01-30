using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TappointmentToGo.Startup))]
namespace TappointmentToGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
