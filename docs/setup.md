# Setup

## Requirements

* Visual Studio (Preferred) or Visual Studio Code
* .Net Core Version 5 (Will be auto installed when project is opened)


## Download Codebase

Fork the project to your own Git Account. The fork button is on the top right of the MoviesUI repo:

![Fork](./images/fork.png)

A popup will appear asking you where you want to fork to - in my view its my personal account - DanyZift. Pick your own as it will be different on your view:

![Which Account](./images/fork_to_yourrepo.png)

After clicking on your account it should then redirect to the forked repo. You should then see the following in the top right of the screen:(again your account name will show)

![After Forked](./images/after_forked.png)


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