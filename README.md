# Thread .NET - mini-project Thread

### Stage description

This stage is dedicated to self-study. We present you with a small project with select technologies and some basic functionality. This project should be enough for you to become familiar with and see how all parts of the application work together. The main goals of this stage are to give you an understanding of design patterns, data processing algorithms, conventions of writing and structuring backend/frontend code, and finally application architecture as a whole. There is no need for you to have a deep and extensive knowledge of each technology that is used in a project, however, it is important to get a general idea of how a modern web application is built and what tools can help you achieve this. You will be exploring the structure of a web app, libraries, and code as well as extending existing functionality by completing several tasks which vary in complexity for several weeks.

### Project description

**Thread** is a specially prepared template of a client-server application, in which the client is a Single Page Application ([SPA](https://en.wikipedia.org/wiki/Single-page_application)) and the backend is a web service. The project has basic architecture, aimed at future extension. Modern libraries and frameworks are used for solving ordinary problems

The theme of the project is a social network similar to Twitter.

The main idea of this project is to see how a real project should look like, understand how project architecture is designed, take a look at possible configurations of this project and read and understand someone else’s code.

Functionality:

* Registration

* Twit creation

* Twit commenting

* Updating user profile

### Expectations from students

Your understanding of the project and its components will be the determining factor of how far you’ve advanced in your learning. A task will be considered complete if its functionality has been implemented in full and the feature is working as expected. We will also look at its implementation and evaluate the resulting code, making sure that the code quality and structuring are as expected. It will show us how well you do understand the architecture of the project. By the end, everyone will get personal feedback and a grade. This feedback can help you determine your weaker sides and understand where you should pay more attention in the following lectures. The maximum number of points for this mini-project work is 10. If you enrol in our academy, these points will be added to your total grade, which also includes your grade for lectures of the theoretical stage and will be your upper edge in the top students' leaderboard.

### In the following sections, you can find

- information, that can help you to understand the project better;
- installation and startup instructions;
- tasks, that have to be done.


### Technologies:

### Backend:
- [.NET 6](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- [EF Core](https://docs.microsoft.com/ef/core)
- [FluentValidation](https://github.com/JeremySkinner/FluentValidation)
- [AutoMapper](https://github.com/AutoMapper/AutoMapper)
- [Bogus](https://github.com/bchavez/Bogus)
- [JWT](https://jwt.io)
- [SignalR](https://dotnet.microsoft.com/apps/aspnet/real-time)

### Frontend:
- [Angular](https://angular.io)
- [Angular Material](https://material.angular.io)

### Recommended instruments
- [Visual Studio IDE](https://visualstudio.microsoft.com/vs)
- [Visual Studio Code](https://code.visualstudio.com)
- [Postman](https://www.getpostman.com)

### Installation:
- Make sure you have installed these prerequisites: [.NET 6](https://dotnet.microsoft.com/download), [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads), [Node.js](https://nodejs.org/en/) LTS і [Angular CLI](https://angular.io/cli).
- [Create new environment variable](https://www.twilio.com/blog/2017/01/how-to-set-environment-variables.html) `SecretJWTKey` with value `DD70E219DCF6408A7506EA0186D183AE`.
- Sign up at [Gyazo](https://gyazo.com/signup) and і [create a new application](https://gyazo.com/oauth/applications) setting **Callback URL** to **http://example.com**.
  - After successful app creation, open it and generate **Access Token**. You will get a token, that should be added to the Angular application. For this open file **frontend/src/environments/environment.ts** and add a new value for the variable **gyazoAccessToken**. Example of how this should look like:
```typescript
export const environment = {
    production: false,
    apiUrl: 'https://localhost:44344',
    gyazoAccessToken: 'abc123def789xyz'
};
```

- Clone repository to your computer
```
git clone https://github.com/BinaryStudioAcademy/thread-net.git
```
- Create a repository at [Bitbucket](https://bitbucket.org/) and use it for further development.

### Project build:
- **Backend**:
  - Open **backend/Thread .NET.sln** with Visual Studio and build a solution.
  - Alternatively, you can execute the console command `dotnet build`, in folder **backend/**.

- **Frontend**:
  - Open folder **frontend/** with Visual Studio Code or with console and execute command `npm i`.

### DB creation:
- Database will be created automatically after the first launch of **Thread .NET.WebAPI** project or you can open the console in folder **backend/Thread .NET.WebAPI/** and execute comand `dotnet ef database update`. You may have to  [install EF Core globally](https://www.microsoft.com/sql-server/sql-server-downloads).
  - **Note:** Default connection string for connecting to SQL Server will be **(local)**. If you decide to use another alias for SQL Server connection, don't forget to update property  _ThreadDBConnection_ in file `appsettings.json`, which can be found in folder **backend/Thread .NET.WebAPI**.

### Project launch
- **Backend**:
  - Open **backend/Thread .NET.sln** with Visual Studio, build a solution, and start a project **Thread .NET.WebAPI**.
    - **Note:** By default application will be started on port 44344 and will be available using the address https://localhost:44344. If you are starting the application with the command `dotnet run` or you changed the default port, you will have to update property apiUrl_ in file **frontend/src/environments/environment.ts**. Also, you will have to update _JwtIssuerOptions.Audience_ in file `appsettings.json`, which is located in folder **backend/Thread .NET.WebAPI**.

- **Frontend**:
  - Open folder **frontend/** in Visual Studio Code and execute command `ng serve` in a console. The application will be started on port 4200 and will be available using the address http://localhost:4200.

### Tasks:

**Important**: Proejct development should take place on [Bitbucket](https://bitbucket.org/).

It's necessary to add and implement the following functionality:

1. Editing/Removing your posts.
2. Dislikes for posts.
3. Show the list of users, who liked/disliked the post.
4. Editing/Removing your comments.
5. Likes/Dislikes for comments.
6. Show the list of users, who liked/disliked the comment.
7. Add real-time notifications (SignalR), for example, notifications for a post update/deletion or when your post or comment gets a like.
8. Add a notification (toastr) on the frontend when I (as a user) create a new post.
9. Extend validation (backend/frontend) at your discretion. For example, users shouldn't be able to save invalid emails.
10. Add a filter - show only posts, which I (as a user) liked.
11. Add the ability to reset your password. Send an email with a link to the reset password page.
> **P.S. - In this task, you shouldn't commit your SMTP data to the repository.**
12. Send an email to a user, when someone liked their post.
13. Share a post by email.
### P.S.
The whole list of tasks can be found on [**Trello board**](https://trello.com/b/UNOXNqSm "**Trello**") in a 'Backlog Students' column. The board should be copied to yourself and worked on it. It will help you to track the whole progress of your work and us to understand what is completed. Repository on GitHub [https://github.com/BinaryStudioAcademy/thread-net](https://github.com/BinaryStudioAcademy/thread-net)

  💻 Happy coding! 😊
