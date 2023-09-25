var builder = WebApplication.CreateBuilder(args);

string? environmentName = builder.Environment.EnvironmentName;
string filePath = builder.Configuration["Kestrel:Endpoints:Https:Certificate:Path"];
Console.WriteLine(filePath);
System.Diagnostics.Debug.WriteLine($"File exists: {File.Exists(filePath)}");
Console.WriteLine($"Loading environment: {environmentName}");

if ("Pfx".Equals(environmentName, StringComparison.OrdinalIgnoreCase))
{
  builder.Configuration.AddJsonFile($"appsettings.Pfx.json");
}
if ("Pem".Equals(environmentName, StringComparison.OrdinalIgnoreCase))
{
  builder.Configuration.AddJsonFile($"appsettings.Pem.json");
}

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
