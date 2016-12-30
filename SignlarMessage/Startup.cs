using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignlarMessage.Startup))]
namespace SignlarMessage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
