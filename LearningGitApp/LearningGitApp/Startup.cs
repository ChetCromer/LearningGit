using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningGitApp.Startup))]
namespace LearningGitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
