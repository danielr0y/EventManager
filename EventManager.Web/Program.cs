using EventManager.DataLayer;
using EventManager.Web;
using Microsoft.AspNetCore.Mvc.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add custom Pure DI Controller Activator
var controllerActivator = new EventManagerControllerActivator(
    new EventManagerConfiguration(
        builder.Configuration.GetConnectionString("ConnectionString")
        // ,
        // builder.Configuration.GetSection("AppSettings")
        //     .GetValue<string>("RepositoryType")
    )
);
builder.Services.AddSingleton<IControllerActivator>(controllerActivator);

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

