FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /app
COPY ["./apilfs/apilfs.csproj", "apilfs/"]
RUN dotnet restore "apilfs/apilfs.csproj"
COPY ["./apilfs/.", "apilfs/"]
COPY . .
WORKDIR /app/apilfs
RUN dotnet build "apilfs.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "apilfs.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "apilfs.dll"]