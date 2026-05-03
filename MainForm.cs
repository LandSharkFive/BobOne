
/**
 * ===========================================================================
 * MODULE:          BobOne CSV Editor
 * AUTHOR:          Koivu
 * DATE:            2026-04-27
 * VERSION:         1.0.0
 * LICENSE:         MIT License
 * ---------------------------------------------------------------------------
 * DESCRIPTION:
 * A high-performance, lightweight Windows-based CSV editor utilizing a 
 * virtualized data grid for efficient large-file manipulation.
 *
 * KEY FEATURES:
 * - File I/O:      Open and Save files.
 * - CRUD:          In-place editing, row insertion, and deletion.
 * - Data Sorting:  Header-triggered multi-type column sorting.
 * - Simple Filter: Global cross-column string matching using LIKE operators.
 * - Advanced:      Complex predicate filtering with support for logical 
 * operators (AND, OR, NOT) and SQL-style syntax.
 * ===========================================================================
 */


using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Windows.Forms;

namespace BobOne
{
    public partial class MainForm : Form
    {
        // Stores the current text used to filter the data display.
        private string FilterText { get; set; }

        // The central data structure holding the CSV content in memory.
        private DataTable CsvTable = new DataTable();

        // A set of numeric types.
        private HashSet<Type> NumericTypes = new HashSet<Type> { typeof(int), typeof(double), typeof(decimal), typeof(long) };


        public MainForm()
        {
            InitializeComponent();
            this.Text = "CSV Editor";
            BindTable(CsvTable);
            CsvTable.CaseSensitive = false;
        }


        /// <summary>
        /// Connects a DataTable to the DataGridView and refreshes the layout.
        /// </summary>
        private void BindTable(DataTable dt)
        {
            dgData.DataSource = null;
            dgData.DataSource = dt;
            dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        /// <summary>
        /// Event handler for the "Open" menu item. 
        /// Opens a file dialog to select a CSV and loads it into the application.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "CSV Files|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CsvTable = SmartLoadCSV(ofd.FileName);

                        if (CsvTable != null)
                        {
                            BindTable(CsvTable);
                            ShowStatus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading CSV: {ex.Message}");
                    }
                }
            }
        }


        /// <summary>
        /// Reads a CSV file, automatically detects data types (Numeric, Date, or String),
        /// and returns a populated DataTable.
        /// </summary>
        public DataTable SmartLoadCSV(string filePath)
        {
            DataTable dt = new DataTable();
            dt.CaseSensitive = false;

            // Use this list to store the raw data while we figure out the data types.
            List<string[]> allLines = new List<string[]>();
            string[] headers;

            // 1. LOAD ROWS.
            using (TextFieldParser parser = new TextFieldParser(filePath, System.Text.Encoding.UTF8, true))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                headers = parser.ReadFields();
                if (headers == null) return null;

                while (!parser.EndOfData)
                {
                    allLines.Add(parser.ReadFields());
                }
            }

            // 2. SMART SCAN: Check first row for data types.
            int colCount = headers.Length;
            Type[] detectedType = new Type[colCount];

            // 3. Default all columns to string.
            for (int i = 0; i < colCount; i++)
                detectedType[i] = typeof(string);

            string[] field = allLines[0];
            for (int i = 0; i < headers.Length; i++)
            {
                if (i < field.Length && !string.IsNullOrWhiteSpace(field[i]))
                {
                    if (double.TryParse(field[i], out double temp))
                    {
                        detectedType[i] = typeof(double);
                    }
                    else if (DateTime.TryParse(field[i], out DateTime dtTemp))
                    {
                        detectedType[i] = typeof(DateTime);
                    }
                }
            }

            // 4. BUILD SCHEMA: Add typed columns to DataTable
            for (int i = 0; i < headers.Length; i++)
            {
                dt.Columns.Add(headers[i].Trim(), detectedType[i]);
            }

            // 5. FILL TABLE: Convert data to the correct types.
            foreach (string[] fields in allLines)
            {
                object[] rowValues = new object[headers.Length];
                for (int i = 0; i < headers.Length; i++)
                {
                    if (i >= fields.Length)
                    {
                        rowValues[i] = DBNull.Value;
                        continue;
                    }

                    // Trim the value and convert based on the detected type.
                    string val = fields[i].Trim();
                    if (detectedType[i] == typeof(double))
                        rowValues[i] = double.TryParse(val, out double d) ? d : (object)DBNull.Value;
                    else if (detectedType[i] == typeof(DateTime))
                        rowValues[i] = DateTime.TryParse(val, out DateTime dtVal) ? dtVal : (object)DBNull.Value;
                    else
                        rowValues[i] = val;
                }
                dt.Rows.Add(rowValues);
            }

            return dt;
        }


        /// <summary>
        /// Event handler for the "Save" menu item.
        /// Validates data, prompts for a file location, and writes the DataGridView content to a CSV.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgData.Rows.Count == 0 || dgData.Columns.Count == 0)
            {
                MessageBox.Show("No data to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save CSV File";
            dgData.EndEdit();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // 1. Write the Headers
                        string[] columnNames = CsvTable.Columns.Cast<DataColumn>()
                                            .Select(column => column.ColumnName).ToArray();
                        sw.WriteLine(string.Join(",", columnNames));

                        // 2. Write the Rows
                        foreach (DataRow row in CsvTable.Rows)
                        {
                            string[] fields = row.ItemArray.Select(c => EscapeCSV(c?.ToString() ?? "")).ToArray();
                            sw.WriteLine(string.Join(",", fields));
                        }
                    }
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Prepares a string value for CSV output by escaping special characters.
        /// If the value contains commas, quotes, or line breaks, it is enclosed in quotes 
        /// and internal double-quotes are doubled.
        /// </summary>
        private string EscapeCSV(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            // If it contains a comma, quote, or newline, wrap it in quotes and escape existing quotes
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
            {
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }
            return value;
        }


        /// <summary>
        /// Event handler for the "Clear" menu item.
        /// Clears the current CSV data and updates the display.
        /// </summary>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsvTable.Rows.Clear();
            CsvTable.Columns.Clear();
            dgData.DataSource = null;
            ShowStatus();
        }

        /// <summary>
        /// Event handler for the "Exit" menu item.
        /// Closes the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Applies a simple filter to the DataGridView based on the provided search text.
        /// </summary>
        private void ApplySimpleFilter(string searchText)
        {
            DataTable dt = (DataTable)dgData.DataSource;
            if (dt == null) return;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            // Escape special characters to prevent crashes.
            string safeSearchText = searchText.Replace("'", "''");
            List<string> filterParts = new List<string>();

            foreach (DataColumn col in dt.Columns)
            {
                Type actualType = Nullable.GetUnderlyingType(col.DataType) ?? col.DataType;

                // We can only use LIKE on string columns.
                if (col.DataType == typeof(string))
                {
                    filterParts.Add($"[{col.ColumnName}] LIKE '%{safeSearchText}%'");
                }
                else if (col.DataType == typeof(DateTime) || NumericTypes.Contains(actualType))
                {
                    // Both Dates and Numbers need conversion to string for the LIKE operation.
                    filterParts.Add($"Convert([{col.ColumnName}], 'System.String') LIKE '%{safeSearchText}%'");
                }
            }

            try
            {
                dt.DefaultView.RowFilter = string.Join(" OR ", filterParts);
            }
            catch (Exception ex)
            {
                // Handle syntax errors gracefully.
                Console.WriteLine("Syntax Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the "Filter" menu item.
        /// Opens the simple filter dialog and applies the filter to the DataGridView.
        /// </summary>
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SimpleFilter dlg = new SimpleFilter())
            {
                dlg.FilterText = FilterText;

                // This stops the main form until the user closes the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FilterText = dlg.FilterText;

                    // Use the same global filter method we wrote earlier!
                    ApplySimpleFilter(FilterText);
                    ShowStatus();
                }
            }
        }


        /// <summary>
        /// Updates the status label to show the current number of rows displayed after filtering.
        /// </summary>
        private void ShowStatus()
        {
            int count = CsvTable.DefaultView.Count;
            ssLabel.Text = $"{count} rows";
        }


        /// <summary>
        /// Event handler for the "About" menu item.
        /// Displays information about the application.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSV Editor v1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Event handler for the "Advanced Filter" menu item.
        /// Opens the advanced filter dialog and applies the filter to the DataGridView.
        /// </summary>
        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AdvancedFilter dlg = new AdvancedFilter())
            {
                dlg.FilterText = FilterText;

                // This stops the main form until the user closes the dialog
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FilterText = dlg.FilterText;
                        CsvTable.DefaultView.RowFilter = dlg.FilterText;
                        ShowStatus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Syntax Error: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Identifies and displays only the rows that contain duplicate values in the primary column.
        /// This acts as a quality-control filter, allowing the user to manually resolve 
        /// data integrity issues or primary key violations.
        /// </summary>
        private void ShowDuplicateRows()
        {
            if (CsvTable.Rows.Count == 0) return;

            // We assume the first column (index 0) is the ID or unique key
            string colName = CsvTable.Columns[0].ColumnName;

            // 1. Find the values that appear more than once
            var duplicateIds = CsvTable.AsEnumerable()
                .GroupBy(row => row[0])
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);

            // 2. Create a RowFilter string: "[ColumnName] IN ('ID1', 'ID2', ...)"
            if (duplicateIds.Any())
            {
                // Format based on type (wrap in quotes if string, no quotes if numeric)
                bool isString = CsvTable.Columns[0].DataType == typeof(string);
                string formattedIds = isString
                    ? string.Join("','", duplicateIds).Insert(0, "'") + "'"
                    : string.Join(",", duplicateIds);

                CsvTable.DefaultView.RowFilter = $"[{colName}] IN ({formattedIds})";
            }
            else
            {
                MessageBox.Show("No duplicate values found in the first column.", "Clean Data");
            }

            ShowStatus();
        }


        /// <summary>
        /// Event handler for the "Show Duplicates" menu item.
        /// </summary>  
        private void showDuplicatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDuplicateRows();
        }


        /// <summary>
        /// Event handler for the "Clear Filter" menu item.
        /// </summary>
        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resetting the RowFilter to an empty string shows all data
            CsvTable.DefaultView.RowFilter = string.Empty;

            // Clear the stored filter text so the "Simple Filter" dialog resets too
            FilterText = string.Empty;

            ShowStatus();
        }


        /// <summary>
        /// Event handler for the "Renumber" menu item.
        /// </summary>
        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CsvTable.Rows.Count == 0) return;

            // Confirmation prevents accidental overwriting of existing IDs
            var result = MessageBox.Show("This will overwrite all values in the first column with integers from 1 to N. Continue?",
                                         "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Disable UI updates for speed during bulk edit
                dgData.DataSource = null;

                for (int i = 0; i < CsvTable.Rows.Count; i++)
                {
                    CsvTable.Rows[i][0] = i + 1;
                }

                // Rebind and refresh
                BindTable(CsvTable);
            }
        }

        /// <summary>
        /// Event handler for the "Add Column" menu item.
        /// </summary>
        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddColumnDialog())
            {
                // 1. Pre-fill the dropdown with current column names
                foreach (DataGridViewColumn col in dgData.Columns)
                    dialog.cbColumns.Items.Add(col.HeaderText);

                // 2. Set default selection to the first column for convenience.
                if (dialog.cbColumns.Items.Count > 0)
                    dialog.cbColumns.SelectedIndex = 0; 

                // 3. Show the dialog and check if OK was clicked
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int index = dialog.GetTargetIndex(dgData.ColumnCount);
                    string name = dialog.NewColumnName;
                    TryAddColumn(CsvTable, name, index);
                }
            }
        }

        /// <summary>
        /// Validates and adds a new column to the DataTable at a specific position.
        /// </summary>
        public void TryAddColumn(DataTable csvData, string columnName, int targetIndex)
        {
            // 1. Validate the column name.
            if (string.IsNullOrWhiteSpace(columnName))
            {
                return;
            }

            // 2. Check for duplicates.
            if (csvData.Columns.Contains(columnName))
            {
                MessageBox.Show($"The column name already exists.", "Duplicate Column",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create and add the column
            DataColumn newCol = csvData.Columns.Add(columnName, typeof(string));

            // 4. Handle column position.
            newCol.SetOrdinal(targetIndex);

            BindTable(csvData);
        }


        /// <summary>
        /// Event handler for the "Delete Column" menu item.
        /// </summary>
        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Check if a cell is actually selected
            if (dgData.CurrentCell == null)
            {
                MessageBox.Show("Please select a cell in the column you wish to delete.");
                return;
            }

            // 2. Get the column index and name
            int columnIndex = dgData.CurrentCell.ColumnIndex;
            string columnName = dgData.Columns[columnIndex].Name;

            // 3. Always ask for confirmation (Deleting data is permanent!)
            var result = MessageBox.Show($"Are you sure you want to delete the column '{columnName}'?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            // 4. If the user confirms, proceed with deletion.
            if (result == DialogResult.Yes)
            {
                try
                {
                    // 4. Remove from the DataTable.
                    if (CsvTable.Columns.Contains(columnName))
                    {
                        CsvTable.Columns.Remove(columnName);
                    }

                    // 5. Refresh the UI
                    dgData.DataSource = null;
                    dgData.DataSource = CsvTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}

