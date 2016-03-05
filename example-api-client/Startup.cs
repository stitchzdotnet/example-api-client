using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(example_api_client.Startup))]
namespace example_api_client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
