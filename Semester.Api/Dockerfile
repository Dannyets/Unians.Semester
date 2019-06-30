FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Semester.Api/Semester.Api.csproj", "Semester.Api/"]
RUN dotnet restore "Semester.Api/Semester.Api.csproj"
COPY . .
WORKDIR "/src/Semester.Api"
RUN dotnet build "Semester.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Semester.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Semester.Api.dll"]