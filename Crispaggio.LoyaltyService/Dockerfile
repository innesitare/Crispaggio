FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Crispaggio.LoyaltyService/Crispaggio.LoyaltyService.csproj", "Crispaggio.LoyaltyService/"]
RUN dotnet restore "Crispaggio.LoyaltyService/Crispaggio.LoyaltyService.csproj"
COPY . .
WORKDIR "/src/Crispaggio.LoyaltyService"
RUN dotnet build "Crispaggio.LoyaltyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crispaggio.LoyaltyService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.LoyaltyService.dll"]
