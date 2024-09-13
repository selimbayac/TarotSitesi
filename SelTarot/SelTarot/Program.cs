using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SelTarot.BusinessLayer.Abstract;
using SelTarot.BusinessLayer.Services;
using SelTarot.Data;
using SelTarot.DataAccesLayer.Abstract;
using SelTarot.DataAccesLayer.Repositories;
using SelTarot.DtoLayer.Concrete;
using SelTarot.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TutorialDbContext")));

// Ýþ mantýðý servislerini ekle
builder.Services.AddIdentity<User, IdentityRole<int>>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<MessageService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFortuneTellerService, FortuneTellerService>();
builder.Services.AddScoped<IFortuneTellerRepository, FortuneTellerRepository>();
builder.Services.AddScoped<IMessageService, MessageService>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
    options.AddPolicy("FortuneTellerPolicy", policy => policy.RequireRole("Falcý"));
});
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.Initialize(services);
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
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
