var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();   // turn on MVC (controllers + Razor views)

var app = builder.Build();
app.MapStaticAssets();                          // serve files from wwwroot (css, images, js)
app.MapControllerRoute(                         // URL /{controller}/{action}/{id} -> Controller method
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
