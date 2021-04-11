using DiskVinil.Adapter;
using DiskVinil.Bordas.Adapter;
using DiskVinil.Bordas.Repositorios;
using DiskVinil.Bordas.UseCase;
using DiskVinil.Context;
using DiskVinil.Repositorios;
using DiskVinil.Services;
using DiskVinil.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DiskVinil
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("urlDisk")));

            services.AddScoped<IDiscoService, DiscoService>();

            services.AddScoped<IAdicionarDiscoUseCase, AdicionarDiscoUseCase>();
            services.AddScoped<IAtualizarDiscoUseCase, AtualizarDiscoUseCase>();
            services.AddScoped<IRemoverDiscoUseCase, RemoverDiscoUseCase>();
            services.AddScoped<IRetornarListaDeDiscoUseCase, RetornarListaDeDiscoUseCase>();
            services.AddScoped<IRetornarDiscoPorIdUseCase, RetornarDiscoPorIdUseCase>();
            services.AddScoped<IRepositorioDisco, RepositorioDisco>();
            services.AddScoped<IAdicionarDiscoAdapter, AdicionarDiscoAdapter>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
