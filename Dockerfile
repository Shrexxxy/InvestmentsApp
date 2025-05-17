FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 13000

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

ENV PATH="$PATH:/root/.dotnet/tools"

COPY InvestmentsApp/InvestmentsApp.csproj InvestmentsApp/
COPY InvestmentsApp/InvestmentsApp.Client/InvestmentsApp.Client.csproj InvestmentsApp.Client/

RUN dotnet restore InvestmentsApp/InvestmentsApp.csproj

COPY . .
WORKDIR /src/InvestmentsApp/InvestmentsApp/
RUN dotnet build InvestmentsApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish InvestmentsApp.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "InvestmentsApp.dll"]
