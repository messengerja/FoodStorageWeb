using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodStorageWeb.Startup))]
namespace FoodStorageWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
