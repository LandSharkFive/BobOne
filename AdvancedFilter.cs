namespace BobOne
{

    /// <summary>
    /// A secondary filter dialog providing an interface for users 
    /// to enter specific search or filter criteria.
    /// </summary>
    public partial class AdvancedFilter : Form
    {

        /// <summary>
        /// Public property to pass the filter string between this dialog and the MainForm.
        /// </summary>
        public string FilterText
        {
            get => txtFilter.Text;
            set => txtFilter.Text = value;
        }

        public AdvancedFilter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets focus to the input field immediately upon loading the form
        /// to allow for instant typing without manual clicking.
        /// </summary>
        private void AdvancedFilter_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }

        /// <summary>
        /// Captures the current text input, sets the result to OK, and returns to the calling form.
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            this.FilterText = txtFilter.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Empties the filter text and closes the dialog, signaling a reset of the data view.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
