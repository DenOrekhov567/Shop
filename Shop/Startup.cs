using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Repositories.Implementations;
using Shop.Repositories.Interfaces;

namespace Shop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //Нужен для регистрации различных плагинов в нашем проекте
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRankRepository, EFRankRepository>();
            //Добавим поддержку MVC
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Отображаем страницу с ошибками
            app.UseDeveloperExceptionPage();
            //Отображаем код страниц(404 и т. д.)
            app.UseStatusCodePages();
            //Добавляем поддержку отображения статических файлов(картинки, css и т. д.)
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            /*
            app.Run(async (context) => {
                await context.Response.WriteAsync("lol");
            });
            */
        }
    }
}
