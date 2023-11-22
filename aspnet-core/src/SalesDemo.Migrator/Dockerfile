#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/SalesDemo.Migrator/SalesDemo.Migrator.csproj", "src/SalesDemo.Migrator/"]
COPY ["src/SalesDemo.EntityFrameworkCore/SalesDemo.EntityFrameworkCore.csproj", "src/SalesDemo.EntityFrameworkCore/"]
COPY ["src/SalesDemo.Core/SalesDemo.Core.csproj", "src/SalesDemo.Core/"]
COPY ["src/SalesDemo.Core.Shared/SalesDemo.Core.Shared.csproj", "src/SalesDemo.Core.Shared/"]
RUN dotnet restore "src/SalesDemo.Migrator/SalesDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/SalesDemo.Migrator"
RUN dotnet build "SalesDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalesDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalesDemo.Migrator.dll", "-s"]
