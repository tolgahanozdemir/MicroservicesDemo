#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["Microservices.Sourcing/Microservices.Sourcing.csproj", "Microservices.Sourcing/"]
COPY ["EventBusRabbitMQ/EventBusRabbitMQ.csproj", "EventBusRabbitMQ/"]
RUN dotnet restore "Microservices.Sourcing/Microservices.Sourcing.csproj"
COPY . .
WORKDIR "/src/Microservices.Sourcing"
RUN dotnet build "Microservices.Sourcing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Microservices.Sourcing.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microservices.Sourcing.dll"]