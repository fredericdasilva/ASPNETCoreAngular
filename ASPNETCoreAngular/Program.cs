using ASPNETCoreAngular.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

//Register services here
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerDocument();
builder.Services.AddDbContext<ContactsDbContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")
    )) ;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseRouting();

// Register the Swagger generator and the Swagger UI middlewares
app.UseOpenApi();
app.UseSwaggerUi3();

//app.UseMvc();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); 

app.Run();
