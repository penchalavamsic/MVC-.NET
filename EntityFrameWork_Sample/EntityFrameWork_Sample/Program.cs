using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityFrameWork_Sample.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EntityFrameWork_StudentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EntityFrameWork_StudentContext") ?? throw new InvalidOperationException("Connection string 'EntityFrameWork_StudentContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
