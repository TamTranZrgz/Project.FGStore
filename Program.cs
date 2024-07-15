using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.FGStore.Areas.Admin.Data;
using Project.FGStore.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ASPIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'ASPIdentityContextConnection' not found.");

builder.Services.AddDbContext<ASPIdentityContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ASPIdentityContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
