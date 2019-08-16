namespace CSVCopier.TourajOstovari.Developed
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Timer_Copying = new System.Windows.Forms.Timer(this.components);
            this.Grid_FoldersData = new System.Windows.Forms.DataGridView();
            this.txtIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_StopTimer = new System.Windows.Forms.Button();
            this.btn_StartTimer = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_TargetFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.btn_ImportSettings = new System.Windows.Forms.Button();
            this.ExportFile_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.ImportFile_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Aboutme = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbx_startup = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_FoldersData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Address:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1085, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Timer_Copying
            // 
            this.Timer_Copying.Interval = 6000;
            this.Timer_Copying.Tick += new System.EventHandler(this.Timer_Copying_Tick);
            // 
            // Grid_FoldersData
            // 
            this.Grid_FoldersData.AllowUserToAddRows = false;
            this.Grid_FoldersData.AllowUserToDeleteRows = false;
            this.Grid_FoldersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_FoldersData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_FoldersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_FoldersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIndex,
            this.txtAddress});
            this.Grid_FoldersData.Location = new System.Drawing.Point(14, 150);
            this.Grid_FoldersData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid_FoldersData.Name = "Grid_FoldersData";
            this.Grid_FoldersData.ReadOnly = true;
            this.Grid_FoldersData.Size = new System.Drawing.Size(1086, 206);
            this.Grid_FoldersData.TabIndex = 2;
            // 
            // txtIndex
            // 
            this.txtIndex.FillWeight = 10F;
            this.txtIndex.HeaderText = "#";
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            // 
            // txtAddress
            // 
            this.txtAddress.FillWeight = 149.2386F;
            this.txtAddress.HeaderText = "Folder";
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(247, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(474, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Address";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "\'0\' is first row of folder address";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(198, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 30);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 26);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Index:";
            this.toolTip1.SetToolTip(this.label2, "Index of row should entered");
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(-10, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1153, 12);
            this.label3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_StopTimer);
            this.groupBox2.Controls.Add(this.btn_StartTimer);
            this.groupBox2.Location = new System.Drawing.Point(17, 518);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(532, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btn_StopTimer
            // 
            this.btn_StopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StopTimer.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.btn_StopTimer.Location = new System.Drawing.Point(202, 22);
            this.btn_StopTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StopTimer.Name = "btn_StopTimer";
            this.btn_StopTimer.Size = new System.Drawing.Size(129, 48);
            this.btn_StopTimer.TabIndex = 1;
            this.btn_StopTimer.Text = "Stop";
            this.toolTip1.SetToolTip(this.btn_StopTimer, "Stops auto copier job");
            this.btn_StopTimer.UseVisualStyleBackColor = true;
            this.btn_StopTimer.Click += new System.EventHandler(this.btn_StopTimer_Click);
            // 
            // btn_StartTimer
            // 
            this.btn_StartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartTimer.Font = new System.Drawing.Font("Agency FB", 14.25F);
            this.btn_StartTimer.Location = new System.Drawing.Point(17, 23);
            this.btn_StartTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_StartTimer.Name = "btn_StartTimer";
            this.btn_StartTimer.Size = new System.Drawing.Size(129, 48);
            this.btn_StartTimer.TabIndex = 0;
            this.btn_StartTimer.Text = "Start ";
            this.btn_StartTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_StartTimer, "Your Files will re-copy each 6s");
            this.btn_StartTimer.UseVisualStyleBackColor = true;
            this.btn_StartTimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btn_TargetFolder
            // 
            this.btn_TargetFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.btn_TargetFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_TargetFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.btn_TargetFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.btn_TargetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TargetFolder.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TargetFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TargetFolder.Location = new System.Drawing.Point(572, 540);
            this.btn_TargetFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TargetFolder.Name = "btn_TargetFolder";
            this.btn_TargetFolder.Size = new System.Drawing.Size(139, 48);
            this.btn_TargetFolder.TabIndex = 7;
            this.btn_TargetFolder.Text = "Target";
            this.toolTip1.SetToolTip(this.btn_TargetFolder, "Choose target folder you wanna copy files there ...\r\n");
            this.btn_TargetFolder.UseVisualStyleBackColor = false;
            this.btn_TargetFolder.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter a &valid folder address please ... ";
            this.toolTip1.SetToolTip(this.label5, "Software would copy whole file(s) to target folder ...\r\n");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(729, 395);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 82);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clean ALL";
            this.toolTip1.SetToolTip(this.button3, "Delete all datagrid rows (Folder Address that we did add)");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btn_SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SaveSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SaveSettings.Location = new System.Drawing.Point(383, 17);
            this.btn_SaveSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(135, 37);
            this.btn_SaveSettings.TabIndex = 8;
            this.btn_SaveSettings.Text = "Save Settings";
            this.btn_SaveSettings.UseVisualStyleBackColor = false;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // btn_ImportSettings
            // 
            this.btn_ImportSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.btn_ImportSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ImportSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ImportSettings.Location = new System.Drawing.Point(234, 16);
            this.btn_ImportSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ImportSettings.Name = "btn_ImportSettings";
            this.btn_ImportSettings.Size = new System.Drawing.Size(132, 37);
            this.btn_ImportSettings.TabIndex = 9;
            this.btn_ImportSettings.Text = "Import Settings";
            this.btn_ImportSettings.UseVisualStyleBackColor = false;
            this.btn_ImportSettings.Click += new System.EventHandler(this.btn_ImportSettings_Click);
            // 
            // ExportFile_Dialog
            // 
            this.ExportFile_Dialog.FileName = "CSVSettings.db";
            // 
            // ImportFile_Dialog
            // 
            this.ImportFile_Dialog.FileName = "CSVSettings.db";
            // 
            // btn_Aboutme
            // 
            this.btn_Aboutme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Aboutme.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Aboutme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aboutme.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aboutme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Aboutme.Location = new System.Drawing.Point(182, 15);
            this.btn_Aboutme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Aboutme.Name = "btn_Aboutme";
            this.btn_Aboutme.Size = new System.Drawing.Size(38, 37);
            this.btn_Aboutme.TabIndex = 11;
            this.btn_Aboutme.Text = "?";
            this.btn_Aboutme.UseVisualStyleBackColor = false;
            this.btn_Aboutme.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_status.Location = new System.Drawing.Point(731, 549);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(369, 76);
            this.lbl_status.TabIndex = 12;
            this.lbl_status.Text = "File Copier Software is stopped now ...   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(733, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(840, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 62);
            this.label7.TabIndex = 15;
            // 
            // chbx_startup
            // 
            this.chbx_startup.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbx_startup.AutoSize = true;
            this.chbx_startup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.chbx_startup.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbx_startup.Checked = true;
            this.chbx_startup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbx_startup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbx_startup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.chbx_startup.FlatAppearance.BorderSize = 2;
            this.chbx_startup.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.chbx_startup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.chbx_startup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_startup.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx_startup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.chbx_startup.Location = new System.Drawing.Point(525, 18);
            this.chbx_startup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbx_startup.Name = "chbx_startup";
            this.chbx_startup.Size = new System.Drawing.Size(223, 29);
            this.chbx_startup.TabIndex = 16;
            this.chbx_startup.Text = "Run On Computer Startup time";
            this.chbx_startup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbx_startup.UseVisualStyleBackColor = false;
            this.chbx_startup.CheckedChanged += new System.EventHandler(this.chbx_startup_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click on me to make visible home screen ....";
            this.notifyIcon1.BalloonTipTitle = "Info";
            this.notifyIcon1.Text = "CSV COPIER";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 625);
            this.Controls.Add(this.chbx_startup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_Aboutme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ImportSettings);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.btn_TargetFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grid_FoldersData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filer Copier";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_FoldersData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Grid_FoldersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_StopTimer;
        private System.Windows.Forms.Button btn_StartTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_TargetFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.Button btn_ImportSettings;
        private System.Windows.Forms.SaveFileDialog ExportFile_Dialog;
        private System.Windows.Forms.OpenFileDialog ImportFile_Dialog;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Timer Timer_Copying;
        private System.Windows.Forms.Button btn_Aboutme;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbx_startup;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

