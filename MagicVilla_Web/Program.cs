using MagicVilla_Web;
using MagicVilla_Web.Services;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddHttpClient<IVillaNumberService, VillaNumberService>();
builder.Services.AddScoped<IVillaNumberService, VillaNumberService>();

builder.Services.AddHttpClient<IVillaService, VillaService>();
builder.Services.AddScoped<IVillaService, VillaService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Auth/Login";
        option.AccessDeniedPath = "/Auth/AccessDenied";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        option.SlidingExpiration = true;
        option.Cookie.HttpOnly = true;
    });

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Make the session cookie essential
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
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
