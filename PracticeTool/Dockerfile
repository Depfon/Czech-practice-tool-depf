FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PracticeTool.csproj", "./"]
RUN dotnet restore "PracticeTool.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "PracticeTool.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PracticeTool.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PracticeTool.dll"]
