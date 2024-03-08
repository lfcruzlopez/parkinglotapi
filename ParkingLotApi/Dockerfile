FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /usr/lib/ssl/openssl.cnf
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
EXPOSE 1433

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build 
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /usr/lib/ssl/openssl.cnf
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ParkingLotApi/ParkingLotApi.csproj", "ParkingLotApi/"]
RUN dotnet restore "ParkingLotApi/ParkingLotApi.csproj"
COPY . .
WORKDIR "/src/ParkingLotApi"
RUN dotnet build "ParkingLotApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ParkingLotApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ParkingLotApi.dll"]
