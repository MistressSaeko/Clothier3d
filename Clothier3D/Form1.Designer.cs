namespace Clothier3D
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.savePatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePatternAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SceneView = new OpenTK.GLControl();
            this.PatternView = new OpenTK.GLControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StopStartSimButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LibraryTab = new System.Windows.Forms.TabPage();
            this.BlocksTab = new System.Windows.Forms.TabPage();
            this.PropertyEditor = new System.Windows.Forms.PropertyGrid();
            this.ItemList = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatternToolStripMenuItem,
            this.openPatternToolStripMenuItem,
            this.toolStripSeparator3,
            this.savePatternToolStripMenuItem,
            this.savePatternAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.importPatternToolStripMenuItem,
            this.exportPatternToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPatternToolStripMenuItem
            // 
            this.newPatternToolStripMenuItem.Name = "newPatternToolStripMenuItem";
            this.newPatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newPatternToolStripMenuItem.Text = "New Pattern";
            // 
            // openPatternToolStripMenuItem
            // 
            this.openPatternToolStripMenuItem.Name = "openPatternToolStripMenuItem";
            this.openPatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openPatternToolStripMenuItem.Text = "Open Pattern";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // savePatternToolStripMenuItem
            // 
            this.savePatternToolStripMenuItem.Name = "savePatternToolStripMenuItem";
            this.savePatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.savePatternToolStripMenuItem.Text = "Save Pattern";
            // 
            // savePatternAsToolStripMenuItem
            // 
            this.savePatternAsToolStripMenuItem.Name = "savePatternAsToolStripMenuItem";
            this.savePatternAsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.savePatternAsToolStripMenuItem.Text = "Save Pattern As..";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importToolStripMenuItem.Text = "Import Mannequin";
            // 
            // importPatternToolStripMenuItem
            // 
            this.importPatternToolStripMenuItem.Name = "importPatternToolStripMenuItem";
            this.importPatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importPatternToolStripMenuItem.Text = "Import Pattern";
            // 
            // exportPatternToolStripMenuItem
            // 
            this.exportPatternToolStripMenuItem.Name = "exportPatternToolStripMenuItem";
            this.exportPatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportPatternToolStripMenuItem.Text = "Export Pattern";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportToolStripMenuItem.Text = "Export Cloth";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(508, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(508, 19);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 18);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.66772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.56962F));
            this.tableLayoutPanel1.Controls.Add(this.SceneView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatternView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PropertyEditor, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemList, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.416404F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.95899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.78233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 634);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SceneView
            // 
            this.SceneView.BackColor = System.Drawing.Color.Black;
            this.SceneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneView.Location = new System.Drawing.Point(259, 30);
            this.SceneView.Name = "SceneView";
            this.tableLayoutPanel1.SetRowSpan(this.SceneView, 2);
            this.SceneView.Size = new System.Drawing.Size(367, 601);
            this.SceneView.TabIndex = 0;
            this.SceneView.VSync = false;
            this.SceneView.Load += new System.EventHandler(this.SceneView_Load);
            this.SceneView.Paint += new System.Windows.Forms.PaintEventHandler(this.SceneView_Paint);
            this.SceneView.Resize += new System.EventHandler(this.SceneView_Resize);
            // 
            // PatternView
            // 
            this.PatternView.BackColor = System.Drawing.Color.Black;
            this.PatternView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatternView.Location = new System.Drawing.Point(632, 30);
            this.PatternView.Name = "PatternView";
            this.tableLayoutPanel1.SetRowSpan(this.PatternView, 2);
            this.PatternView.Size = new System.Drawing.Size(368, 601);
            this.PatternView.TabIndex = 1;
            this.PatternView.VSync = false;
            this.PatternView.Load += new System.EventHandler(this.PatternView_Load);
            this.PatternView.Paint += new System.Windows.Forms.PaintEventHandler(this.PatternView_Paint);
            this.PatternView.Resize += new System.EventHandler(this.PatternView_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopStartSimButton});
            this.toolStrip1.Location = new System.Drawing.Point(256, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(373, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StopStartSimButton
            // 
            this.StopStartSimButton.CheckOnClick = true;
            this.StopStartSimButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopStartSimButton.Image = ((System.Drawing.Image)(resources.GetObject("StopStartSimButton.Image")));
            this.StopStartSimButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopStartSimButton.Name = "StopStartSimButton";
            this.StopStartSimButton.Size = new System.Drawing.Size(23, 22);
            this.StopStartSimButton.Text = "StartStopSimButton";
            this.StopStartSimButton.ToolTipText = "Start/Stop Simulation";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Location = new System.Drawing.Point(629, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(374, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LibraryTab);
            this.tabControl1.Controls.Add(this.BlocksTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl1, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 628);
            this.tabControl1.TabIndex = 4;
            // 
            // LibraryTab
            // 
            this.LibraryTab.Location = new System.Drawing.Point(4, 22);
            this.LibraryTab.Name = "LibraryTab";
            this.LibraryTab.Padding = new System.Windows.Forms.Padding(3);
            this.LibraryTab.Size = new System.Drawing.Size(242, 602);
            this.LibraryTab.TabIndex = 0;
            this.LibraryTab.Text = "Library";
            this.LibraryTab.UseVisualStyleBackColor = true;
            // 
            // BlocksTab
            // 
            this.BlocksTab.Location = new System.Drawing.Point(4, 22);
            this.BlocksTab.Name = "BlocksTab";
            this.BlocksTab.Padding = new System.Windows.Forms.Padding(3);
            this.BlocksTab.Size = new System.Drawing.Size(242, 602);
            this.BlocksTab.TabIndex = 1;
            this.BlocksTab.Text = "Clothing Parts";
            this.BlocksTab.UseVisualStyleBackColor = true;
            // 
            // PropertyEditor
            // 
            this.PropertyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyEditor.Location = new System.Drawing.Point(1006, 276);
            this.PropertyEditor.Name = "PropertyEditor";
            this.PropertyEditor.Size = new System.Drawing.Size(255, 355);
            this.PropertyEditor.TabIndex = 5;
            // 
            // ItemList
            // 
            this.ItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemList.Location = new System.Drawing.Point(1006, 3);
            this.ItemList.Name = "ItemList";
            this.tableLayoutPanel1.SetRowSpan(this.ItemList, 2);
            this.ItemList.Size = new System.Drawing.Size(255, 267);
            this.ItemList.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Clothier3D";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePatternAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OpenTK.GLControl SceneView;
        private OpenTK.GLControl PatternView;
        private System.Windows.Forms.ToolStripMenuItem newPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem importPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LibraryTab;
        private System.Windows.Forms.TabPage BlocksTab;
        private System.Windows.Forms.PropertyGrid PropertyEditor;
        private System.Windows.Forms.TreeView ItemList;
        private System.Windows.Forms.ToolStripButton StopStartSimButton;
    }
}

