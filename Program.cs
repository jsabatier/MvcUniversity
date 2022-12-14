using MvcUniversity.Models;
using MvcUniversity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Ignore circular references when serializing objects into JSON
/*builder.Services.AddControllersWithViews().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);*/

// Add services to the container.
builder.Services.AddControllersWithViews();
// Attach an EF Core database context to each query
builder.Services.AddDbContext<MvcUniversityContext>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

SeedData.Init();
