﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5200

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HomeAssignmentDotNet8EntityFramework.csproj", "./"]
RUN dotnet restore "HomeAssignmentDotNet8EntityFramework.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "HomeAssignmentDotNet8EntityFramework.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HomeAssignmentDotNet8EntityFramework.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeAssignmentDotNet8EntityFramework.dll"]
