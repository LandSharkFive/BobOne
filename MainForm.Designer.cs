namespace BobOne
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clearToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            columnTtoolStripMenuItem = new ToolStripMenuItem();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            deleteColumnToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            advancedToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            showDuplicatesToolStripMenuItem = new ToolStripMenuItem();
            clearFilterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            numberToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            ssStatus = new StatusStrip();
            ssLabel = new ToolStripStatusLabel();
            panel1 = new Panel();
            dgData = new DataGridView();
            msMain.SuspendLayout();
            ssStatus.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, columnTtoolStripMenuItem, filterToolStripMenuItem, toolStripMenuItem1, helpToolStripMenuItem1 });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(800, 25);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, clearToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(108, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(108, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(105, 6);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(108, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(105, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(108, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // columnTtoolStripMenuItem
            // 
            columnTtoolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addColumnToolStripMenuItem, deleteColumnToolStripMenuItem });
            columnTtoolStripMenuItem.Name = "columnTtoolStripMenuItem";
            columnTtoolStripMenuItem.Size = new Size(64, 21);
            columnTtoolStripMenuItem.Text = "Column";
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(180, 22);
            addColumnToolStripMenuItem.Text = "Add Column";
            addColumnToolStripMenuItem.Click += addColumnToolStripMenuItem_Click;
            // 
            // deleteColumnToolStripMenuItem
            // 
            deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            deleteColumnToolStripMenuItem.Size = new Size(180, 22);
            deleteColumnToolStripMenuItem.Text = "Delete Column";
            deleteColumnToolStripMenuItem.Click += deleteColumnToolStripMenuItem_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem1, advancedToolStripMenuItem, toolStripSeparator3, showDuplicatesToolStripMenuItem, clearFilterToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(48, 21);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(165, 22);
            searchToolStripMenuItem1.Text = "Simple";
            searchToolStripMenuItem1.Click += filterToolStripMenuItem_Click;
            // 
            // advancedToolStripMenuItem
            // 
            advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            advancedToolStripMenuItem.Size = new Size(165, 22);
            advancedToolStripMenuItem.Text = "Advanced";
            advancedToolStripMenuItem.Click += advancedToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(162, 6);
            // 
            // showDuplicatesToolStripMenuItem
            // 
            showDuplicatesToolStripMenuItem.Name = "showDuplicatesToolStripMenuItem";
            showDuplicatesToolStripMenuItem.Size = new Size(165, 22);
            showDuplicatesToolStripMenuItem.Text = "Duplicate Rows";
            showDuplicatesToolStripMenuItem.Click += showDuplicatesToolStripMenuItem_Click;
            // 
            // clearFilterToolStripMenuItem
            // 
            clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            clearFilterToolStripMenuItem.Size = new Size(165, 22);
            clearFilterToolStripMenuItem.Text = "Clear Filter";
            clearFilterToolStripMenuItem.Click += clearFilterToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { numberToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(51, 21);
            toolStripMenuItem1.Text = "Tools";
            // 
            // numberToolStripMenuItem
            // 
            numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            numberToolStripMenuItem.Size = new Size(159, 22);
            numberToolStripMenuItem.Text = "Number Rows";
            numberToolStripMenuItem.Click += numberToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(47, 21);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(111, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(32, 19);
            // 
            // ssStatus
            // 
            ssStatus.Items.AddRange(new ToolStripItem[] { ssLabel });
            ssStatus.Location = new Point(0, 428);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(800, 22);
            ssStatus.TabIndex = 1;
            ssStatus.Text = "statusStrip1";
            // 
            // ssLabel
            // 
            ssLabel.Name = "ssLabel";
            ssLabel.Size = new Size(0, 17);
            // 
            // panel1
            // 
            panel1.Controls.Add(dgData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 403);
            panel1.TabIndex = 4;
            // 
            // dgData
            // 
            dgData.BorderStyle = BorderStyle.None;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Dock = DockStyle.Fill;
            dgData.Location = new Point(0, 0);
            dgData.Margin = new Padding(0);
            dgData.Name = "dgData";
            dgData.Size = new Size(800, 403);
            dgData.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(ssStatus);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "MainForm";
            Text = "CSV Editor";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private StatusStrip ssStatus;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Panel panel1;
        private DataGridView dgData;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripStatusLabel ssLabel;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem advancedToolStripMenuItem;
        private ToolStripMenuItem showDuplicatesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem clearFilterToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem numberToolStripMenuItem;
        private ToolStripMenuItem columnTtoolStripMenuItem;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem deleteColumnToolStripMenuItem;
    }
}
