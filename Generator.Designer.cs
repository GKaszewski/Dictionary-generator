namespace Dictionary_Generator
{
    partial class GeneratorWindow
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportJSONDialog = new System.Windows.Forms.SaveFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.jsonDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.csvDataGrid = new System.Windows.Forms.DataGridView();
            this.jsonTab = new System.Windows.Forms.TabControl();
            this.menu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jsonDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).BeginInit();
            this.jsonTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "JSON file|*.json|CSV file|*.csv";
            // 
            // exportJSONDialog
            // 
            this.exportJSONDialog.DefaultExt = "json";
            this.exportJSONDialog.Filter = "JSON file|*.json";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToJSONToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exportToJSONToolStripMenuItem
            // 
            this.exportToJSONToolStripMenuItem.Name = "exportToJSONToolStripMenuItem";
            this.exportToJSONToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToJSONToolStripMenuItem.Text = "Export to JSON";
            this.exportToJSONToolStripMenuItem.Click += new System.EventHandler(this.ExportToJSONToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePathToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changePathToolStripMenuItem
            // 
            this.changePathToolStripMenuItem.Name = "changePathToolStripMenuItem";
            this.changePathToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changePathToolStripMenuItem.Text = "Change path...";
            this.changePathToolStripMenuItem.Click += new System.EventHandler(this.ChangePathToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.jsonDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JSON View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // jsonDataGrid
            // 
            this.jsonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jsonDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonDataGrid.Location = new System.Drawing.Point(3, 3);
            this.jsonDataGrid.Name = "jsonDataGrid";
            this.jsonDataGrid.Size = new System.Drawing.Size(774, 379);
            this.jsonDataGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.csvDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CSV View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // csvDataGrid
            // 
            this.csvDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.csvDataGrid.Location = new System.Drawing.Point(3, 3);
            this.csvDataGrid.Name = "csvDataGrid";
            this.csvDataGrid.Size = new System.Drawing.Size(240, 379);
            this.csvDataGrid.TabIndex = 0;
            // 
            // jsonTab
            // 
            this.jsonTab.Controls.Add(this.tabPage1);
            this.jsonTab.Controls.Add(this.tabPage3);
            this.jsonTab.Location = new System.Drawing.Point(0, 27);
            this.jsonTab.Name = "jsonTab";
            this.jsonTab.SelectedIndex = 0;
            this.jsonTab.Size = new System.Drawing.Size(788, 411);
            this.jsonTab.TabIndex = 6;
            // 
            // GeneratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jsonTab);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "GeneratorWindow";
            this.Text = "Dictionary Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratorWindow_FormClosed);
            this.Load += new System.EventHandler(this.GeneratorWindow_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jsonDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.csvDataGrid)).EndInit();
            this.jsonTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog exportJSONDialog;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePathToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView jsonDataGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView csvDataGrid;
        private System.Windows.Forms.TabControl jsonTab;
    }
}

