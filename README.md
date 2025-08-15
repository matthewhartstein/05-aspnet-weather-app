# 05-aspnet-weather-app

ASP.NET Core Weather API

Programming Language: C#

Libraries/Frameworks:
- ASP.NET Core (targeting .NET 9.0)
- Microsoft.AspNetCore.OpenApi (version 9.0.8)
- Newtonsoft.Json (version 13.0.3)
- Swashbuckle.AspNetCore (version 9.0.3)

Description: This is an ASP.NET Core Web API that fetches real-time weather data from the OpenWeatherMap API and returns it in a clean format, with temperatures in Fahrenheit.

The project includes:

- Program.cs: Sets up the ASP.NET Core application, configuring controllers, Swagger for API documentation, and an HTTP client for the WeatherService to make external API calls. In development mode, Swagger UI is enabled at the root URL for easy API testing.

- WeatherApp.csproj: Defines the project, targeting .NET 9.0 with nullable reference types and implicit usings, and includes dependencies for OpenAPI, JSON handling, and Swagger.
appsettings.json: Configures logging (default: Information, Microsoft.AspNetCore: Warning), allows all hosts, and stores the OpenWeatherMap API base URL and key.

- appsettings.Development.json: Overrides logging settings for development with the same log levels.
WeatherApp.http: Provides a sample HTTP request to test the /weatherforecast/ endpoint, expecting JSON output.

- The API allows users to input a city name and retrieve current weather data, with Swagger UI for testing in development. It showcases API integration, HTTP client usage, and modern ASP.NET Core features.
