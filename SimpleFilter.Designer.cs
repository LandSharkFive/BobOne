namespace BobOne
{
    partial class SimpleFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFilter = new TextBox();
            btnApply = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 40);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(361, 25);
            txtFilter.TabIndex = 0;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(298, 83);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(210, 83);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 4;
            label1.Text = "Search For:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 5;
            label2.Text = "Example:  Chicago";
            // 
            // SimpleFilter
            // 
            AcceptButton = btnApply;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 136);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnApply);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SimpleFilter";
            Text = "Simple Filter";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Button btnApply;
        private Button btnClear;
        private Label label1;
        private Label label2;
    }
}