using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.Data;
using WestCoast_Cars.Models;

var builder = WebApplication.CreateBuilder(args);//args läser in från appsettings.json och andra

// Add services to the container.
// sätt upp databas konfiguration
builder.Services.AddDbContext<WestcoastCarsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

// dependency Injection
builder.Services.AddScoped<VehicleModel, VehicleModel>();
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

app.Run();
