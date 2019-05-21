# Thread .NET

## Technologies | Libs used:
### Backend:
- [.NET Core](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- [EF Core](https://docs.microsoft.com/ef/core)
- [FluenValidation](https://github.com/JeremySkinner/FluentValidation)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)
- [Bogus](https://github.com/bchavez/Bogus)
- [JWT](https://jwt.io)
- [SignalR](https://dotnet.microsoft.com/apps/aspnet/real-time)

### Frontend:
- [Angular](https://angular.io)
- [Angular Material](https://material.angular.io)

## Recommended tools:
- [Visual Studio IDE](https://visualstudio.microsoft.com/vs)
- [Visual Studio Code](https://code.visualstudio.com)
- [Postman](https://www.getpostman.com)

## Setting up the project:
- Make sure you have installed [.NET Core](https://dotnet.microsoft.com/download) v.2.2.x, [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads), [Node.js](https://nodejs.org/en/) LTS ver. and [Angular CLI](https://angular.io/cli).
- Fork or copy the contents of this repository to your PC.
- Add a new environment variable `SecretJWTKey` with a random MD5 hash to your system, for example, it can be `DD70E219DCF6408A7506EA0186D183AE`.
- Sign up in [Imgur](https://imgur.com/register) and [add a new application](https://api.imgur.com/oauth2/addclient) **without a callback URL**.
  - You will get _Client ID_ from Imgur - open the file **frontend/src/environments/environment.ts** and add a new string property to the variable named **imgurClientId** with your _Client ID_. It should look like:
```typescript
export const environment = {
    production: false,
    apiUrl: 'https://localhost:44344',
    imgurClientId: 'abc123def789xyz'
};
```

## Build the project:
- **Backend**:
  - Open **backend/Thread .NET.sln** via Visual Studio and build the project.
    - Or you can run a terminal and execute the `dotnet build` command in the **backend/** folder.

- **Frontend**:
  - Open **frontend/** folder via Visual Studio Code and execute the `npm i` command. To build a project in production mode, you can execute the `ng build` command.

## Database creation:
- Run a terminal in the **backend/Thread .NET.WebAPI/** folder and execute the `dotnet ef update database` command.
  - **Note:** By default, the connection string is configured to use **(local)** MS SQL Server. If you use another alias to connect to MS SQL Server, you need to update the _ThreadDBConnection_ in the `appsettings.json` file in the **backend/Thread .NET.WebAPI** folder.
  
## Run the project:
- **Backend**:
  - Open **backend/Thread .NET.sln** via Visual Studio, build the project and simply run **Thread .NET.WebAPI**.
    - **Note:** By default, the backend application will run on port 44344 and will be available at https://localhost:44344. If you start the application using the `dotnet run` command or change the default port, you must also change _apiUrl_ in the **frontend/src/environments/environment.ts** file. Also, you must update _JwtIssuerOptions.Audience_ property in the `appsettings.json` file in the **backend/Thread .NET.WebAPI** folder.

- **Frontend**:
  - Open **frontend/** folder via Visual Studio Code and execute the `ng serve` command. Application will run on port 4200 and will be available at http://localhost:4200.
  
  💻 Happy coding! 😊
