using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_asp_training.Startup))]
namespace Vidly_asp_training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
