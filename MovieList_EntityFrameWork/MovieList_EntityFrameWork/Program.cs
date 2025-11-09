using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieList_EntityFrameWork.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MovieList_EntityFrameWorkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieList_EntityFrameWorkContext") ?? throw new InvalidOperationException("Connection string 'MovieList_EntityFrameWorkContext' not found.")));
//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    //.AddEntityFrameworkStores<MovieList_EntityFrameWorkContext>();

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




app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();

