using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManager2506.Startup))]
namespace BookManager2506
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
