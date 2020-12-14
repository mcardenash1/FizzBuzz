FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim  AS build
WORKDIR /src
COPY FizzBuzz.csproj .
RUN dotnet restore "FizzBuzz.csproj"
COPY . .
RUN dotnet build "FizzBuzz.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FizzBuzz.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot /usr/local/webapp/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf

