// ASP.NET Core Weather API
// Programming Language: C#
// Libraries/Frameworks:
//      - ASP.NET Core (targeting .NET 9.0)
//      - Microsoft.AspNetCore.OpenApi (version 9.0.8)
//      - Newtonsoft.Json (version 13.0.3)
//      - Swashbuckle.AspNetCore (version 9.0.3)
//
// Description: This is an ASP.NET Core Web API that fetches real-time weather data from the OpenWeatherMap API and 
//              returns it in a clean format, with temperatures in Fahrenheit.
//              The API allows users to input a city name and retrieve current weather data, with Swagger UI for testing in development.
//              It showcases API integration, HTTP client usage, and modern ASP.NET Core features.


using WeatherApp.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

// Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Weather API",
        Version = "v1"
    });
});

// Register WeatherService with HttpClient
builder.Services.AddHttpClient<WeatherService>();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Weather API V1");
        c.RoutePrefix = string.Empty; // Swagger at root
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();