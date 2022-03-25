# Setup

## Requirements

* Visual Studio (Preferred) or Visual Studio Code
* .Net Core Version 5 (Will be auto installed when project is opened)


## Download Codebase

Go to the https://github.com/DBSAdvWeb/MoviesUI and Fork the project to your own Git Account. The fork button is on the top right of the MoviesUI repo.  


## Database Migrations

The Data folder contains all the required migrations to build out the database. Open up the Package Manager Console by clicking on Tools -> NuGet Package Manager -> Package Manager Console.    Run the following command:

```shell
Update-Database
```

It should output that the following:

```shell
Build started...
Build succeeded.
```

This has created the database with all the required tables. 

## Running the project

Run the project through IIS Express.