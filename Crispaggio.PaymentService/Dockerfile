﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Crispaggio.PaymentService/Crispaggio.PaymentService.csproj", "Crispaggio.PaymentService/"]
RUN dotnet restore "Crispaggio.PaymentService/Crispaggio.PaymentService.csproj"
COPY . .
WORKDIR "/src/Crispaggio.PaymentService"
RUN dotnet build "Crispaggio.PaymentService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Crispaggio.PaymentService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Crispaggio.PaymentService.dll"]
