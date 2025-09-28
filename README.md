# EventEaseApp

A .NET 9 Blazor WebAssembly (WASM) single-page application.

## Tech stack
- .NET 9
- Blazor WebAssembly

## Prerequisites
- .NET SDK 9.0.x
- Optional: Visual Studio 2022 17.10+ with the "ASP.NET and web development" workload

## Getting started
### Clone
- git clone https://github.com/qganlh/blazorEventApp
- cd blazorEventApp

### Run (CLI)
- cd EventEaseApp
- dotnet restore
- dotnet run

The dev server prints a localhost URL. Open it in a browser.

### Run with Hot Reload
- dotnet watch run

### Run (Visual Studio)
- Open EventEaseApp/EventEaseApp.csproj (or the solution)
- Press F5 (Debug) or Ctrl+F5 (Run)

## Project structure
- EventEaseApp/ — Blazor WebAssembly app

## Components and pages (relative paths)
- EventEaseApp/App.razor — Application router and root component
- EventEaseApp/_Imports.razor — Common Razor imports/usings

Layouts
- EventEaseApp/Layout/MainLayout.razor — Main layout shell
- EventEaseApp/Layout/NavMenu.razor — Sidebar navigation menu

Pages
- EventEaseApp/Pages/Home.razor — Home page (/)
- EventEaseApp/Pages/EventList.razor — Events list page (/events)
- EventEaseApp/Pages/EventDetail.razor — Event details page (/events/{name})
- EventEaseApp/Pages/EventCreate.razor — Create event form (/events/new)

Reusable components
- EventEaseApp/Components/EventCard.razor — Card showing event summary; params: EventName, Date, Location, Href, DateFormat
- EventEaseApp/Components/PopupNotification.razor — Modal/overlay notification; two-way bindable Show plus Title, Message

Services and models
- EventEaseApp/Services/IEventService.cs — Contract for event data access
- EventEaseApp/Services/EventService.cs — In-memory implementation
- EventEaseApp/Services/EventItem.cs — Event entity
- EventEaseApp/Model/EventFormModel.cs — Form model with validation

## Build and publish
### Build
- dotnet build EventEaseApp

### Publish (Release)
- dotnet publish EventEaseApp -c Release
  - Output: EventEaseApp/bin/Release/net9.0/browser-wasm/publish

### Optional: WebAssembly AOT
- Install once: dotnet workload install wasm-tools
- Publish with AOT: dotnet publish EventEaseApp -c Release -p:RunAOTCompilation=true
  - AOT improves runtime performance, with larger download size/longer publish time.

## Deployment
The publish output is static content suitable for static hosts:
- Azure Static Web Apps
- GitHub Pages (set correct `<base href>` if hosted under a subpath)
- Any static file host or CDN

## Useful commands
- dotnet restore
- dotnet build
- dotnet run
- dotnet watch run
- dotnet publish -c Release

## Troubleshooting
- Clean & restore: `dotnet clean && dotnet restore`
- Verify SDK: `dotnet --info` should show .NET 9

## License
Add your license information here.
