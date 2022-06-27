FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ReplaceWithAplhabetPosition/ReplaceWithAplhabetPosition.csproj", "ReplaceWithAplhabetPosition/"]
RUN dotnet restore "ReplaceWithAplhabetPosition/ReplaceWithAplhabetPosition.csproj"
COPY . .
WORKDIR "/src/ReplaceWithAplhabetPosition"
RUN dotnet build "ReplaceWithAplhabetPosition.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReplaceWithAplhabetPosition.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReplaceWithAplhabetPosition.dll"]
