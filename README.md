## RecipeBox.Solution

### By Meron Tekie, Jake Edgar, Marcus Lorenzo, and James Fox

A web application to keep track of recipes.

## Tech Used

* C#
* DotNet 
* Razor 
* HTML
* CSS
* Entity Core

## Description 

In this app a user can input a recipe and modify it later.

## Setup/Installation Requirements

* First make sure you have MySql Workbench downloaded and properly installed. You will also need a text editor and a command line that you are comfortable with. 

* In you command line navigate to your desktop directory and clone this project using *Git Clone https://github.com/MeronTekie/recipe-box*

* Open the project in your preferred text editor, we recommend VSCode. 

* To access the database please do as follows:

  * First create a file using the *touch* command in your command line, at the root of the project directory called "appsettings.json" and in that file add the following code, but substituting the text in the brackets for your own information. 

  ```
  { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[your_database];uid=[Your ID];pwd=[Your Password];" } }
  ```

* Then open MySQL Workbench and login. 

* Use Entity Framework Migration to synchonize a database. 

* In your command line navigate to the directory "RecipeBox" and run the following commands in order:
  * *dotnet restore*
  * *dotnet build*
  * *dotnet run*

* Follow the prompt to view the project at *localhost:5000*

## Known Bugs

* There are no known bugs at this time

## License

Licensed under the [MIT License](LICENSE).
Copyright (c) 2022 Meron Tekie, James Fox, Marcus Lorenzo, and Jake Edgar