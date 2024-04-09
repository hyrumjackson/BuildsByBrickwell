using BuildsByBrickwell.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IntexProjectContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:IntexConnection"]);
});

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

app.MapControllerRoute("pagenumandtype", "{productType}/Page{pageNum}", new { Controller = "Home", Action = "Products" });
app.MapControllerRoute("productType", "{productType}", new { Controller = "Home", Action = "Products", pageNum = 1 });
app.MapControllerRoute("pagination", "Products/Page{pageNum}", new { Controller = "Home", Action = "Products", pageNum = 1 });

app.MapDefaultControllerRoute();

app.Run();
