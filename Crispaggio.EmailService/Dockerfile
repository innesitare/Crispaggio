FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Crispaggio.EmailService/Crispaggio.EmailService.csproj", "Crispaggio.EmailService/"]
RUN dotnet restore "Crispaggio.EmailService/Crispaggio.EmailService.csproj"
COPY . .
WORKDIR "/src/Crispaggio.EmailService"
RUN dotnet build "Crispaggio.EmailService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Crispaggio.EmailService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.EmailService.dll"]
