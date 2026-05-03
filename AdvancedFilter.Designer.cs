namespace BobOne
{
    partial class AdvancedFilter
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
            btnClear = new Button();
            btnApply = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 44);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(447, 25);
            txtFilter.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(294, 83);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(384, 83);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 3;
            label1.Text = "Filter Expression:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(164, 17);
            label2.TabIndex = 4;
            label2.Text = "Example: [State] = 'Florida'";
            // 
            // AdvancedFilter
            // 
            AcceptButton = btnApply;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(481, 126);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnApply);
            Controls.Add(btnClear);
            Controls.Add(txtFilter);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdvancedFilter";
            Text = "Advanced Filter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Button btnClear;
        private Button btnApply;
        private Label label1;
        private Label label2;
    }
}