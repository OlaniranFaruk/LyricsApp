#Compiling project in container
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build_env
WORKDIR /App
COPY ./LyricsAPI .
RUN dotnet restore
RUN dotnet publish -c Release -o out

#Create runtime docker image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App

#Expose port outside of container
EXPOSE 80

COPY --from=build_env /App/out .
ENTRYPOINT ["dotnet", "LyricsAPI.dll"]