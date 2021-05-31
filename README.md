# Thread .NET - mini-project Thread

## Описание:

**Thread** - это [SPA](https://medium.com/@NeotericEU/single-page-application-vs-multiple-page-application-2591588efe58) с готовой архитектурой и структурой, подключенным базовым стеком технологий и стартовым функционалом, предназначенный для самостоятельной практики студентов.

Тематика проекта - социальная сеть, похожая на Twitter.

Основная идея проекта - ознакомить студентов с нашим виденьем того, как реальный проект должен выглядеть изнутри, и дать возможность самостоятельно исследовать, как устроена архитектура и структура проекта, посмотреть его возможные конфигурации, попробовать покопаться и разобраться в чужом коде.

## Технологии:

### Backend:

-   [.NET 5](https://dotnet.microsoft.com/download)
-   [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
-   [EF Core](https://docs.microsoft.com/ef/core)
-   [FluentValidation](https://github.com/JeremySkinner/FluentValidation)
-   [AutoMapper](https://github.com/AutoMapper/AutoMapper)
-   [Bogus](https://github.com/bchavez/Bogus)
-   [JWT](https://jwt.io)
-   [SignalR](https://dotnet.microsoft.com/apps/aspnet/real-time)

### Frontend:

-   [Angular](https://angular.io)
-   [Angular Material](https://material.angular.io)

## Рекомендованные инструменты:

-   [Visual Studio IDE](https://visualstudio.microsoft.com/vs)
-   [Visual Studio Code](https://code.visualstudio.com)
-   [Postman](https://www.getpostman.com)

## Установка:

-   Убедитесь, что у Вас установлен [.NET](https://dotnet.microsoft.com/download) v.5.0, [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads), [Node.js](https://nodejs.org/en/) LTS и [Angular CLI](https://angular.io/cli).
-   [Добавьте новую переменную окружения](https://www.twilio.com/blog/2017/01/how-to-set-environment-variables.html) `SecretJWTKey` со значением `DD70E219DCF6408A7506EA0186D183AE`.
-   Зарегистрируйтесь на [Gyazo](https://gyazo.com/signup) и [создайте новое приложение](https://gyazo.com/oauth/applications) указав **Callback URL** как **http://example.com**.
    -   После успешного создания приложения откройте его и сгенерируйте **Access Token**. Вы получите получите токен который вам нужно добавить в Angular приложение. Для этого откройте файл **frontend/src/environments/environment.ts** и добавьте значение для свойства **gyazoAccessToken** в объект **environment**. Пример, как это должно выглядеть:

```typescript
export const environment = {
    production: false,
    apiUrl: 'https://localhost:44344',
    gyazoAccessToken: 'abc123def789xyz',
};
```

## Сборка проектов:

-   **Backend**:

    -   Откройте **backend/Thread .NET.sln** с помощью Visual Studio и соберите решение.
        -   Или Вы можете выполнить в консоли команду `dotnet build` находясь в папке **backend/**.

-   **Frontend**:
    -   Откройте папку **frontend/** с помощью Visual Studio Code и в терминале выполните команду `npm i`.

## Создание БД:

- База данных будет создана автоматически при первом запуске **Thread .NET.WebAPI** проекта, или же откройте консоль в папке **backend/Thread .NET.WebAPI/** и выполните команду `dotnet ef database update`. Возможно, нужно будет [установить EF Core глобально](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet).

    -   **Note:** По умолчанию, строка подключения к SQL Server будет **(local)**. Если Вы используете другой алиас для подключения к SQL Server, то не забудьте обновить свойство _ThreadDBConnection_ в файле `appsettings.json`, которое находится в папке **backend/Thread .NET.WebAPI**.

## Запуск проектов:

-   **Backend**:

    -   Откройте **backend/Thread .NET.sln** с помощью Visual Studio, соберите решение и запустите проект **Thread .NET.WebAPI**.
        -   **Note:** По умолчанию, приложение стартует на 44344 порте и будет доступно по адресу https://localhost:44344. Если Вы запускаете приложение командой `dotnet run` или Вы поменяли стандартный порт, Вам также необходимо обновить свойство _apiUrl_ в файле **frontend/src/environments/environment.ts**. А также Вы должны обновить свойство _JwtIssuerOptions.Audience_ в файле `appsettings.json`, которое находится в папке **backend/Thread .NET.WebAPI**.

-   **Frontend**:
    -   Откройте папку **frontend/** с помощью Visual Studio Code и выполните в терминале команду `ng serve`. Приложение запустится на 4200 порте и будет доступно по адресу http://localhost:4200.

## Задания:

Необходимо добавить следующие возможности:

1. Редактирование/удаление своих постов.
2. Дизлайки для постов.
3. Отобразить список пользователей, которые лайкнули/дизлайкнули пост.
4. Редактирование/удаление своих комментариев.
5. Лайки/дизлайки для комментариев.
6. Отобразить список пользователей, которые лайкнули/дизлайкнули комментарий.
7. Добавить больше real-time уведомлений (SignalR), например при обновлении/удалении поста/комментария, или при лайке поста/комментария.
8. Добавить нотификации(toastr) для frontend'a, когда я (как пользователь) создаю новый пост.
9. Расширить валидацию (backend/frontend) на свое усмотрение - например, пользователь не должен иметь возможности сохранить невалидный email.
10. Добавить фильтр - отображать только те посты, которым я (как пользователь) поставил лайк.
11. Добавить возможность сброса пароля. Отправить email с ссылкой на страницу изменения пароля.
    > **P.S. - в данном задании НЕ НУЖНО коммитить в репозиторий Ваши SMTP данные.**
12. Отправить пользователю email, если его посту поставили лайк.
13. Поделиться постом по email.

💻 Happy coding! 😊
