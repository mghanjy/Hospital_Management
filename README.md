# Hospital Management System

## Introduction

This project is a desktop application developed using C# and Windows Forms, designed to provide a basic interface for managing doctor information within a hospital system. The application aims to simplify the process of searching for and updating doctor data, while providing a login mechanism to ensure secure access.

## Key Features

The application offers a set of core functionalities focused on managing doctor data:

*   **Login Interface:** The system provides a login screen (Login form) to verify the user's identity before granting access to the main functions. Username and password are checked against the database.
*   **Doctor Data Management:** After a successful login, the user is directed to the main interface (Form1) which allows:
    *   **Search for a Doctor:** Users can search for a specific doctor using a unique ID.
    *   **Display Doctor Data:** When a doctor is found, their name, specialization (ds), and phone number are displayed in dedicated fields.
    *   **Update Doctor Data:** The system allows users to modify the doctor's name, specialization, and phone number and save the changes to the database.
*   **Graphical User Interface:** The application utilizes Windows Forms for a user-friendly graphical interface.

## Requirements

To run and develop this project, you will need the following:

*   **Operating System:** Windows OS.
*   **.NET Framework:** An appropriate version of the .NET Framework must be installed (the project targets v4.8 as indicated in the obj files).
*   **Visual Studio:** It is recommended to use the Visual Studio IDE to open, modify, and run the project.
*   **SQL Server Database:** The project requires an SQL Server instance to connect to. Integrated Security is used in the code, meaning the application will use the current Windows credentials to connect to the database. Ensure the server name and database name match those specified in the connection string within the code (e.g., `Server=GHANJY\ABOUDI; DataBase=Hospital; Integrated Security=true`).
*   **Database Setup:** A database named `Hospital` must be created, and the necessary queries must be executed to create the required tables (such as the `Logi` table for login and the `Docto` table for doctor data. Note that the included `Hospital.sql` file defines a table named `Doctor`, which may need review or modification to align with the code).

## Setup and Running

1.  **Clone or Download the Project:** Obtain the project files.
2.  **Set up the Database:** Ensure SQL Server is running and create the `Hospital` database and required tables as mentioned in the Requirements section. You might need to modify the server name in the connection strings found in the code files (like `Form1.cs` and potentially `Class1.cs` or `sqlbaglantisi.cs`) to match your local environment settings.
3.  **Open the Project:** Open the solution file (`Hospital_Management.sln`) using Visual Studio.
4.  **Build the Project:** Build the project from within Visual Studio to compile all components.
5.  **Run the Project:** Start the project from within Visual Studio. The main menu interface (`Mnue`) will launch, from which you can navigate to login and then manage doctor data.

## Database Structure (Suggested based on Code)

Based on the code analysis, the system appears to interact with the following tables:

*   **`Logi` Table:** (Used in `Login.cs`)
    *   `user_name`: Username.
    *   `pass`: Password.
*   **`Docto` Table:** (Used in `Form1.cs`)
    *   `id`: Doctor's unique ID.
    *   `dname`: Doctor's name.
    *   `ds`: Doctor's specialization.
    *   `phone`: Doctor's phone number.

**Note:** There is an `Hospital.sql` file in the project that defines a table named `Doctor` with a different structure. Ensure the correct table structure expected by the code is used, or modify the code to match the SQL file.


