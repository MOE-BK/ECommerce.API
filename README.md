# ECommerce.API 🛒

A backend RESTful API for an E-Commerce system built with **ASP.NET Core Web API** and **Entity Framework Core**.

The project is designed with a layered architecture to keep the application maintainable, testable, and easy to extend.

---

## 🚀 Technologies

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- LINQ
- JWT Authentication
- Swagger / OpenAPI
- Dependency Injection
- Repository Pattern
- Service Layer
- DTOs
- Git & GitHub

---

## 🏗️ Architecture

The project follows a layered architecture:

```text
Client
   │
   ▼
Controllers
   │
   ▼
Services
   │
   ▼
Repositories
   │
   ▼
Entity Framework Core
   │
   ▼
SQL Server
```

### Main Layers

#### Controllers

Responsible for handling HTTP requests and returning HTTP responses.

```text
Controllers/
```

Controllers communicate with the service layer instead of containing the application's main business logic.

---

#### Services

Contains the application's business logic.

```text
Services/
```

The service layer keeps business rules separated from HTTP and database concerns.

---

#### Repository

Responsible for database access and common data operations.

```text
Repository/
```

The repository layer works with Entity Framework Core to interact with the database.

---

#### DTOs

Data Transfer Objects are used to control the data exposed by the API.

```text
DTOs/
```

DTOs help prevent exposing database entities directly through API endpoints and allow different models for creating, updating, and returning data.

---

#### Data

Contains the Entity Framework Core database context and database configuration.

```text
Data/
```

---

#### Models

Contains the application's entity models.

```text
Models/
```

---

## ✨ Features

- Product management
- Category management
- CRUD operations
- DTO-based API communication
- Service Layer
- Generic Repository
- Entity Framework Core
- SQL Server integration
- LINQ queries
- Dependency Injection
- JWT Authentication
- Swagger API documentation
- Separation of concerns
- Async database operations

---

## 🔐 Authentication

The API supports authentication using **JWT (JSON Web Tokens)**.

The authentication flow is:

```text
User
  │
  ▼
Login
  │
  ▼
Authentication
  │
  ▼
JWT Token
  │
  ▼
Authorization
  │
  ▼
Protected API Endpoints
```

Protected endpoints require a valid JWT token.

---

## 📦 Project Structure

```text
ECommerce.API/
│
├── Controllers/
│
├── Data/
│
├── DTOs/
│
├── Models/
│
├── Repository/
│
├── Services/
│
├── Migrations/
│
├── Program.cs
│
├── appsettings.json
│
└── ECommerce.API.csproj
│
ECommerce.API.slnx
```

---

## 🗄️ Database

The project uses:

**SQL Server**

Entity Framework Core is responsible for:

- Database connection
- Entity mapping
- Relationships
- CRUD operations
- Migrations
- LINQ queries

### Example

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
```

---

## 🔄 API Request Flow

A typical request follows this flow:

```text
HTTP Request
     │
     ▼
Controller
     │
     ▼
Service
     │
     ▼
Repository
     │
     ▼
Entity Framework Core
     │
     ▼
SQL Server
     │
     ▼
Repository
     │
     ▼
Service
     │
     ▼
DTO
     │
     ▼
HTTP Response
```

This separation makes the application easier to maintain and extend.

---

## 📖 API Documentation

Swagger / OpenAPI is used to explore and test the available endpoints.

After running the project, open the Swagger UI from the URL provided by ASP.NET Core.

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/MOE-BK/ECommerce.API.git
```

### 2. Navigate to the project

```bash
cd ECommerce.API
```

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Configure the database

Update the connection string in:

```text
appsettings.json
```

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

> Do not commit real passwords, API keys, or other sensitive credentials to GitHub.

### 5. Apply migrations

```bash
dotnet ef database update
```

### 6. Run the application

```bash
dotnet run
```

---

## 🧪 Testing the API

After running the application, use Swagger to test the available endpoints.

You can perform operations such as:

- Create products
- Get products
- Get product by ID
- Update products
- Delete products
- Manage categories
- Authenticate users

---

## 🎯 Project Goals

This project was built to practice and apply real-world ASP.NET Core Web API concepts, including:

- Clean separation of responsibilities
- RESTful API development
- Database-driven applications
- Entity Framework Core
- Authentication and authorization
- Repository and Service patterns
- DTO mapping
- Dependency Injection
- API documentation

---

## 👨‍💻 Author

**Mohamed Bakhyet**

GitHub: [MOE-BK](https://github.com/MOE-BK)

LinkedIn: [Mohamed Bakhyet](https://www.linkedin.com/in/mohamed-bakhyet-b24373359/)

---

## 📄 License

This project is for educational and portfolio purposes.
