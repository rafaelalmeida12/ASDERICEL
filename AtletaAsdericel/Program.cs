using AtletaAsdericel.Data;
using AtletaAsdericel.Helpers;
using AtletaAsdericel.Models;
using AtletaAsdericel.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_PT;


var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie( options =>
//    {
//        options.LoginPath = "/Usuario/Login";
//        options.AccessDeniedPath = "/Usuario/AccessDenied";
//    });

// Add services to the container.
builder.Services.AddControllersWithViews();
// Configurar esquema de autenticação com cookies
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
//    options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
//});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddHttpClient<CorreiosService>();

// Registrar IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

builder.Services.AddDefaultIdentity<Usuario>(options =>
{
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
})
 .AddRoles<IdentityRole>()
 .AddEntityFrameworkStores<ApplicationDbContext>()
 .AddDefaultTokenProviders()
 .AddErrorDescriber<PortugueseIdentityErrorDescriber>();


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/usuario/login"; // Set your custom login path here
    options.AccessDeniedPath = "/usuario/acessonegado"; // Defina o caminho de acesso negado personalizado aqui
});

builder.Services.AddScoped<UserManager<Usuario>>();
builder.Services.AddScoped<SignInManager<Usuario>>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<Usuario>>();
    await ApplicationDbContextSeed.SeedRolesAsync(roleManager);
    await ApplicationDbContextSeed.SeedAdminUserAsync(userManager, roleManager);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Add this line
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
