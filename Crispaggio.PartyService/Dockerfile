﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Crispaggio.PartyService/Crispaggio.PartyService.csproj", "Crispaggio.PartyService/"]
RUN dotnet restore "Crispaggio.PartyService/Crispaggio.PartyService.csproj"
COPY . .
WORKDIR "/src/Crispaggio.PartyService"
RUN dotnet build "Crispaggio.PartyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crispaggio.PartyService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.PartyService.dll"]
