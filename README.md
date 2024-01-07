# API-Docker

.Net Core 7 Web API, Docker

Create project: dotnet new webapi -n DemoApp

dotnet ef migrations add "initial-migration"

docker run -p 8081:80 -e ASPNETCORE_URLS=http://+:80 demoapp 