FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build

COPY . /source

WORKDIR /source/Kudiyarov.TrainingPrograms.Web

ARG TARGETARCH

RUN dotnet publish --use-current-runtime --self-contained false -o /app

FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine AS final
WORKDIR /app

COPY --from=build /app .

USER $APP_UID

ENTRYPOINT ["dotnet", "Kudiyarov.TrainingPrograms.Web.dll"]
