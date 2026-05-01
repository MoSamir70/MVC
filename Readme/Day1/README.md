# 🎯 ASP.NET MVC Students System – Task 1

This task is designed to help you understand and implement the core concepts of ASP.NET MVC step by step.
Follow the instructions carefully and try to build everything on your own.

---

## 🧩 Phase 1: Project Setup

### 1. Create the Project

* Create a new **ASP.NET Core MVC** project.
* Use **.NET 8**.
* Run the project to ensure it works correctly.

---

## 🧩 Phase 2: Create Model

### 2. Create Student Model

* Inside the `Models` folder, create a class called **Student**.
* Add the following properties:

  * Id → represents student ID
  * Name → represents student name
  * ImageURL → represents image file name

📌 Goal: Represent student data.

---

## 🧩 Phase 3: Create Data Layer (Business Logic)

### 3. Create StudentBL Class

* Create a class called **StudentBL** inside `Models`.
* Add a list of students inside the class.
* Insert at least 4 dummy students manually.

### 4. Add Methods

* Create a method to return all students.
* Create a method to return a student by Id.

📌 Goal: Simulate a database using in-memory data.

---

## 🧩 Phase 4: Create Controller

### 5. Create StudentController

* Create a controller called **StudentController**.

---

### 6. Create Action: ShowAll

* Create an action method called **ShowAll()**.
* Inside it:

  * Create an object from StudentBL.
  * Get all students.
  * Pass the list to a view.

---

### 7. Create Action: Details

* Create an action method called **Details(int id)**.
* Receive the student Id from the URL.
* Get the student using StudentBL.
* Return a view with that student.

📌 URL Example:

```
/Student/Details?id=1
```

---

## 🧩 Phase 5: Create Views

### 8. Create ShowAll View

* Create a view called **ShowAll** inside `Views/Student`.
* Make it strongly typed to a list of students.
* Display students in a table.
* Show:

  * Id
  * Name
  * Image

---

### 9. Create ShowDetails View

* Create a view called **ShowDetails**.
* Make it strongly typed to a single student.
* Display:

  * Name
  * Id
  * Image (larger size)

---

## 🧩 Phase 6: Razor Basics

### 10. Variables in Razor

* Declare variables inside the view.
* Print them inside HTML.

---

### 11. If Condition

* Create a condition comparing two variables.
* Display different output based on the result.

---

### 12. Loop

* Use a loop to display multiple values.
* Example: print numbers from 0 to 9.

---

## 🧩 Phase 7: Frontend Integration

### 13. Add HTML, CSS, JS

* Add a heading in the page.
* Style it using CSS (e.g., change color).
* Add JavaScript to print a message in the browser console.

📌 Goal: Understand that Razor Views combine:

* HTML
* CSS
* JavaScript
* C#

---

## 🧩 Phase 8: Static Files (Images)

### 14. Setup Images

* Create a folder called **images** inside `wwwroot`.
* Add image files inside it.

### 15. Display Images

* Bind the image name from the model to the image path.

📌 Important:

* Image path must start with `/` or `~/`.

---

## 🧩 Phase 9: Controller Results

### 16. Create Action Returning Text

* Create an action that returns a plain text message "Hello World".

---

### 17. Create Action Returning View

* Create an action that returns a specific view.

---

### 18. Create Conditional Action

#### Create Action: ShowMix(int id, string name)

* If the id is even:

  * Return a View (e.g., View1)
* If the id is odd:

  * Return a text message "Hello World"

---

### 19. Create Improved Action: ShowMix2(int id, string name)

* Create an action method called **ShowMix2()**.
* Behavior:

  * If the id is even:

    * Return a View (View1)
  * If the id is odd:

    * Return text: **"Hello World"**

📌 Goal:
Understand how to use built-in helper methods instead of manual result creation.

---

## 🧩 Phase 10: Additional Concepts

### 20. Understand var vs dynamic

* Use `var` and `dynamic` in a test class.
* Observe:

  * `var` is checked at compile time.
  * `dynamic` is checked at runtime and may cause errors.

---

## 🎯 Final Requirements

After completing this task, you should be able to:

* Display a list of students
* Display student details
* Work with Razor syntax
* Understand MVC flow (Model → Controller → View)
* Handle static files (images)
* Use different types of Action Results

---

## 🚀 Bonus Task

### 21. Add Navigation

* Add a **Details** button for each student in the list.
* When clicked:

  * Redirect to `/Student/Details/{id}`

---

## 💡 Summary

This project covers:

* MVC Architecture
* Controllers & Actions
* Models & Data Handling
* Razor Views
* Routing
* Static Files

---

👉 Next Step (Recommended):

* Add CRUD operations
* Connect to SQL Server
* Build a full real-world system
