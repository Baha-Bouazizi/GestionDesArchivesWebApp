using Microsoft.EntityFrameworkCore;
using GestionDesArchivesWebApp.Data;
using GestionDesArchivesWebApp.Interfaces; // Added this namespace
using GestionDesArchivesWebApp.Repositories; // Added this namespace if necessary

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repository services
builder.Services.AddScoped<IEmplacementRepository, EmplacementRepository>();
builder.Services.AddScoped<IStadeClassementRepository, StadeClassementRepository>();
builder.Services.AddScoped<ISocieteRepository, SocieteRepository>();
builder.Services.AddScoped<ITypeClassementRepository, TypeClassementRepository>();
builder.Services.AddScoped<ISupportRepository, SupportRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();

    // Initialize the database with seed data
    SeedData.Initialize(context);
}

app.Run();
