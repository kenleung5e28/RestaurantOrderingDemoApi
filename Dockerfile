FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RestaurantOrderingDemoApi.csproj", "./"]
RUN dotnet restore "RestaurantOrderingDemoApi.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "RestaurantOrderingDemoApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantOrderingDemoApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantOrderingDemoApi.dll"]
