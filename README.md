# Booker.App - Book Management System

## Prerequisites
Before proceeding, make sure you have the following installed on your machine:
- .NET SDK - version compatible with ASP.NET Core MVC
- SQL Server
- Entity Framework Core tools

## How to Use
1. Clone the repository to your local machine:
2. Set up the SQL Server connection string in the **appsettings.json**
3. Run migrations to set up the database on Cornerstech.Web project:
```
dotnet ef database update
```
4. Build and run the project:
```
dotnet run
```
5. To test admin and users, you can use the following email-password combinations:

| Role | Email | Password | Assigned Role |
|------|-------|----------|--------------|
| Admin | admin1@booker.com | a123 | Admin |
| Admin | admin2@booker.com | a123 | Admin |
| User | user1@booker.com | u123 | User |
| User | user2@booker.com | u123 | User |

## Features
- **Admin Features**
  - Manage Users: Add, Edit, Assign Roles, and Delete Users
  - Role Management: Create, Assign, and Remove Roles

- **User Features**
  - Login and interact with account details
  - Access resources based on assigned roles

- **Registration for Visitors**
  - New users can register with default User role

## Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#
- Bootstrap
