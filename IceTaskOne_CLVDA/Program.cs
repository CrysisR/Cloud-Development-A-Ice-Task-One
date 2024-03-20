using System.Drawing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IceTaskOne_CLVDA.Data;
using IceTaskOne_CLVDA.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<IceTaskOne_CLVDAContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IceTaskOne_CLVDAContext") ?? throw new InvalidOperationException("Connection string 'IceTaskOne_CLVDAContext' not found.")));


/*
 * Create an ASP.net MVC web application.
 * This must be different from the tutorial done in class.
 * Include one extra functionality besides the CRUD and index page table.
 * Submit screenshot of the app running on localhost, a screenshot of the app running on Azure web app and the github link
*/

/*
 * Controllers are the actual link that the website goes to, can get to it by appending link to url, important
 * Index() is the default of the controller
 */

/*
 * To add colour to your website, you need to adjust 2 different files, being the:
 * 1: site.css file in wwwroot\css\site.css
 * Editing the "Body" method, add the following
 * 
 * body {
  /* Margin bottom by footer height
   margin - bottom: 60px;
   >>>> background - color:red;
   }


 * 2:_layout.cshtml file in Views\shared\_layout.cshtml
 * Under the "Style" area, add the following:
 * 
 * <style>
    body {
    background-color:red;
    }
</style>

    
 */
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
