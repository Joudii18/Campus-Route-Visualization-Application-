# 📌 SWE 316 – Homework #1  
### Term Schedule Visualization System  
**Language:** C# (.NET — WinForms/WPF)

---

## 👤 Student Information
- **Name:** YOUR NAME
- **ID:** YOUR ID
- **Section:** YOUR SECTION
- **Instructor:** YOUR INSTRUCTOR

---

## 📝 Problem Overview
This application reads a **Term Schedule Excel file** and extracts course information such as:

- CRN  
- Course name  
- Day & time  
- Building  

The user enters a list of **CRNs**, selects a **weekday (Sunday–Thursday)**, and the program:

- Filters courses for that day  
- Determines the route between buildings  
- Draws the route on the campus map  
- Displays a summary of results  

The map visualization is drawn **manually using the Graphics API** — without any pre-built chart or map components.

---

## 🧠 System Design — Object-Oriented Approach

### ✨ Design Principles Applied
- **Abstraction & Encapsulation**
- **Single Responsibility Principle**
- **Open-Closed Principle**

### 🏗 Main Classes
| Class | Responsibility |
|------|----------------|
| `Course` | Stores CRN, title, building, time, and day |
| `ScheduleItem` | Represents a specific course session |
| `Building` | Stores building name & coordinates |
| `StudentSchedule` | Filters courses & computes routes |
| `ExcelReader` | Reads and parses Excel file |
| `RouteCalculator` | Calculates total distance traveled |
| `MainForm` | Handles UI and drawing |

> The code structure reflects the class diagram.

---

## ⚙️ Program Workflow

### 🔹 Step 1 — Load Excel File  
The program reads and converts each row into objects.

### 🔹 Step 2 — Enter CRNs  
Example input:
