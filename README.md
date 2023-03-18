# Dr. SillyString'z Factory

#### By Jackson Levine

## Technologies Used

* C#

* Many-to-many relationships

* Razor HTML

* VS Code

* .Net 6

* MySQL

* Entity Framework Core 6

* CSS

## Description

### Setup Instructions

#### You Will Need: 

* A code editor, like VS Code

* Git installed

* Install .Net6 SDK

#### Install MySQL Workbench:

* Follow the MySqlWorkbench installation instructions [here](https://www.mysql.com/products/workbench/), open MySql Workbench and select the Local 3306 server.

#### Project Set-up:

1. Clone or download this repository to your machine.

2. Navigate to the local directory (YourPath/Factory.Solution/Factory) and create a new file "appsettings.json".

3. Open the file in VS Code and add:

  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```

**IMPORTANT:** Be sure to replace your username, password, and name of your database for the fields [YOUR-USER-HERE], [YOUR-PASSWORD-HERE], AND [YOUR-DB-NAME].
For this project, the recommended database name is jackson_levine_factory.


4. If it is not already present, create a .gitignore file and add "appsettings.json", "bin", "obj", and "/Factory/Migrations" to the ignored file list.  

5. Open your shell (e.g., Terminal or GitBash) and add your .gitignore file and commit it before adding any other files. 

6. Navigate to this project's production directory called "Factory". 

7. In the command line, run the command `dotnet restore` to install all dependencies including EF Core. Then, run `dotnet ef database update` to allow MySQL to auto-create the required database for this project.

8. In the command line, run the command `dotnet run` to compile and execute the console application. Optionally, you can run `dotnet build` to compile this console app without running it.

9. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.

10. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

11. All CRUD functionality is through Entity Framework, so no unit tests are provided.

## Known Bugs

No known bugs.

## License

MIT License Copyright (c) 2023 Jackson Levine. Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
