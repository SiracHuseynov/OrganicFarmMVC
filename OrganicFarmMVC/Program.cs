using Microsoft.EntityFrameworkCore;
using OrganicFarmMVC.DAL;

namespace OrganicFarmMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-4VAU7GI\\SQLEXPRESS;Database=OrganicFarmDb;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;");
            });
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.UseStaticFiles();
            app.MapControllerRoute("default", "{controller=home}/{action=index}");

            app.Run();
        }
    }
}
