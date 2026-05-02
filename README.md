## 📚 Course Content

- [Day 1 – MVC Basics](Readme/Day1/README.md)
- [Day 2 P1 – EF Core & DB](Readme/Day2/README.md)
- [Day 2 P2 – Views( Data, Bag, Model)](Readme/Day2P2/README.md)

# -----------------------------------------------------------------------------------------

# 🎯 ASP.NET MVC Students System – Task 1

This task is designed to help you understand and implement the core concepts of ASP.NET MVC step by step.
Follow the instructions carefully and try to build everything on your own.

---

## 🧩 Phase 1: Project Setup

### 1. Create the Project

- Create a new **ASP.NET Core MVC** project.
- Use **.NET 8**.
- Run the project to ensure it works correctly.

---

## 🧩 Phase 2: Create Model

### 2. Create Student Model

- Inside the `Models` folder, create a class called **Student**.
- Add the following properties:
  - Id → represents student ID
  - Name → represents student name
  - ImageURL → represents image file name

📌 Goal: Represent student data.

---

## 🧩 Phase 3: Create Data Layer (Business Logic)

### 3. Create StudentBL Class

- Create a class called **StudentBL** inside `Models`.
- Add a list of students inside the class.
- Insert at least 4 dummy students manually.

### 4. Add Methods

- Create a method to return all students.
- Create a method to return a student by Id.

📌 Goal: Simulate a database using in-memory data.

---

## 🧩 Phase 4: Create Controller

### 5. Create StudentController

- Create a controller called **StudentController**.

---

### 6. Create Action: ShowAll

- Create an action method called **ShowAll()**.
- Inside it:
  - Create an object from StudentBL.
  - Get all students.
  - Pass the list to a view.

---

### 7. Create Action: Details

- Create an action method called **Details(int id)**.
- Receive the student Id from the URL.
- Get the student using StudentBL.
- Return a view with that student.

📌 URL Example:

```
/Student/Details?id=1
```

---

## 🧩 Phase 5: Create Views

### 8. Create ShowAll View

- Create a view called **ShowAll** inside `Views/Student`.
- Make it strongly typed to a list of students.
- Display students in a table.
- Show:
  - Id
  - Name
  - Image

---

### 9. Create ShowDetails View

- Create a view called **ShowDetails**.
- Make it strongly typed to a single student.
- Display:
  - Name
  - Id
  - Image (larger size)

---

## 🧩 Phase 6: Razor Basics

### 10. Variables in Razor

- Declare variables inside the view.
- Print them inside HTML.

---

### 11. If Condition

- Create a condition comparing two variables.
- Display different output based on the result.

---

### 12. Loop

- Use a loop to display multiple values.
- Example: print numbers from 0 to 9.

---

## 🧩 Phase 7: Frontend Integration

### 13. Add HTML, CSS, JS

- Add a heading in the page.
- Style it using CSS (e.g., change color).
- Add JavaScript to print a message in the browser console.

📌 Goal: Understand that Razor Views combine:

- HTML
- CSS
- JavaScript
- C#

---

## 🧩 Phase 8: Static Files (Images)

### 14. Setup Images

- Create a folder called **images** inside `wwwroot`.
- Add image files inside it.

### 15. Display Images

- Bind the image name from the model to the image path.

📌 Important:

- Image path must start with `/` or `~/`.

---

## 🧩 Phase 9: Controller Results

### 16. Create Action Returning Text

- Create an action that returns a plain text message "Hello World".

---

### 17. Create Action Returning View

- Create an action that returns a specific view.

---

### 18. Create Conditional Action

#### Create Action: ShowMix(int id, string name)

- If the id is even:
  - Return a View (e.g., View1)

- If the id is odd:
  - Return a text message "Hello World"

---

### 19. Create Improved Action: ShowMix2(int id, string name)

- Create an action method called **ShowMix2()**.
- Behavior:
  - If the id is even:
    - Return a View (View1)

  - If the id is odd:
    - Return text: **"Hello World"**

📌 Goal:
Understand how to use built-in helper methods instead of manual result creation.

---

## 🧩 Phase 10: Additional Concepts

### 20. Understand var vs dynamic

- Use `var` and `dynamic` in a test class.
- Observe:
  - `var` is checked at compile time.
  - `dynamic` is checked at runtime and may cause errors.

---

## 🎯 Final Requirements

After completing this task, you should be able to:

- Display a list of students
- Display student details
- Work with Razor syntax
- Understand MVC flow (Model → Controller → View)
- Handle static files (images)
- Use different types of Action Results

---

## 🚀 Bonus Task

### 21. Add Navigation

- Add a **Details** button for each student in the list.
- When clicked:
  - Redirect to `/Student/Details/{id}`

---

## 💡 Summary

This project covers:

- MVC Architecture
- Controllers & Actions
- Models & Data Handling
- Razor Views
- Routing
- Static Files

---

👉 Next Step (Recommended):

- Add CRUD operations
- Connect to SQL Server
- Build a full real-world system

# -----------------------------------------------------------------------------------------

# Day 2 Part 1

# 🎯 ASP.NET MVC + Entity Framework – Departments & Employees System

This task helps you build a relational MVC application using **Entity Framework Core** and SQL Server.
You will implement a **one-to-many relationship** between Departments and Employees and display data using Razor Views.

---

# 🧩 Phase 1: Required Concepts (Study First)

## 📌 Strongly Typed vs Loosely Typed Views

- **Strongly Typed View**
  - Bound to a specific model (e.g., List of Departments)
  - Provides IntelliSense
  - More secure and maintainable

- **Loosely Typed View**
  - Uses ViewBag or ViewData
  - No IntelliSense
  - Less safe and harder to maintain

---

## 📌 What is NuGet?

- NuGet is the package manager for .NET
- It allows you to install external libraries
- Used to add tools like:
  - Entity Framework Core
  - SQL Server provider

---

## 📌 Models Location

- **Models Folder**
  - Used to define application data structures inside the same project

- **Class Library**
  - Separate reusable project

👉 In this task, use the **Models folder**

---

## 📌 Relationship (Important)

- Department → Employee = **One-to-Many**
- One Department contains multiple Employees

---

# 🧩 Phase 2: Install Required Packages

## 📦 Install via NuGet (same versions)

- EntityFrameworkCore
- EntityFrameworkCore.SqlServer
- EntityFrameworkCore.Tools

📌 Goal: Enable database operations

---

# 🧩 Phase 3: Create Models

## 1. Create Department Class

- Create a class named **Department**
- Add:
  - Id
  - Name
  - ManagerName (optional)
  - List of Employees (optional)

📌 Represents a department

---

## 2. Create Employee Class

- Create a class named **Employee**
- Add:
  - Id
  - Name
  - Salary
  - JobTitle
  - ImageURL
  - Address (optional)
  - DepartmentID (Foreign Key)
  - Department (Navigation Property)

📌 Represents an employee linked to a department

---

# 🧩 Phase 4: Create DbContext

## 3. Create ITIContext Class

- Create a class named **ITIContext**
- Inherit from DbContext

### Required:

- Add a collection for Employees
- Add a collection for Departments

---

## 4. Configure Database Connection

- Add a connection string inside configuration method
- Connect to SQL Server

📌 Goal: Link application to database

---

# 🧩 Phase 5: Database Setup

## 5. Create Migration

- Generate initial migration (init)

---

## 6. Update Database

- Apply migration to create tables

---

## 7. Modify Relationship Behavior

- Change delete behavior to:
  - NoAction

📌 Prevent deleting employees when a department is deleted

---

## 8. Insert Sample Data

- Add sample records to:
  - Departments
  - Employees

📌 Goal: Test application

---

# 🧩 Phase 6: Create Controller

## 9. Create DepartmentController

- Create a controller named **DepartmentController**

---

## 10. Create Index Action

### Requirements:

- Create an action named **Index()**
- Retrieve all departments from the database

---

## 📌 Study: Lazy Loading vs Eager Loading

### Lazy Loading

- Related data is NOT loaded automatically
- Navigation properties remain empty

---

### Eager Loading

- Related data is loaded immediately
- Used when you need related entities

📌 In this task:

- Use **Eager Loading** to load Employees with Departments

---

## 11. Send Data to View

- Pass the list of departments to the view

---

# 🧩 Phase 7: Create View

## 12. Create Razor View (Non-Empty)

## 📌 Study: Empty vs Non-Empty Views

- **Empty View**
  - No layout
  - Standalone page

- **Non-Empty View**
  - Uses shared layout
  - Standard MVC view

📌 Use **Non-Empty View**

---

## 13. Design View

### Requirements:

- Bind view to a list of departments

- Create a table showing:
  - Id
  - Name

- Use a loop to display data

---

# 🧩 Phase 8: Run and Test

## 14. Test Endpoint

Open:

```
/Department/Index
```

📌 Expected Result:

- A table displaying all departments

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

- Understand one-to-many relationships
- Work with Entity Framework Core
- Create and configure DbContext
- Perform migrations
- Connect to SQL Server
- Use Eager Loading
- Build strongly typed Razor views

---

# 🚀 Bonus Tasks

## ⭐ 1. Display Employee Count

- Show number of employees in each department

---

## ⭐ 2. Display Employees per Department

- Show employee data under each department

---

## ⭐ 3. Add Navigation

- Make each department clickable
- Redirect to a page showing its employees

---

# 💡 Summary

This task covers:

- MVC Architecture
- Entity Framework Core
- Database Integration
- Relationships
- Controllers & Views
- Razor Rendering

---

👉 Suggested Next Step:

- Implement full CRUD operations
- Use ViewModels
- Apply Repository Pattern

# -----------------------------------------------------------------------------------------

# 🎯 Day 2 – Part 2: ViewData, ViewBag & ViewModel

This task focuses on sending multiple types of data from Controller to View using different approaches:

- ViewData
- ViewBag
- ViewModel (Best Practice)

---

# 🧩 Phase 1: Core Concepts (Study First)

## 📌 Desktop vs API in Request/Response

- **Desktop / MVC App**
  - Returns **Views (HTML)**
  - Used for UI rendering

- **API**
  - Returns **JSON**
  - Used for communication between systems (Frontend ↔ Backend)

👉 In this task: you are working with **MVC (View-based response)**

---

## 📌 Sending More Than One Data to View

- MVC allows sending additional data using:
  - ViewData (Dictionary: key/value)
  - ViewBag (Dynamic wrapper over ViewData)

👉 Both are used when you need to send **extra data beside Model**

---

## 📌 object vs dynamic (Important)

- **object**
  - Requires casting
  - Checked at compile time

- **dynamic**
  - No casting required
  - Checked at runtime
  - Can cause runtime errors

👉 ViewBag uses **dynamic**
👉 ViewData uses **object**

---

# 🧩 Phase 2: Create EmployeeController

## 1️⃣ Create Controller

- Create a controller named **EmployeeController**

---

## 2️⃣ Create Action: Details(int id)

### Requirements:

- Accept employee Id from URL
- Retrieve employee from database

---

### Send Additional Data to View

Inside the action:

- Create a message string
- Create a temperature value
- Create a list of branches (e.g., Assiut, Alex, Cairo)

---

### Pass Data Using ViewData

- Store:
  - Message
  - Temperature
  - Branch list
  - Color

---

### Pass Data Using ViewBag

- Assign a color value using ViewBag
- Override the previous color value (important concept)

📌 Key Insight:

- ViewBag overrides ViewData if same key is used later

---

### Send Model to View

- Retrieve Employee by Id
- Pass it to the View

---

# 🧩 Phase 3: Create Details View

## 3️⃣ Create Razor View (Details)

### Requirements:

- Bind view to Employee model
- Display employee name

---

### Use ViewBag

- Change text color using ViewBag value

---

### Use ViewData

- Display message
- Perform calculation on temperature

---

### Casting Requirement

- Convert ViewData values when needed (because it's object)

---

### Dropdown using ViewData

- Create dropdown list
- Loop through branches using ViewData
- Apply explicit casting to List<string>

---

### Dropdown using ViewBag

- Create another dropdown
- Loop directly (no casting required)

---

# 🧩 Phase 4: ViewBag vs ViewData (Deep Understanding)

## 📌 Study Concept

- ViewData:
  - Works like Dictionary
  - Needs casting

- ViewBag:
  - Wrapper over ViewData
  - Uses dynamic
  - Easier syntax

📌 Important Insight:

- Both store data in the same place internally
- Last assigned value wins

---

# 🧩 Phase 5: ViewModel (Best Practice)

## 📌 Why ViewModel?

- Used when:
  - You need to combine multiple data sources
  - You want clean, structured data
  - Avoid using ViewData / ViewBag

---

## 4️⃣ Create ViewModel Folder

- Create folder named **ViewModel** inside project

---

## 5️⃣ Create ViewModel Class

- Create class:
  **EmpDEptColorTempMSgBrchViewModel**

### Add Properties:

- EmpName
- DeptName
- List of Branches
- Temp
- Msg
- Color

📌 This class represents ALL data needed by the View

---

# 🧩 Phase 6: Create DetailsVM Action

## 6️⃣ Create Action: DetailsVM(int id)

### Requirements:

- Retrieve employee by Id
- Include related Department (Important)

---

### Prepare Additional Data

- Create list of branches

---

### Create ViewModel Object

- Instantiate ViewModel

---

### Mapping

Fill ViewModel with:

- Employee Name → EmpName
- Department Name → DeptName
- Branches list
- Temp value
- Message
- Color

---

### Return View

- Send ViewModel to View

---

# 🧩 Phase 7: Create DetailsVM View

## 7️⃣ Create Razor View (DetailsVM)

### Requirements:

- Bind view to ViewModel
- Display:
  - Employee Name
  - Department Name

---

### Display UI Data

- Use Color property to style title
- Create dropdown using Branches list

---

## 📌 Important Step

- Add namespace reference in ViewImports:
  - ViewModel namespace

---

# 🔄 Workflow Summary

```id="2y6v3q"
Request (/Employee/Details or DetailsVM)
        ↓
Controller Action
        ↓
Fetch Data from DbContext
        ↓
Prepare Extra Data (Msg, Temp, Branches, Color)
        ↓
Option 1: Send using ViewData / ViewBag
Option 2: Map into ViewModel (Best Practice)
        ↓
Pass Data to View
        ↓
Razor View Rendering
        ↓
HTML sent to Browser
```

---

# 🎯 Final Outcomes

After completing this task, you should be able to:

- Understand difference between MVC and API responses
- Send additional data using ViewData and ViewBag
- Handle casting issues
- Understand dynamic vs object
- Use ViewModel to structure data properly
- Apply best practices in MVC

---

# 🚀 Bonus Tasks

## ⭐ 1. Add Conditional Color

- Change color based on salary or temperature

---

## ⭐ 2. Add Department Info in Details Page

- Show department name in normal Details view

---

## ⭐ 3. Compare Approaches

- Implement same page using:
  - ViewData
  - ViewBag
  - ViewModel

- Decide which is better and why

---

# 💡 Summary

In this part, you learned:

- Multiple ways to send data to Views
- Limitations of ViewData & ViewBag
- Power of ViewModel (recommended approach)
- Clean separation between Controller and View

---

👉 Next Step:

- Full CRUD for Employees
- Form handling (Create/Edit)
- Validation using DataAnnotations
