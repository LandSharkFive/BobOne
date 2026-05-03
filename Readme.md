
# BobOne:  Windows CSV Editor

BobOne is a lightweight, high-performance Windows application designed for effortless CSV management. It bridges the gap between simple text editors and complex spreadsheet software by providing a clean data grid paired with a powerful SQL-style filtering engine.

## Key Features

* **Editing**: Grid-based row/column manipulation and direct cell editting.
* **Sorting**: Organize your data by clicking any column header for alphabetical or numerical ordering.
* **Discovery**: Instant global search and SQL-powered filtering.
* **Maintenance**: Duplicate detection and automatic row numbering.

---

## Smart Filtering

BobOne handles data discovery in two ways. Both methods are **case-insensitive**.

### 1. Simple Filter (Global)
Perfect for quick lookups. It scans **all columns** for your text.
* *Example:* Type `George` to see every row containing that name, regardless of which column it is in.

### 2. Advanced Filter (Expression-Based)
For complex datasets, use SQL-like syntax to target specific columns.

| Goal | Expression Syntax |
| :--- | :--- |
| **Exact Match** | `[City] = 'Tokyo'` |
| **Numeric Range** | `[Price] > 1.00 AND [Price] < 5.00` |
| **Pattern Match** | `[FirstName] LIKE 'J*'` |
| **Exclusion** | `NOT [Status] = 'Closed'` |
| **List Membership**| `[ID] IN (101, 102, 105)` |

---

## 🛠 Getting Started

1.  **Load**: Click **Open** to import any standard `.csv` file.
2.  **Edit**: Double-click any cell to modify values on the fly.
3.  **Analyze**: Use the Advanced Filter dialog to run complex queries.
4.  **Export**: Click Save to commit your changes.

---

## 💻 System Requirements
* **OS**: Windows
* **Prerequisite**: .NET Framework 9.0
* **License**: MIT

---

## License
This project is licensed under the MIT License.

