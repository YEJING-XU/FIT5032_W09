using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032AsssignmentDemo.Startup))]
namespace FIT5032AsssignmentDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
