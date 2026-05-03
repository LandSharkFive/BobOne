namespace BobOne
{

    /// <summary>
    /// A small popup dialog used to capture or clear a search filter string.
    /// </summary>
    public partial class SimpleFilter : Form
    {

        public string FilterText
        {
            get => txtFilter.Text; 
            set => txtFilter.Text = value; 
        }


        /// <summary>
        /// Gets or sets the text in the filter textbox. 
        /// This allows the parent form to pass data in or read the result out.
        /// </summary>
        public SimpleFilter()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Automatically places the cursor in the textbox as soon as the window opens.
        /// </summary>
        private void SimpleFilter_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }


        /// <summary>
        /// Confirms the current text and signals to the parent form that the user clicked 'Apply'.
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            FilterText = txtFilter.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Resets the filter text to empty and signals the parent form to refresh.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
