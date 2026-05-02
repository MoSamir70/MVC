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
