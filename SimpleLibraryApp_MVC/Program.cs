using Microsoft.EntityFrameworkCore;
using SimpleLibraryApp_DataAccess.Data;

namespace SimpleLibraryApp_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlServer());
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Customer}/{action=LentBooks}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Customer}/{action=Delete}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Customer}/{action=Edit}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Customer}/{action=CreateBookLend}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Customer}/{action=ReturnBook}/{id?}");


            app.Run();
        }
    }
}