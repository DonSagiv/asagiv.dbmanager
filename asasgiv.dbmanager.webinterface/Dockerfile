#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV DB_IP="192.168.1.4"
ENV DB_PORT="5432"
ENV DB_NAME="addresses"
ENV DB_USERNAME="asagiv"
ENV DB_PASSWORD="empty"

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["asasgiv.dbmanager.webinterface/asagiv.dbmanager.webinterface.csproj", "asasgiv.dbmanager.webinterface/"]
COPY ["asagiv.dbmanager.addresses/asagiv.dbmanager.addresses.csproj", "asagiv.dbmanager.addresses/"]
RUN dotnet restore "asasgiv.dbmanager.webinterface/asagiv.dbmanager.webinterface.csproj"
COPY . .
WORKDIR "/src/asasgiv.dbmanager.webinterface"
RUN dotnet build "asagiv.dbmanager.webinterface.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asagiv.dbmanager.webinterface.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "asagiv.dbmanager.webinterface.dll"]