namespace BobOne
{
    partial class AddColumnDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            lblColName = new Label();
            txtColumnName = new TextBox();
            gbPosition = new GroupBox();
            pnlWhere = new Panel();
            rbBefore = new RadioButton();
            rbAfter = new RadioButton();
            cbColumns = new ComboBox();
            rbRelative = new RadioButton();
            rbLast = new RadioButton();
            rbFirst = new RadioButton();
            btnCancel = new Button();
            btnOk = new Button();
            gbPosition.SuspendLayout();
            pnlWhere.SuspendLayout();
            SuspendLayout();
            // 
            // lblColName
            // 
            lblColName.AutoSize = true;
            lblColName.Location = new Point(21, 22);
            lblColName.Name = "lblColName";
            lblColName.Size = new Size(124, 17);
            lblColName.TabIndex = 0;
            lblColName.Text = "New Column Name:";
            // 
            // txtColumnName
            // 
            txtColumnName.Location = new Point(151, 22);
            txtColumnName.Name = "txtColumnName";
            txtColumnName.Size = new Size(217, 25);
            txtColumnName.TabIndex = 0;
            // 
            // gbPosition
            // 
            gbPosition.Controls.Add(pnlWhere);
            gbPosition.Controls.Add(cbColumns);
            gbPosition.Controls.Add(rbRelative);
            gbPosition.Controls.Add(rbLast);
            gbPosition.Controls.Add(rbFirst);
            gbPosition.Location = new Point(21, 66);
            gbPosition.Name = "gbPosition";
            gbPosition.Size = new Size(373, 155);
            gbPosition.TabIndex = 1;
            gbPosition.TabStop = false;
            gbPosition.Text = "Position";
            // 
            // pnlWhere
            // 
            pnlWhere.Controls.Add(rbBefore);
            pnlWhere.Controls.Add(rbAfter);
            pnlWhere.Location = new Point(25, 109);
            pnlWhere.Name = "pnlWhere";
            pnlWhere.Size = new Size(289, 32);
            pnlWhere.TabIndex = 8;
            // 
            // rbBefore
            // 
            rbBefore.AutoSize = true;
            rbBefore.Location = new Point(9, 3);
            rbBefore.Name = "rbBefore";
            rbBefore.Size = new Size(64, 21);
            rbBefore.TabIndex = 6;
            rbBefore.TabStop = true;
            rbBefore.Text = "Before";
            rbBefore.UseVisualStyleBackColor = true;
            // 
            // rbAfter
            // 
            rbAfter.AutoSize = true;
            rbAfter.Location = new Point(79, 3);
            rbAfter.Name = "rbAfter";
            rbAfter.Size = new Size(54, 21);
            rbAfter.TabIndex = 7;
            rbAfter.TabStop = true;
            rbAfter.Text = "After";
            rbAfter.UseVisualStyleBackColor = true;
            // 
            // cbColumns
            // 
            cbColumns.FormattingEnabled = true;
            cbColumns.Location = new Point(104, 74);
            cbColumns.Name = "cbColumns";
            cbColumns.Size = new Size(210, 25);
            cbColumns.TabIndex = 5;
            // 
            // rbRelative
            // 
            rbRelative.AutoSize = true;
            rbRelative.Location = new Point(6, 78);
            rbRelative.Name = "rbRelative";
            rbRelative.Size = new Size(92, 21);
            rbRelative.TabIndex = 4;
            rbRelative.TabStop = true;
            rbRelative.Text = "Relative To:";
            rbRelative.UseVisualStyleBackColor = true;
            rbRelative.CheckedChanged += rbRelative_CheckedChanged;
            // 
            // rbLast
            // 
            rbLast.AutoSize = true;
            rbLast.Location = new Point(7, 51);
            rbLast.Name = "rbLast";
            rbLast.Size = new Size(97, 21);
            rbLast.TabIndex = 3;
            rbLast.TabStop = true;
            rbLast.Text = "Last Column";
            rbLast.UseVisualStyleBackColor = true;
            // 
            // rbFirst
            // 
            rbFirst.AutoSize = true;
            rbFirst.Checked = true;
            rbFirst.Location = new Point(6, 24);
            rbFirst.Name = "rbFirst";
            rbFirst.Size = new Size(98, 21);
            rbFirst.TabIndex = 2;
            rbFirst.TabStop = true;
            rbFirst.Text = "First Column";
            rbFirst.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(319, 239);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(225, 239);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 8;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // AddColumnDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(432, 285);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(gbPosition);
            Controls.Add(txtColumnName);
            Controls.Add(lblColName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddColumnDialog";
            Text = "Add Column";
            gbPosition.ResumeLayout(false);
            gbPosition.PerformLayout();
            pnlWhere.ResumeLayout(false);
            pnlWhere.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColName;
        private TextBox txtColumnName;
        private GroupBox gbPosition;
        private Button btnCancel;
        private Button btnOk;
        public ComboBox cbColumns;
        public RadioButton rbRelative;
        public RadioButton rbAfter;
        public RadioButton rbBefore;
        public RadioButton rbLast;
        public RadioButton rbFirst;
        private Panel pnlWhere;
    }
}