## DattingApp

useful tips:

- Creating Db Using EF Migrations
  - Add a connectionStrings section in the settings File;
  - Install Tool dotnet-ef
  - If Microsoft.EntityFrameworkCore.Design package it's not installed, it is required to install 
  - Run the command "dotnet ef migration add /migration_name/"
  - Run the command "dotnet ef database update" to apply the modifications
