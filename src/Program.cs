using BlazorBootstrap;
using Luna.Ui.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped<IUserCardService, UserCardService>();

builder.Services.AddHttpClient("LunaAPI", client =>
    client.BaseAddress = new Uri("http://localhost:5227/"));
    

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
