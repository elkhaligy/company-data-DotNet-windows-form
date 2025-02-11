# WinForms Company Data Visualization

## 📌 Overview
This Windows Forms application visualizes company revenue data using a **bar chart, line graph, and tabular representation**. The app allows customization of the company name, text formatting, and chart appearance.

## 🎯 Features
- **Bar Chart & Line Graph**: Displays revenue trends over the years.
- **Company Label Customization**: Change font, size, and color.
- **Table Representation**: Neatly formatted revenue data.
- **Interactive UI**:
  - Right-click context menu for chart customizations.
  - Dynamic mouse tracking displaying coordinates and revenue data.
  - Keyboard shortcuts (`Ctrl + R/G/B`) to change line color.

## 🏗️ Project Structure
```
├── BarChart.cs             # Custom class for drawing bar charts & graphs
├── CompanyLabel.cs         # Handles drawing of the company name label
├── Form1.cs               # Main application form logic
├── Form1.Designer.cs      # Auto-generated UI components
├── LabelDialogBox.cs      # Customization dialog for company name
├── LabelDialogBox.Designer.cs # UI components for the customization dialog
├── Program.cs             # Entry point of the application
├── Table.cs               # Handles drawing of revenue data in tabular format
└── WinFormsApp.csproj      # Project configuration
```

## 🚀 Getting Started
### **1️⃣ Clone the Repository**
```sh
git clone <repository-url>
cd WinFormsApp
```
### **2️⃣ Build & Run**
- Open the solution (`.csproj`) in **Visual Studio**.
- Press `F5` to build and run the project.

## 🖥️ Usage
### **Mouse Interactions**
- **Move Mouse**: Status bar shows **X, Y coordinates** and revenue information.
- **Right Click on Bar Chart**: Opens context menu to change bar color and style.

### **Keyboard Shortcuts**
| Shortcut | Action |
|----------|--------|
| `Ctrl + R` | Change line color to Red |
| `Ctrl + G` | Change line color to Green |
| `Ctrl + B` | Change line color to Blue |

### **Menu Options**
- **Format → Company Name**: Opens a dialog to edit the company label.
- **Line & Rectangle Menus**: Modify colors, styles, and hatch effects.

## ⚙️ Customization
Modify `BarChart.cs`, `Table.cs`, or `CompanyLabel.cs` to change drawing logic.

## 📝 License
This project is licensed under the **MIT License**.

## 📩 Contact
For any questions, reach out via GitHub Issues or email.

---
📊 Built with **C# WinForms**!
