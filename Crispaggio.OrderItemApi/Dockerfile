FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Crispaggio.ProductApi/Crispaggio.ProductApi.csproj", "Crispaggio.ProductApi/"]
RUN dotnet restore "Crispaggio.ProductApi/Crispaggio.ProductApi.csproj"
COPY . .
WORKDIR "/src/Crispaggio.ProductApi"
RUN dotnet build "Crispaggio.ProductApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crispaggio.ProductApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.ProductApi.dll"]
