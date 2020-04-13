using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ML_Taxi_Fare.Startup))]
namespace ML_Taxi_Fare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
