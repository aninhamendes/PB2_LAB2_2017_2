using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProva2Lab2AnaMendes.Startup))]
namespace WebAppProva2Lab2AnaMendes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
