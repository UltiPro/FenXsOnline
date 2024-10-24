# FenXsOnline
FenXsOnline created by Patryk 'UltiPro' Wójtowicz and Dawid Majewski using ASP.NET Core Web API, Microsoft SQL Server, JavaScript, jQuery, Axios and Bootstrap 5.

desc

# Dependencies and Usage

### Server

Dependencies:

<ul>
  <li>Microsoft.EntityFrameworkCore 7.0.13</li>
  <li>Microsoft.EntityFrameworkCore.Tools 7.0.13</li>
  <li>Microsoft.EntityFrameworkCore.SqlServer 7.0.13</li>
  <li>Microsoft.AspNetCore.SignalR.Client 7.0.7</li>
  <li>Microsoft.AspNetCore.Identity.EntityFrameworkCore 7.0.13</li>
  <li>Microsoft.AspNetCore.Authentication.JwtBearer 7.0.13</li>
  <li>System.IdentityModel.Tokens.Jwt 7.0.3</li>
  <li>AutoMapper 12.0.1</li>
  <li>AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.1</li>
  <li>Newtonsoft.Json 13.0.3</li>
  <li>Serilog.AspNetCore 7.0.0</li>
  <li>Serilog.Expressions 3.4.1</li>
  <li>Serilog.Sinks.Seq 5.2.3</li>
  <li>Swashbuckle.AspNetCore 6.5.0</li>
</ul>

Before running or publishing the application:

> Set the correct connection string to the database in the "appsettings.json" file located in "/FenXsOnline/Server/Server". Then push migrations to database using the .NET command "dotnet ef database update" or the NuGet console command "update-database".

Running the app:

> cd "/FenXsOnline/Server"

> dotnet run

Publishing the app:

> cd "/FenXsOnline/Server"

> dotnet publish

> cd "/Server/bin/Release/net8.0/publish"

### Client

Dependencies:

<ul>
  <li>jquery 3.7.1</li>
  <li>bootstrap 5.3.2</li>
  <li>axios 1.6.1</li>
  <li>@microsoft/signalr 8.0.0</li>
</ul>

Running the app:

> cd "/FenXsOnline/Client"

> Open "index.html" file in web browser.

Publishing the app:

> There is no proper script for this.

# Preview

https://github.com/user-attachments/assets/96d9d98c-babc-4275-9a15-68236908581d
