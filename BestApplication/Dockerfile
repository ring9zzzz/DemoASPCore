FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY *.sln ./
COPY BestApplication/BestApplication.csproj BestApplication/
COPY BestApplication.Common/BestApplication.Common.csproj BestApplication.Common/
RUN dotnet restore
COPY . .
WORKDIR /src/BestApplication
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BestApplication.dll"]
