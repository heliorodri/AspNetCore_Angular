# AspNetCore_Angular

Helpful hints:

- Creating Db Using EF Migrations
  .Add a connectionStrings section in the settings File;
  .Install Tool dotnet-ef
  .If Microsoft.EntityFrameworkCore.Design package it's not installed, it is required to install 
  .Run the command "dotnet ef migration add <params>"
  .Run the command "dotnet ef database update" to apply the modifications
