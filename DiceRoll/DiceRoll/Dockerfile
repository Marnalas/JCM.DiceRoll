#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DiceRoll/DiceRoll.csproj", "DiceRoll/"]
RUN dotnet restore "DiceRoll/DiceRoll.csproj"
COPY . .
WORKDIR "/src/DiceRoll"
RUN dotnet build "DiceRoll.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DiceRoll.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DiceRoll.dll"]