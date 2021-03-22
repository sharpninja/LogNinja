using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LogNinja.UI.Data;
using Photino.Blazor;

namespace LogNinja.UI
{
    public class Startup
    {
        // public Startup(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }
        //
        // public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}