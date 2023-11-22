#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/SalesDemo.Web.Public/SalesDemo.Web.Public.csproj", "src/SalesDemo.Web.Public/"]
COPY ["src/SalesDemo.Web.Core/SalesDemo.Web.Core.csproj", "src/SalesDemo.Web.Core/"]
COPY ["src/SalesDemo.Application/SalesDemo.Application.csproj", "src/SalesDemo.Application/"]
COPY ["src/SalesDemo.Application.Shared/SalesDemo.Application.Shared.csproj", "src/SalesDemo.Application.Shared/"]
COPY ["src/SalesDemo.Core.Shared/SalesDemo.Core.Shared.csproj", "src/SalesDemo.Core.Shared/"]
COPY ["src/SalesDemo.Core/SalesDemo.Core.csproj", "src/SalesDemo.Core/"]
COPY ["src/SalesDemo.EntityFrameworkCore/SalesDemo.EntityFrameworkCore.csproj", "src/SalesDemo.EntityFrameworkCore/"]
COPY ["src/SalesDemo.GraphQL/SalesDemo.GraphQL.csproj", "src/SalesDemo.GraphQL/"]
RUN dotnet restore "src/SalesDemo.Web.Public/SalesDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/SalesDemo.Web.Public"
RUN dotnet build "SalesDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalesDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalesDemo.Web.Public.dll"]
