FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /App
EXPOSE 80 

COPY . ./
RUN dotnet restore ./back-end/src/PersonInfo/PersonInfo.Api
RUN dotnet publish ./back-end/src/PersonInfo/PersonInfo.Api -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /App
COPY --from=build /App/out .
ENTRYPOINT ["dotnet", "PersonInfo.Api.dll"]