using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap01
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
        }
    }
}

public class Startup 
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
    {
        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            //routes.MapRoute(
            //    name: "autor",
            //    template: "autor/{nome}",
            //    defaults: new { controller = "Autor", action="Index" });

            //routes.MapRoute(
            //    name: "autoresDoAno",
            //    template: "{ano:int}/autor",
            //    defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" });

            //routes.MapRoute(
            //    name: "topicosDaCategoria",
            //    template: "{categoria}/{topico}",
            //    defaults: new { controller = "Topicos", action = "Index" });
        });
    }
}
