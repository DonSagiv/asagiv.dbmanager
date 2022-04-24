#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["asagiv.dbmanager.webportal/asagiv.dbmanager.webportal.csproj", "asagiv.dbmanager.webportal/"]
COPY ["asagiv.dbmanager.addresses/asagiv.dbmanager.common.csproj", "asagiv.dbmanager.addresses/"]

# Use the nuget-template file to build the nuget.config.
COPY ["asagiv.dbmanager.webportal/nuget-template.config", ""]

ARG PAT_ARG
RUN echo $PAT_ARG

# Apply the Github PAT to the nuget-template.config file to create the nuget.config file.
# This requires a PAT_ARG environment variable when calling docker build.
RUN sed "s/pat_arg/${PAT_ARG}/g" ./nuget-template.config > ./nuget.config

# Run the "restore" with the selected nuget repositories.
RUN dotnet restore "asagiv.dbmanager.webportal/asagiv.dbmanager.webportal.csproj" --configfile "./nuget.config"

COPY . .
WORKDIR "/src/asagiv.dbmanager.webportal"
RUN dotnet build "asagiv.dbmanager.webportal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asagiv.dbmanager.webportal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "asagiv.dbmanager.webportal.dll"]