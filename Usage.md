# Usage

## 1. Filtering Data

There are two primary ways to find the information you need: the Global Filter and SQL Expression Filters.

### Global Filter
The **Global Filter** is ideal for quick lookups. It scans all columns across the entire dataset for your specific text.
* **Example:** Type `George` to see every row containing that name, regardless of which column it is in.

### SQL Expression Filter
For more complex data retrieval, use the **SQL Expression Filter**. This allows you to write specific queries to isolate data based on precise criteria.

#### Syntax Rules
* **Strings:** Must be enclosed in single quotes: 'Dave'
* **Dates:** Must be enclosed in hash marks: `#2008-12-31#`
* **Columns:** Column names must be wrapped in brackets: `[Id]`
* **Case Sensitivity:** Text searches are **case-insensitive**.

#### Supported Operators
* **Logical:** `AND`, `OR`, `NOT`
* **Comparison:** `=`, `<`, `>`, `>=`, `<=`
* **Pattern Matching:** `LIKE`, `IN`

#### Functions
`AVG`, `CONTAINS`, `CONVERT`, `IIF`, `ISNULL`, `LEN`, `LIKE`, `MAX`, `MIN`, `SUM`, `SUBSTRING`, `TRIM`

#### Examples
* `[City] = 'Tokyo'`
* `[Price] > 1.00 AND [Price] < 5.00`
* `[FirstName] LIKE 'BR%'` (Finds names starting with "BR")
* `[ID] IN (101, 102, 105, 108)`

---

## 2. Managing Rows

### Editing
* Simply click a cell and make changes.

### Deleting
* Select a row or cell and hit the Delete key.

### Inserting
* Navigate to the bottom row of the grid (marked with a Star icon).
* Enter your data; the new row will automatically appear in the grid in its sorted position.

### Numbering Rows
* To automatically number rows based on the first column:
    * Click Tools > Number Rows.

---

## 3. Managing Columns

### Adding a Column
1.  Click on **Column** > **Add Column**.
2.  Enter the new column name.
3.  Select the position: **First**, **Last**, or **Relative** to another header.
4.  If relative, choose **Before** or **After** the reference column.

### Deleting a Column
1.  Select a cell within the column you wish to remove.
2.  Click **Column** > **Delete Column**.
3.  Confirm that the column name displayed in the prompt is correct before proceeding.

---

## 4. Sorting and Tools

### Sorting
* Click any **column header** to toggle between **Ascending** and **Descending** sort orders.

### Duplicate Detection
* To view duplicate rows based on the values in the first column:
    1.  Click **Filter** > **Duplicate Rows**.
    2.  **Note:** When you are finished, ensure you clear the filter to return to the full dataset.