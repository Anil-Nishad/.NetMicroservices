using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Catalog.Api;

public class Startup
{
    public IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseStaticFiles();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            //endponits.MapHealthChecks(pattern: "/health", new HealthCheckOptions()
            //{
            //    Predicate = _ = true,
            //    ResponseWriter = UI
            //});
        });
    }
}
