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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePatternAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closePatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ActivateToolButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SceneView = new OpenTK.GLControl();
            this.PatternView = new OpenTK.GLControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ClothSettingsGroup = new System.Windows.Forms.GroupBox();
            this.MassLabel = new System.Windows.Forms.Label();
            this.ClothChooser = new System.Windows.Forms.ComboBox();
            this.MassSlider = new System.Windows.Forms.TrackBar();
            this.MassNumeric = new System.Windows.Forms.NumericUpDown();
            this.StructureLabel = new System.Windows.Forms.Label();
            this.StructureSlider = new System.Windows.Forms.TrackBar();
            this.StructureNumeric = new System.Windows.Forms.NumericUpDown();
            this.BendingLabel = new System.Windows.Forms.Label();
            this.BendingSlider = new System.Windows.Forms.TrackBar();
            this.BendingNumeric = new System.Windows.Forms.NumericUpDown();
            this.SpringLabel = new System.Windows.Forms.Label();
            this.SpringNumeric = new System.Windows.Forms.NumericUpDown();
            this.AirNumeric = new System.Windows.Forms.NumericUpDown();
            this.SpringSlider = new System.Windows.Forms.TrackBar();
            this.VelocityNumeric = new System.Windows.Forms.NumericUpDown();
            this.AirLabel = new System.Windows.Forms.Label();
            this.AirSlider = new System.Windows.Forms.TrackBar();
            this.VelocitySlider = new System.Windows.Forms.TrackBar();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.TopoGroup = new System.Windows.Forms.GroupBox();
            this.QuadRadio = new System.Windows.Forms.RadioButton();
            this.TriRadio = new System.Windows.Forms.RadioButton();
            this.TextureGroup = new System.Windows.Forms.GroupBox();
            this.DiffuseLabel = new System.Windows.Forms.Label();
            this.DiffuseEdit = new System.Windows.Forms.TextBox();
            this.DiffuseSelect = new System.Windows.Forms.Button();
            this.NormalEdit = new System.Windows.Forms.TextBox();
            this.SpecularEdit = new System.Windows.Forms.TextBox();
            this.GlossEdit = new System.Windows.Forms.TextBox();
            this.NormalSelect = new System.Windows.Forms.Button();
            this.SpecularSelect = new System.Windows.Forms.Button();
            this.GlossSelect = new System.Windows.Forms.Button();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.SpecularLabel = new System.Windows.Forms.Label();
            this.GlossLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ClothSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BendingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BendingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocitySlider)).BeginInit();
            this.TopoGroup.SuspendLayout();
            this.TextureGroup.SuspendLayout();
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
            this.openPatternToolStripMenuItem,
            this.savePatternToolStripMenuItem,
            this.savePatternAsToolStripMenuItem,
            this.closePatternToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openPatternToolStripMenuItem
            // 
            this.openPatternToolStripMenuItem.Name = "openPatternToolStripMenuItem";
            this.openPatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openPatternToolStripMenuItem.Text = "Open Pattern";
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
            // closePatternToolStripMenuItem
            // 
            this.closePatternToolStripMenuItem.Name = "closePatternToolStripMenuItem";
            this.closePatternToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closePatternToolStripMenuItem.Text = "Close Pattern";
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
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActivateToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1264, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ActivateToolButton
            // 
            this.ActivateToolButton.CheckOnClick = true;
            this.ActivateToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActivateToolButton.Image = global::Clothier3D.Properties.Resources.start;
            this.ActivateToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActivateToolButton.Name = "ActivateToolButton";
            this.ActivateToolButton.Size = new System.Drawing.Size(36, 36);
            this.ActivateToolButton.Text = "toolStripButton1";
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(523, 19);
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(523, 19);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.77215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.92089F));
            this.tableLayoutPanel1.Controls.Add(this.SceneView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PatternView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 426F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 595);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SceneView
            // 
            this.SceneView.BackColor = System.Drawing.Color.Black;
            this.SceneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneView.Location = new System.Drawing.Point(3, 3);
            this.SceneView.Name = "SceneView";
            this.SceneView.Size = new System.Drawing.Size(415, 589);
            this.SceneView.TabIndex = 0;
            this.SceneView.VSync = false;
            // 
            // PatternView
            // 
            this.PatternView.BackColor = System.Drawing.Color.Black;
            this.PatternView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatternView.Location = new System.Drawing.Point(424, 3);
            this.PatternView.Name = "PatternView";
            this.PatternView.Size = new System.Drawing.Size(521, 589);
            this.PatternView.TabIndex = 1;
            this.PatternView.VSync = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ClothSettingsGroup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TopoGroup, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TextureGroup, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(951, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.99321F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.22411F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78268F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 589);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ClothSettingsGroup
            // 
            this.ClothSettingsGroup.Controls.Add(this.VelocityLabel);
            this.ClothSettingsGroup.Controls.Add(this.VelocitySlider);
            this.ClothSettingsGroup.Controls.Add(this.AirSlider);
            this.ClothSettingsGroup.Controls.Add(this.AirLabel);
            this.ClothSettingsGroup.Controls.Add(this.VelocityNumeric);
            this.ClothSettingsGroup.Controls.Add(this.SpringSlider);
            this.ClothSettingsGroup.Controls.Add(this.AirNumeric);
            this.ClothSettingsGroup.Controls.Add(this.SpringNumeric);
            this.ClothSettingsGroup.Controls.Add(this.SpringLabel);
            this.ClothSettingsGroup.Controls.Add(this.BendingNumeric);
            this.ClothSettingsGroup.Controls.Add(this.BendingSlider);
            this.ClothSettingsGroup.Controls.Add(this.BendingLabel);
            this.ClothSettingsGroup.Controls.Add(this.StructureNumeric);
            this.ClothSettingsGroup.Controls.Add(this.StructureSlider);
            this.ClothSettingsGroup.Controls.Add(this.StructureLabel);
            this.ClothSettingsGroup.Controls.Add(this.MassNumeric);
            this.ClothSettingsGroup.Controls.Add(this.MassSlider);
            this.ClothSettingsGroup.Controls.Add(this.MassLabel);
            this.ClothSettingsGroup.Controls.Add(this.ClothChooser);
            this.ClothSettingsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClothSettingsGroup.Location = new System.Drawing.Point(3, 3);
            this.ClothSettingsGroup.Name = "ClothSettingsGroup";
            this.ClothSettingsGroup.Size = new System.Drawing.Size(304, 206);
            this.ClothSettingsGroup.TabIndex = 0;
            this.ClothSettingsGroup.TabStop = false;
            this.ClothSettingsGroup.Text = "Cloth Settings";
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(21, 52);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(35, 13);
            this.MassLabel.TabIndex = 1;
            this.MassLabel.Text = "Mass:";
            // 
            // ClothChooser
            // 
            this.ClothChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClothChooser.FormattingEnabled = true;
            this.ClothChooser.Items.AddRange(new object[] {
            "Cotton",
            "Denim",
            "Leather",
            "Silk",
            "Wool"});
            this.ClothChooser.Location = new System.Drawing.Point(6, 19);
            this.ClothChooser.Name = "ClothChooser";
            this.ClothChooser.Size = new System.Drawing.Size(140, 21);
            this.ClothChooser.TabIndex = 0;
            // 
            // MassSlider
            // 
            this.MassSlider.AutoSize = false;
            this.MassSlider.Location = new System.Drawing.Point(62, 50);
            this.MassSlider.Name = "MassSlider";
            this.MassSlider.Size = new System.Drawing.Size(134, 20);
            this.MassSlider.TabIndex = 2;
            this.MassSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // MassNumeric
            // 
            this.MassNumeric.DecimalPlaces = 3;
            this.MassNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MassNumeric.Location = new System.Drawing.Point(202, 50);
            this.MassNumeric.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.MassNumeric.Name = "MassNumeric";
            this.MassNumeric.Size = new System.Drawing.Size(96, 20);
            this.MassNumeric.TabIndex = 3;
            // 
            // StructureLabel
            // 
            this.StructureLabel.AutoSize = true;
            this.StructureLabel.Location = new System.Drawing.Point(3, 78);
            this.StructureLabel.Name = "StructureLabel";
            this.StructureLabel.Size = new System.Drawing.Size(53, 13);
            this.StructureLabel.TabIndex = 4;
            this.StructureLabel.Text = "Structure:";
            // 
            // StructureSlider
            // 
            this.StructureSlider.AutoSize = false;
            this.StructureSlider.Location = new System.Drawing.Point(62, 76);
            this.StructureSlider.Name = "StructureSlider";
            this.StructureSlider.Size = new System.Drawing.Size(134, 20);
            this.StructureSlider.TabIndex = 5;
            this.StructureSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // StructureNumeric
            // 
            this.StructureNumeric.DecimalPlaces = 3;
            this.StructureNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StructureNumeric.Location = new System.Drawing.Point(202, 76);
            this.StructureNumeric.Name = "StructureNumeric";
            this.StructureNumeric.Size = new System.Drawing.Size(96, 20);
            this.StructureNumeric.TabIndex = 6;
            // 
            // BendingLabel
            // 
            this.BendingLabel.AutoSize = true;
            this.BendingLabel.Location = new System.Drawing.Point(7, 104);
            this.BendingLabel.Name = "BendingLabel";
            this.BendingLabel.Size = new System.Drawing.Size(49, 13);
            this.BendingLabel.TabIndex = 7;
            this.BendingLabel.Text = "Bending:";
            // 
            // BendingSlider
            // 
            this.BendingSlider.AutoSize = false;
            this.BendingSlider.Location = new System.Drawing.Point(62, 102);
            this.BendingSlider.Name = "BendingSlider";
            this.BendingSlider.Size = new System.Drawing.Size(134, 20);
            this.BendingSlider.TabIndex = 8;
            this.BendingSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // BendingNumeric
            // 
            this.BendingNumeric.DecimalPlaces = 3;
            this.BendingNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.BendingNumeric.Location = new System.Drawing.Point(202, 102);
            this.BendingNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BendingNumeric.Name = "BendingNumeric";
            this.BendingNumeric.Size = new System.Drawing.Size(96, 20);
            this.BendingNumeric.TabIndex = 9;
            // 
            // SpringLabel
            // 
            this.SpringLabel.AutoSize = true;
            this.SpringLabel.Location = new System.Drawing.Point(16, 130);
            this.SpringLabel.Name = "SpringLabel";
            this.SpringLabel.Size = new System.Drawing.Size(40, 13);
            this.SpringLabel.TabIndex = 10;
            this.SpringLabel.Text = "Spring:";
            // 
            // SpringNumeric
            // 
            this.SpringNumeric.DecimalPlaces = 3;
            this.SpringNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SpringNumeric.Location = new System.Drawing.Point(202, 128);
            this.SpringNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpringNumeric.Name = "SpringNumeric";
            this.SpringNumeric.Size = new System.Drawing.Size(96, 20);
            this.SpringNumeric.TabIndex = 11;
            // 
            // AirNumeric
            // 
            this.AirNumeric.DecimalPlaces = 3;
            this.AirNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AirNumeric.Location = new System.Drawing.Point(202, 154);
            this.AirNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AirNumeric.Name = "AirNumeric";
            this.AirNumeric.Size = new System.Drawing.Size(96, 20);
            this.AirNumeric.TabIndex = 12;
            // 
            // SpringSlider
            // 
            this.SpringSlider.AutoSize = false;
            this.SpringSlider.Location = new System.Drawing.Point(62, 128);
            this.SpringSlider.Name = "SpringSlider";
            this.SpringSlider.Size = new System.Drawing.Size(134, 20);
            this.SpringSlider.TabIndex = 13;
            this.SpringSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // VelocityNumeric
            // 
            this.VelocityNumeric.DecimalPlaces = 3;
            this.VelocityNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VelocityNumeric.Location = new System.Drawing.Point(202, 180);
            this.VelocityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VelocityNumeric.Name = "VelocityNumeric";
            this.VelocityNumeric.Size = new System.Drawing.Size(96, 20);
            this.VelocityNumeric.TabIndex = 14;
            // 
            // AirLabel
            // 
            this.AirLabel.AutoSize = true;
            this.AirLabel.Location = new System.Drawing.Point(34, 156);
            this.AirLabel.Name = "AirLabel";
            this.AirLabel.Size = new System.Drawing.Size(22, 13);
            this.AirLabel.TabIndex = 15;
            this.AirLabel.Text = "Air:";
            // 
            // AirSlider
            // 
            this.AirSlider.AutoSize = false;
            this.AirSlider.Location = new System.Drawing.Point(62, 154);
            this.AirSlider.Name = "AirSlider";
            this.AirSlider.Size = new System.Drawing.Size(134, 20);
            this.AirSlider.TabIndex = 16;
            this.AirSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // VelocitySlider
            // 
            this.VelocitySlider.AutoSize = false;
            this.VelocitySlider.Location = new System.Drawing.Point(62, 180);
            this.VelocitySlider.Name = "VelocitySlider";
            this.VelocitySlider.Size = new System.Drawing.Size(134, 20);
            this.VelocitySlider.TabIndex = 17;
            this.VelocitySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(9, 182);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(47, 13);
            this.VelocityLabel.TabIndex = 18;
            this.VelocityLabel.Text = "Velocity:";
            // 
            // TopoGroup
            // 
            this.TopoGroup.Controls.Add(this.TriRadio);
            this.TopoGroup.Controls.Add(this.QuadRadio);
            this.TopoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopoGroup.Location = new System.Drawing.Point(3, 215);
            this.TopoGroup.Name = "TopoGroup";
            this.TopoGroup.Size = new System.Drawing.Size(304, 66);
            this.TopoGroup.TabIndex = 1;
            this.TopoGroup.TabStop = false;
            this.TopoGroup.Text = "Topology";
            // 
            // QuadRadio
            // 
            this.QuadRadio.AutoSize = true;
            this.QuadRadio.Location = new System.Drawing.Point(10, 19);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.Size = new System.Drawing.Size(56, 17);
            this.QuadRadio.TabIndex = 0;
            this.QuadRadio.TabStop = true;
            this.QuadRadio.Text = "Quads";
            this.QuadRadio.UseVisualStyleBackColor = true;
            // 
            // TriRadio
            // 
            this.TriRadio.AutoSize = true;
            this.TriRadio.Location = new System.Drawing.Point(10, 42);
            this.TriRadio.Name = "TriRadio";
            this.TriRadio.Size = new System.Drawing.Size(42, 17);
            this.TriRadio.TabIndex = 1;
            this.TriRadio.TabStop = true;
            this.TriRadio.Text = "Tris";
            this.TriRadio.UseVisualStyleBackColor = true;
            // 
            // TextureGroup
            // 
            this.TextureGroup.Controls.Add(this.GlossLabel);
            this.TextureGroup.Controls.Add(this.SpecularLabel);
            this.TextureGroup.Controls.Add(this.NormalLabel);
            this.TextureGroup.Controls.Add(this.GlossSelect);
            this.TextureGroup.Controls.Add(this.SpecularSelect);
            this.TextureGroup.Controls.Add(this.NormalSelect);
            this.TextureGroup.Controls.Add(this.GlossEdit);
            this.TextureGroup.Controls.Add(this.SpecularEdit);
            this.TextureGroup.Controls.Add(this.NormalEdit);
            this.TextureGroup.Controls.Add(this.DiffuseSelect);
            this.TextureGroup.Controls.Add(this.DiffuseEdit);
            this.TextureGroup.Controls.Add(this.DiffuseLabel);
            this.TextureGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextureGroup.Location = new System.Drawing.Point(3, 287);
            this.TextureGroup.Name = "TextureGroup";
            this.TextureGroup.Size = new System.Drawing.Size(304, 299);
            this.TextureGroup.TabIndex = 2;
            this.TextureGroup.TabStop = false;
            this.TextureGroup.Text = "Textures";
            // 
            // DiffuseLabel
            // 
            this.DiffuseLabel.AutoSize = true;
            this.DiffuseLabel.Location = new System.Drawing.Point(15, 16);
            this.DiffuseLabel.Name = "DiffuseLabel";
            this.DiffuseLabel.Size = new System.Drawing.Size(43, 13);
            this.DiffuseLabel.TabIndex = 0;
            this.DiffuseLabel.Text = "Diffuse:";
            // 
            // DiffuseEdit
            // 
            this.DiffuseEdit.Location = new System.Drawing.Point(62, 13);
            this.DiffuseEdit.Name = "DiffuseEdit";
            this.DiffuseEdit.Size = new System.Drawing.Size(197, 20);
            this.DiffuseEdit.TabIndex = 1;
            // 
            // DiffuseSelect
            // 
            this.DiffuseSelect.Location = new System.Drawing.Point(265, 11);
            this.DiffuseSelect.Name = "DiffuseSelect";
            this.DiffuseSelect.Size = new System.Drawing.Size(33, 23);
            this.DiffuseSelect.TabIndex = 2;
            this.DiffuseSelect.Text = "...";
            this.DiffuseSelect.UseVisualStyleBackColor = true;
            // 
            // NormalEdit
            // 
            this.NormalEdit.Location = new System.Drawing.Point(61, 39);
            this.NormalEdit.Name = "NormalEdit";
            this.NormalEdit.Size = new System.Drawing.Size(198, 20);
            this.NormalEdit.TabIndex = 3;
            // 
            // SpecularEdit
            // 
            this.SpecularEdit.Location = new System.Drawing.Point(61, 65);
            this.SpecularEdit.Name = "SpecularEdit";
            this.SpecularEdit.Size = new System.Drawing.Size(198, 20);
            this.SpecularEdit.TabIndex = 4;
            // 
            // GlossEdit
            // 
            this.GlossEdit.Location = new System.Drawing.Point(61, 91);
            this.GlossEdit.Name = "GlossEdit";
            this.GlossEdit.Size = new System.Drawing.Size(198, 20);
            this.GlossEdit.TabIndex = 5;
            // 
            // NormalSelect
            // 
            this.NormalSelect.Location = new System.Drawing.Point(265, 37);
            this.NormalSelect.Name = "NormalSelect";
            this.NormalSelect.Size = new System.Drawing.Size(33, 23);
            this.NormalSelect.TabIndex = 6;
            this.NormalSelect.Text = "...";
            this.NormalSelect.UseVisualStyleBackColor = true;
            // 
            // SpecularSelect
            // 
            this.SpecularSelect.Location = new System.Drawing.Point(265, 63);
            this.SpecularSelect.Name = "SpecularSelect";
            this.SpecularSelect.Size = new System.Drawing.Size(33, 23);
            this.SpecularSelect.TabIndex = 7;
            this.SpecularSelect.Text = "...";
            this.SpecularSelect.UseVisualStyleBackColor = true;
            // 
            // GlossSelect
            // 
            this.GlossSelect.Location = new System.Drawing.Point(264, 89);
            this.GlossSelect.Name = "GlossSelect";
            this.GlossSelect.Size = new System.Drawing.Size(34, 23);
            this.GlossSelect.TabIndex = 8;
            this.GlossSelect.Text = "...";
            this.GlossSelect.UseVisualStyleBackColor = true;
            // 
            // NormalLabel
            // 
            this.NormalLabel.AutoSize = true;
            this.NormalLabel.Location = new System.Drawing.Point(15, 42);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(43, 13);
            this.NormalLabel.TabIndex = 9;
            this.NormalLabel.Text = "Normal:";
            // 
            // SpecularLabel
            // 
            this.SpecularLabel.AutoSize = true;
            this.SpecularLabel.Location = new System.Drawing.Point(6, 68);
            this.SpecularLabel.Name = "SpecularLabel";
            this.SpecularLabel.Size = new System.Drawing.Size(52, 13);
            this.SpecularLabel.TabIndex = 10;
            this.SpecularLabel.Text = "Specular:";
            // 
            // GlossLabel
            // 
            this.GlossLabel.AutoSize = true;
            this.GlossLabel.Location = new System.Drawing.Point(22, 94);
            this.GlossLabel.Name = "GlossLabel";
            this.GlossLabel.Size = new System.Drawing.Size(36, 13);
            this.GlossLabel.TabIndex = 11;
            this.GlossLabel.Text = "Gloss:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Clothier3D";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ClothSettingsGroup.ResumeLayout(false);
            this.ClothSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MassSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StructureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BendingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BendingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocitySlider)).EndInit();
            this.TopoGroup.ResumeLayout(false);
            this.TopoGroup.PerformLayout();
            this.TextureGroup.ResumeLayout(false);
            this.TextureGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePatternAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closePatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ActivateToolButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OpenTK.GLControl SceneView;
        private OpenTK.GLControl PatternView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox ClothSettingsGroup;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.ComboBox ClothChooser;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.TrackBar VelocitySlider;
        private System.Windows.Forms.TrackBar AirSlider;
        private System.Windows.Forms.Label AirLabel;
        private System.Windows.Forms.NumericUpDown VelocityNumeric;
        private System.Windows.Forms.TrackBar SpringSlider;
        private System.Windows.Forms.NumericUpDown AirNumeric;
        private System.Windows.Forms.NumericUpDown SpringNumeric;
        private System.Windows.Forms.Label SpringLabel;
        private System.Windows.Forms.NumericUpDown BendingNumeric;
        private System.Windows.Forms.TrackBar BendingSlider;
        private System.Windows.Forms.Label BendingLabel;
        private System.Windows.Forms.NumericUpDown StructureNumeric;
        private System.Windows.Forms.TrackBar StructureSlider;
        private System.Windows.Forms.Label StructureLabel;
        private System.Windows.Forms.NumericUpDown MassNumeric;
        private System.Windows.Forms.TrackBar MassSlider;
        private System.Windows.Forms.GroupBox TopoGroup;
        private System.Windows.Forms.RadioButton TriRadio;
        private System.Windows.Forms.RadioButton QuadRadio;
        private System.Windows.Forms.GroupBox TextureGroup;
        private System.Windows.Forms.Label GlossLabel;
        private System.Windows.Forms.Label SpecularLabel;
        private System.Windows.Forms.Label NormalLabel;
        private System.Windows.Forms.Button GlossSelect;
        private System.Windows.Forms.Button SpecularSelect;
        private System.Windows.Forms.Button NormalSelect;
        private System.Windows.Forms.TextBox GlossEdit;
        private System.Windows.Forms.TextBox SpecularEdit;
        private System.Windows.Forms.TextBox NormalEdit;
        private System.Windows.Forms.Button DiffuseSelect;
        private System.Windows.Forms.TextBox DiffuseEdit;
        private System.Windows.Forms.Label DiffuseLabel;
    }
}

