# 📌 SWE 316 – Homework #1  
### Term Schedule Visualization System  
**Language:** C# (.NET — WinForms/WPF)

---

## 👤 Course Information
- **Section:** F-03
- **Instructor:** Khalid Aljasser

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

---

## ⚙️ Program Workflow

### 🔹 Step 1 — Load Excel File  
The program reads and converts each row into objects.

### 🔹 Step 2 — Enter CRNs  
Example input:
11695 14313 10744 15375


### 🔹 Step 3 — Select a Day  
User selects one of:
Sun | Mon | Tue | Wed | Thu


### 🔹 Step 4 — Visualize the Route  
The system:

- Filters matching courses  
- Orders classes by time  
- Draws the path on the campus map panel  
- Marks buildings  
- Connects them in order  

---

## 📊 Results Displayed
The results panel includes:

- Selected day  
- Number of courses  
- List of courses  
- Number of buildings  
- Total walking distance  

![Alt text](sample_output.jpeg)

---

## 🧪 Edge Cases Handled
- Invalid CRNs  
- Empty Excel cells  
- Duplicate buildings  
- Missing data  

---

## ▶️ How to Run the Project
1. Open the solution in **Visual Studio**
2. Restore NuGet packages (if applicable)
3. Build the solution
4. Run the program
5. Load the Excel file
6. Enter CRNs & select a day

---

## 👩‍💻 Technologies Used
- **C#**
- **.NET Framework**
- **Visual Studio**
- **WinForms / WPF**

---

## 🚀 Future Enhancements
- Show walking time estimate
- Support multiple students
- Add UI themes

---

## 📎 Academic Declaration
This project was developed as part of **SWE 316 — Software Design & Construction coursework.**

---
