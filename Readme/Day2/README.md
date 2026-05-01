# Day 2 Part 1
# 🎯 ASP.NET MVC + Entity Framework – Departments & Employees System

This task helps you build a relational MVC application using **Entity Framework Core** and SQL Server.
You will implement a **one-to-many relationship** between Departments and Employees and display data using Razor Views.

---

# 🧩 Phase 1: Required Concepts (Study First)

## 📌 Strongly Typed vs Loosely Typed Views

* **Strongly Typed View**

  * Bound to a specific model (e.g., List of Departments)
  * Provides IntelliSense
  * More secure and maintainable

* **Loosely Typed View**

  * Uses ViewBag or ViewData
  * No IntelliSense
  * Less safe and harder to maintain

---

## 📌 What is NuGet?

* NuGet is the package manager for .NET
* It allows you to install external libraries
* Used to add tools like:

  * Entity Framework Core
  * SQL Server provider

---

## 📌 Models Location

* **Models Folder**

  * Used to define application data structures inside the same project

* **Class Library**

  * Separate reusable project

👉 In this task, use the **Models folder**

---

## 📌 Relationship (Important)

* Department → Employee = **One-to-Many**
* One Department contains multiple Employees

---

# 🧩 Phase 2: Install Required Packages

## 📦 Install via NuGet (same versions)

* EntityFrameworkCore
* EntityFrameworkCore.SqlServer
* EntityFrameworkCore.Tools

📌 Goal: Enable database operations

---

# 🧩 Phase 3: Create Models

## 1. Create Department Class

* Create a class named **Department**
* Add:

  * Id
  * Name
  * ManagerName (optional)
  * List of Employees (optional)

📌 Represents a department

---

## 2. Create Employee Class

* Create a class named **Employee**
* Add:

  * Id
  * Name
  * Salary
  * JobTitle
  * ImageURL
  * Address (optional)
  * DepartmentID (Foreign Key)
  * Department (Navigation Property)

📌 Represents an employee linked to a department

---

# 🧩 Phase 4: Create DbContext

## 3. Create ITIContext Class

* Create a class named **ITIContext**
* Inherit from DbContext

### Required:

* Add a collection for Employees
* Add a collection for Departments

---

## 4. Configure Database Connection

* Add a connection string inside configuration method
* Connect to SQL Server

📌 Goal: Link application to database

---

# 🧩 Phase 5: Database Setup

## 5. Create Migration

* Generate initial migration (init)

---

## 6. Update Database

* Apply migration to create tables

---

## 7. Modify Relationship Behavior

* Change delete behavior to:

  * NoAction

📌 Prevent deleting employees when a department is deleted

---

## 8. Insert Sample Data

* Add sample records to:

  * Departments
  * Employees

📌 Goal: Test application

---

# 🧩 Phase 6: Create Controller

## 9. Create DepartmentController

* Create a controller named **DepartmentController**

---

## 10. Create Index Action

### Requirements:

* Create an action named **Index()**
* Retrieve all departments from the database

---

## 📌 Study: Lazy Loading vs Eager Loading

### Lazy Loading

* Related data is NOT loaded automatically
* Navigation properties remain empty

---

### Eager Loading

* Related data is loaded immediately
* Used when you need related entities

📌 In this task:

* Use **Eager Loading** to load Employees with Departments

---

## 11. Send Data to View

* Pass the list of departments to the view

---

# 🧩 Phase 7: Create View

## 12. Create Razor View (Non-Empty)

## 📌 Study: Empty vs Non-Empty Views

* **Empty View**

  * No layout
  * Standalone page

* **Non-Empty View**

  * Uses shared layout
  * Standard MVC view

📌 Use **Non-Empty View**

---

## 13. Design View

### Requirements:

* Bind view to a list of departments

* Create a table showing:

  * Id
  * Name

* Use a loop to display data

---

# 🧩 Phase 8: Run and Test

## 14. Test Endpoint

Open:

```
/Department/Index
```

📌 Expected Result:

* A table displaying all departments

---

# 🔄 Workflow Summary

```
User Request (/Department/Index)
        ↓
Controller (Index Action)
        ↓
DbContext (Fetch Departments + Employees)
        ↓
Model (List of Departments)
        ↓
View (Razor Rendering)
        ↓
HTML sent to Browser
```

---

# 🎯 Final Outcomes

After completing this task, you should be able to:

* Understand one-to-many relationships
* Work with Entity Framework Core
* Create and configure DbContext
* Perform migrations
* Connect to SQL Server
* Use Eager Loading
* Build strongly typed Razor views

---

# 🚀 Bonus Tasks

## ⭐ 1. Display Employee Count

* Show number of employees in each department

---

## ⭐ 2. Display Employees per Department

* Show employee data under each department

---

## ⭐ 3. Add Navigation

* Make each department clickable
* Redirect to a page showing its employees

---

# 💡 Summary

This task covers:

* MVC Architecture
* Entity Framework Core
* Database Integration
* Relationships
* Controllers & Views
* Razor Rendering

---

👉 Suggested Next Step:

* Implement full CRUD operations
* Use ViewModels
* Apply Repository Pattern
