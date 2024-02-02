using ControleCarros.Data;
using ControleCarros.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace ControleCarros
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer().AddDbContext<BancoContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
            services.AddScoped<IControleCarrosRepositorio, ControleRepositorio>();
        }
        public void Configure(WebApplication app, IWebHostEnvironment evironment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        }

    }
}
