﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Kudiyarov.TrainingPrograms.Web/Kudiyarov.TrainingPrograms.Web.csproj", "Kudiyarov.TrainingPrograms.Web/"]
RUN dotnet restore "Kudiyarov.TrainingPrograms.Web/Kudiyarov.TrainingPrograms.Web.csproj"
COPY . .
WORKDIR "/src/Kudiyarov.TrainingPrograms.Web"
RUN dotnet build "Kudiyarov.TrainingPrograms.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kudiyarov.TrainingPrograms.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kudiyarov.TrainingPrograms.Web.dll"]
