# eTickets Web Application

Welcome to the **eTickets** project! This is an ASP.NET Core web application designed for managing movie tickets, orders, and user authentication with a clean and responsive UI.

Access the application at the live URL: https://thebmarhone.net/ or at https://localhost:5001 during development.

---

## Features

- **User Authentication**: Supports login, registration, and role-based access control.
- **Order Management**: Users can create and manage their orders.
- **Movie Management**: Full CRUD operations for movies, including adding, editing, and deleting.
- **Shopping Cart**: Integrated shopping cart for managing ticket purchases.
- **Responsive Design**: User-friendly and works across devices.

---

## Technologies Used

- **ASP.NET Core 6.0**: For building the web application.
- **Entity Framework Core**: For database interactions.
- **Microsoft SQL Server**: For data storage.
- **Bootstrap**: For responsive design and styling.
- **Identity**: For authentication and role management.

---

## Prerequisites

Ensure you have the following installed:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- Visual Studio 2022 (or another C# IDE)

---

## Getting Started

### 1. Clone the Repository

```bash
git clone <repository_url>
cd eTickets
```

### 2. Set Up the Database

Ensure your database connection string is correctly configured in `appsettings.json`:


### 3. Apply Migrations

Run the following commands to create the database schema:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Seed the Database

The application automatically seeds initial data (users, roles, movies, etc.) during startup. Ensure `AppDbInitializer` is correctly configured in `Program.cs`:

```csharp
AppDbInitializer.Seed(app);
AppDbInitializer.SeedUsersAndRolesAsync(app).Wait();
```

### 5. Run the Application

Start the application using Visual Studio or the CLI:

```bash
dotnet run
```

Access the application at `https://localhost:5001` (or the URL specified in your configuration).

---

## Project Structure

### **Key Directories**

- **`Data/`**: Contains database context and data services.
- **`Models/`**: Defines entity models for the application.
- **`Controllers/`**: Handles HTTP requests and responses.
- **`Views/`**: Contains Razor views for the UI.
- **`wwwroot/`**: Static files like CSS, JS, and images.

### **Key Files**

- **`Program.cs`**: Application entry point and middleware configuration.
- **`appsettings.json`**: Configuration file for connection strings and app settings.

---

## Authentication & Authorization

- **Roles**: `Admin`, `User`
- Default credentials for testing:
  
  - you can create one

---

## Contributing

Contributions are welcome! Please fork the repository and create a pull request for any enhancements or bug fixes.

---

## License


