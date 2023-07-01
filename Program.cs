using Microsoft.EntityFrameworkCore;
using Zadanie_back.Data;
using Zadanie_back.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Zadanie_backContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Zadanie_backContext") ?? throw new InvalidOperationException("Connection string 'Zadanie_backContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
