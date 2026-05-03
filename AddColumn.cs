namespace BobOne
{

    public partial class AddColumnDialog : Form
    {
        public string NewColumnName => txtColumnName.Text;

        /// <summary>
        /// Initializes a new instance of the AddColumnDialog.
        /// Sets the default UI state for column positioning.
        /// </summary>
        public AddColumnDialog()
        {
            InitializeComponent();
            rbRelative.Checked = false; 
        }

        /// <summary>
        /// Handles final UI tweaks when the form is first displayed.
        /// </summary>
        private void AddColumnDialog_Load(object sender, EventArgs e)
        {
            rbFirst.Checked = true;
            txtColumnName.Focus();
        }

        /// <summary>
        /// Toggle the availability of relative positioning controls 
        /// based on whether the 'Relative To' radio button is selected.
        /// </summary>
        private void rbRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRelative.Checked)
            {
                cbColumns.Enabled = true;
                rbBefore.Enabled = true;
                rbAfter.Enabled = true;

            }
            else
            {
                cbColumns.Enabled = false;
                rbBefore.Enabled = false;
                rbAfter.Enabled = false;
            }
        }

        /// <summary>
        /// Calculates the numerical index where the new column should be inserted
        /// based on the user's radio button and dropdown selections.
        /// </summary>
        public int GetTargetIndex(int colCount)
        {
            if (rbFirst.Checked) return 0;
            if (rbLast.Checked) return colCount;

            int selectedIndex = cbColumns.SelectedIndex;

            // Fallback if nothing is selected.
            if (selectedIndex == -1) return 0;

            return rbAfter.Checked ? selectedIndex + 1 : selectedIndex;
        }

        /// <summary>
        /// Validates the user input and determines if the dialog should close.
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColumnName.Text))
            {
                MessageBox.Show("Please enter a name for the new column.", "Missing Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtColumnName.Focus(); 
                this.DialogResult = DialogResult.None; 
                return;
            }

            // If it's not empty, the dialog will close with DialogResult.OK
            this.DialogResult = DialogResult.OK;
        }
    }
}
