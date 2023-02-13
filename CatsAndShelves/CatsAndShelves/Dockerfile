FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CatsAndShelves/CatsAndShelves.csproj", "CatsAndShelves/"]
RUN dotnet restore "CatsAndShelves/CatsAndShelves.csproj"
COPY . .
WORKDIR "/src/CatsAndShelves"
RUN dotnet build "CatsAndShelves.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CatsAndShelves.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CatsAndShelves.dll"]
