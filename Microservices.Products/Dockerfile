#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Microservices.Products/Microservices.Products.csproj", "Microservices.Products/"]
RUN dotnet restore "Microservices.Products/Microservices.Products.csproj"
COPY . .
WORKDIR "/src/Microservices.Products"
RUN dotnet build "Microservices.Products.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Microservices.Products.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microservices.Products.dll"]