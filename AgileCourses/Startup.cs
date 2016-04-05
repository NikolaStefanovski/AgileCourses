using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgileCourses.Startup))]
namespace AgileCourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
