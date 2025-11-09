using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieList_EntityFrameWork.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieList_EntityFrameWorkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieList_EntityFrameWorkContext") ?? throw new InvalidOperationException("Connection string 'MovieList_EntityFrameWorkContext' not found.")));

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
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();
