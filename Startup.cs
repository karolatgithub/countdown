public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //if (env.IsDevelopment())
        //{
        //    app.UseDeveloperExceptionPage();
        //}

        app.UseStaticFiles();

        app.UseRouting();
        //app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            //endpoints.MapRazorPages();
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }
}