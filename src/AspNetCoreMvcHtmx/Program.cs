using AspNetCoreMvcHtmx;
using AspNetCoreMvcHtmx.Core;
using Microsoft.AspNetCore.Mvc.Razor;
using Serilog;
using Serilog.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Host.AddLogging();
var logger = new SerilogLoggerFactory(Log.Logger)
  .CreateLogger<Program>();

// Add services to the container.
builder.Services.AddControllersWithViews()
  .AddRazorRuntimeCompilation();

builder.Services.Configure<RazorViewEngineOptions>(
  options => options.ViewLocationExpanders.Add(new FeatureFolderLocationExpander())
);

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
  pattern: "{controller=GetHome}/{action=GetHome}/{id?}"
);

app.Run();
