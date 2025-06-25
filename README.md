Blazor Server Task Management App

This is a Blazor Server application built with .NET 8.0, designed to manage tasks with CRUD (Create, Read, Update, Delete) functionality. The app uses a Razor Pages hosting model with _Host.cshtml as the entry point, eliminating the need for a static index.html. It features a responsive UI styled with Bootstrap and custom CSS, and stores task data in-memory using a singleton TaskService.


Features :
----------

* Add Tasks: Create new tasks with a title.

* View Tasks: Display all tasks in a table with title, completion status, and action buttons.

* Toggle Status: Mark tasks as completed or pending.

* Edit Tasks: Update task title and status via a dedicated edit page.

* Delete Tasks: Remove tasks from the list.

Responsive Design: Styled with Bootstrap and custom CSS for a clean, user-friendly interface.


Prerequisites:
--------------

* .NET 8.0 SDK: Install from Microsoft's .NET site.

* Visual Studio Code: Install from code.visualstudio.com or use another IDE (e.g., Visual Studio 2022).

* C# Extension for VS Code: Install the "C# for Visual Studio Code .

* Terminal: Use VS Code's integrated terminal or any command-line tool.


Notes:
------
* Data Storage: Tasks are stored in-memory for simplicity. For production, replace TaskService with a database (e.g., Entity Framework Core with SQLite or SQL Server).

* Styling: Uses Bootstrap for responsive design and site.css for custom styles.
  
* Hosting Model: Uses Razor Pages (_Host.cshtml) instead of a static index.html, common in .NET 8.0 Blazor Server apps with AddRazorPages().
  
* .NET Version: Built for .NET 8.0. Ensure the SDK is installed.
