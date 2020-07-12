#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["asasgiv.dbmanager.webinterface/asasgiv.dbmanager.webinterface.csproj", "asasgiv.dbmanager.webinterface/"]
COPY ["asagiv.dbmanager.babythankyounotes/asagiv.dbmanager.babythankyounotes.csproj", "asagiv.dbmanager.babythankyounotes/"]
RUN dotnet restore "asasgiv.dbmanager.webinterface/asasgiv.dbmanager.webinterface.csproj"
COPY . .
WORKDIR "/src/asasgiv.dbmanager.webinterface"
RUN dotnet build "asasgiv.dbmanager.webinterface.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asasgiv.dbmanager.webinterface.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "asagiv.dbmanager.webinterface.dll"]