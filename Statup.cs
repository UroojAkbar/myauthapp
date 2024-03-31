using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        
        services.AddSingleton<IMongoClient>(new MongoClient("ymongodb+srv://sgushau2: NAQB7a4Olo1eOy0m@cluster0.rzvov1d.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"));
        
        services.AddScoped<UserRepository>();
        
        
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
          
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });


    }
}
