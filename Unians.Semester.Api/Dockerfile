FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Unians.Semester.Api/Unians.Semester.Api.csproj", "Unians.Semester.Api/"]
RUN dotnet restore "Unians.Semester.Api/Unians.Semester.Api.csproj"
COPY . .
WORKDIR "/src/Unians.Semester.Api"
RUN dotnet build "Unians.Semester.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Unians.Semester.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Unians.Semester.Api.dll"]