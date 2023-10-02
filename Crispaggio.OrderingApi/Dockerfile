FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Crispaggio.OrderingApi/Crispaggio.OrderingApi.csproj", "Crispaggio.OrderingApi/"]
RUN dotnet restore "Crispaggio.OrderingApi/Crispaggio.OrderingApi.csproj"
COPY . .
WORKDIR "/src/Crispaggio.OrderingApi"
RUN dotnet build "Crispaggio.OrderingApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crispaggio.OrderingApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.OrderingApi.dll"]
