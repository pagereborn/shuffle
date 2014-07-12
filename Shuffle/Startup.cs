using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shuffle.Startup))]
namespace Shuffle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
