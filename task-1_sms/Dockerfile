FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["task-1_sms/task-1_sms.csproj", "task-1_sms/"]
RUN dotnet restore "task-1_sms/task-1_sms.csproj"
COPY . .
WORKDIR "/src/task-1_sms"
RUN dotnet build "task-1_sms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task-1_sms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task-1_sms.dll"]
