using AnaliseClinica.Domain.Repositories;
using AnaliseClinica.Infra;
using AnaliseClinica.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnaliseClinica.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AnaliseClinicaContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<AnaliseClinicaContext, AnaliseClinicaContext>();
            services.AddTransient<ICidadeRepository, CidadeRepository>();
            services.AddTransient<IPostoColetaRepository, PostoColetaRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IMedicoRepository, MedicoRepository>();
            services.AddTransient<IConvenioRepository, ConvenioRepository>();
            services.AddTransient<IExameRepository, ExameRepository>();
            services.AddTransient<IOrdemServicoRepository, OrdemServicoRepository>();
            services.AddTransient<IOrdemServicoExameRepository, OrdemServicoExameRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();

            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });


            app.UseStaticFiles();   
            app.UseMvc();
        }
    }
}
