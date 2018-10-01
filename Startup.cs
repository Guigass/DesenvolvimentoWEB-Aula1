using Fiap01;
using Fiap01.Data;
using Fiap01.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Startup 
{
    public void ConfigureServices(IServiceCollection services)
    {
        var connection = @"Server=localhost;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

        services.AddDbContext<PerguntasContext>(o => o.UseSqlServer(connection));

        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
    {
        #region Exemplos de Midware

        //app.Use((context, next) =>
        //{
        //    //Do some work here
        //    context.Response.Headers.Add("X-Teste", "headerteste");
        //    return next();
        //});

        //app.Use(async (context, next) =>
        //{
        //    await next.Invoke();
        //});

        //app.Run(async context =>
        //{
        //    await context.Response.WriteAsync("Olá Fiap");
        //});

        #endregion

        #region Rotas

        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();

        app.UseStaticFiles();

        app.UserMeuLogPreza();

        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            routes.MapRoute(
                name: "autor",
                template: "autor/{nome}",
                defaults: new { controller = "Autor", action = "Index" });

            routes.MapRoute(
                name: "autoresDoAno",
                template: "{ano:int}/autor",
                defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" });

            routes.MapRoute(
                name: "topicosDaCategoria",
                template: "{categoria}/{topico}",
                defaults: new { controller = "Topicos", action = "Index" });
        });

        #endregion
    }
}


