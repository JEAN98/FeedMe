using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIDesignFeedme.Startup))]
namespace UIDesignFeedme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
