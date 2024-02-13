var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

SyncfusionLicenseProvider.RegisterLicense("NTMyOTU5QDMxMzkyZTMzMmUzMGVpN2I5VDBmS2c4VUxZWGIvWHNGWlhvVDNGUE9Bc0E3djQxK3dMbm8vRXc9");
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });
builder.Services.AddScoped<IEarthquakeService, EarthquakeService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
