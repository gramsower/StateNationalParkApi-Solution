# State & National Park Api

#### By **Greg Ramsower**

### An API listing all state and national parks in the United States of America.

## Technologies Used
* C#
* .NET6 SDK
* ASP .NET Core MVC
* Entity Framework Core
* AspNet Core Web API
* Swashbuckle
* VSCode
* GitBash
* Razor
* MySQL
* Swagger

### Description
* This is an API allowing a user to access a list of State and National Parks.
* This API implements versioning with Swagger support. Presently, the API presents two versions (V1 and V2), with identical endpoints. 
  * _Note: The default configuration of this API points to the most recent API version (here, V2)._

### Application Instructions
* NOTE: In order to run this application, you will need to ensure the following software packages are installed locally:
  - .NET6
  - MySQL and MySQL workbench
  - EF Core 6
  - Pomelo EF Core 6 MySQL library
  - MVC Versioning
  - MVC ApiExplorer
  - A code editor of your choice (VSCode, Sublime Text, etc.)

#### Installing .NET and MySQL
1. Install .NET6 if you have not done so. Visit [this link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to download the recommended versions of both software packages.
2. Follow the installer prompts to install the software. Use the default settings.
3. In a terminal, install `dotnet-script` by entering the following command: `$ dotnet tool install -g dotnet-script`. You will also need to configure your environment to access this tool. See [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Install MySQL.  Follow the instructions at [this link](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

#### Initial Setup 
5. Clone this repository.
6. Open the terminal and navigate to this project's production directory, named "StateNationalParkApi".
7. If you have not previously added the following packages globally, Add the following packages within the production directory ("StateNationalParkApi"):
```bash
$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0 
$ dotnet add package Pomelo.EntityFarmeworkCore.MySql -v 6.0.0
$ dotnet add package Microsoft.AspNetCore.Mvc.Versioning
$ dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
```
8. Within the production directory, create a new file called appsettings.json.
9. Open your code editor and navigate to appsetings.json.
10. Within appsettings.json, add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=park_api;uid=[uid];pwd=[pwd];"
  }
}
```

11. Use database migration to construct a shiny new database locally:
* In a terminal window, navigate to the project's root directory, named "StateNationalParkApi.Solution".
* Run the following commands:
```bash
$ dotnet ef migrations add Initial
$ dotnet ef database update
```
* These two commands will instantiate a local database conforming to the program requirements.

#### Running the Program
12. Open a terminal and navigate to this project's production directory ("StateNationalParkApi") if you have not already done so.
13. Type `dotnet watch run` in the command line to start the project in development mode with a watcher.
* If the build fails, revisit steps 1 - 3 and 7 above to ensure that .NET6 and the required packages have been properly installed.
14. A browser window should open to _https:localhost:5001/swagger/index.html_. 
  * If you cannot access localhost:5001, it is likely because you have not configured a .NET developer security certificate for HTTPS. (Please see [this page](https://www.learnhowtoprogram.com/c-and-net-part-time/c-web-applications/redirecting-to-https-and-issuing-a-security-certificate) for instructions on how to fix this issue. 

### API Documentation
* You can explore this API's endpoints in your browser using Swagger, or your favorite API platform (Postman is popular).
* This is an open API with full CRUD functionality. No authentication is needed to access any endpoint.

## Endpoints
* Default Index URL: http://localhost:5000
* There are two (currently identical API) versions available: V1 and V2.
* The default version is V2. You may select either by clicking on the drop-down menu at the top right part of the Swagger UI screen.
* You may also navigate to your preferred version using the structure laid out below; replace {#} with either 1 or 2.

HTTP Request Structure
```

GET    /api/v{#}/Parks
POST   /api/v{#}/Parks
GET    /api/v{#}/Parks/{id}
PUT    /api/v{#}/Parks/{id}
DELETE /api/v{#}/Parks/{id}
```

Example Query:
```
https://localhost:5001/api/v2/Parks/1
```
Example Response Body:
```
{
  "parkId": 1,
  "parkName": "Crater Lake",
  "parkState": "Oregon",
  "stateOrNational": "National"
}
```

Example Search Query
```
https://localhost:5001/api/v2/Parks/Search?searchString=National
```
Example Response
```
[
  {
    "parkId": 1,
    "parkName": "Crater Lake",
    "parkState": "Oregon",
    "stateOrNational": "National"
  },
  {
    "parkId": 2,
    "parkName": "Yosemite",
    "parkState": "California",
    "stateOrNational": "National"
  }
]
```


## Known Bugs
* No known bugs

## Questions? Comments?
Contact me! greg.ramsower@gmail.com

## License
* **SEE LICENSE [HERE](./LICENSE.txt)** 