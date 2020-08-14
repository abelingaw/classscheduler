namespace Scheduler
{
    partial class frmScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduler));
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboYL = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.dBaseDataSet2 = new Scheduler.DBaseDataSet2();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new Scheduler.DBaseDataSet2TableAdapters.FacultyTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvConflicts = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtStatus});
            this.statusStrip2.Location = new System.Drawing.Point(333, 450);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(542, 22);
            this.statusStrip2.TabIndex = 26;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Red;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(20, 17);
            this.txtStatus.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "txtFacultyID";
            this.tabPage1.Controls.Add(this.txtFacultyID);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cmdSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(325, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subject Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacultyID.Location = new System.Drawing.Point(17, 415);
            this.txtFacultyID.MaxLength = 50;
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(50, 21);
            this.txtFacultyID.TabIndex = 12;
            this.txtFacultyID.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(15, 371);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "     &New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(224, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "     &Close   ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboYL);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboSection);
            this.groupBox1.Controls.Add(this.cboFaculty);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormatString = "t";
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "M",
            "T",
            "W",
            "TH",
            "F",
            "MT",
            "MTW",
            "MWF",
            "WTHF",
            "TWTHF",
            "MTWTH",
            "MTWF",
            "MTTHF",
            "MTWTHF"});
            this.cboDay.Location = new System.Drawing.Point(78, 183);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(158, 23);
            this.cboDay.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Day:";
            // 
            // cboYL
            // 
            this.cboYL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboYL.Enabled = false;
            this.cboYL.Location = new System.Drawing.Point(78, 104);
            this.cboYL.MaxLength = 50;
            this.cboYL.Name = "cboYL";
            this.cboYL.Size = new System.Drawing.Size(90, 21);
            this.cboYL.TabIndex = 46;
            // 
            // cboClass
            // 
            this.cboClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboClass.Enabled = false;
            this.cboClass.Location = new System.Drawing.Point(78, 143);
            this.cboClass.MaxLength = 50;
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(158, 21);
            this.cboClass.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Class:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Year Level";
            // 
            // cboSection
            // 
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(78, 62);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(241, 23);
            this.cboSection.TabIndex = 2;
            this.cboSection.Leave += new System.EventHandler(this.cboSection_Leave);
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(78, 227);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(241, 23);
            this.cboFaculty.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubject.Location = new System.Drawing.Point(78, 25);
            this.txtSubject.MaxLength = 50;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(241, 21);
            this.txtSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Section";
            // 
            // cboFrom
            // 
            this.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrom.FormatString = "t";
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Items.AddRange(new object[] {
            "7:30 AM",
            "8:30 AM",
            "9:30 AM",
            "9:50 AM",
            "10:00 AM",
            "10:30 AM",
            "10:50 AM",
            "11:00 AM",
            "11:50 AM",
            "12:00 PM",
            "1:30 PM",
            "2:30 PM",
            "3:30 PM",
            "4:30 PM",
            "5:00 PM"});
            this.cboFrom.Location = new System.Drawing.Point(78, 273);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(109, 23);
            this.cboFrom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Subject";
            // 
            // cboTo
            // 
            this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTo.FormatString = "t";
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Items.AddRange(new object[] {
            "7:30 AM",
            "8:30 AM",
            "9:30 AM",
            "9:50 AM",
            "10:00 AM",
            "10:30 AM",
            "10:50 AM",
            "11:00 AM",
            "11:50 AM",
            "12:00 PM",
            "1:30 PM",
            "2:30 PM",
            "3:30 PM",
            "4:30 PM",
            "5:00 PM"});
            this.cboTo.Location = new System.Drawing.Point(78, 317);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(109, 23);
            this.cboTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Faculty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "To";
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(117, 371);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(85, 38);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "     &Save   ";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click_1);
            // 
            // dBaseDataSet2
            // 
            this.dBaseDataSet2.DataSetName = "DBaseDataSet2";
            this.dBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.dBaseDataSet2;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSchedule);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(342, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 334);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NO CONFLICTS";
            // 
            // lvSchedule
            // 
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader1});
            this.lvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(3, 23);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(518, 308);
            this.lvSchedule.TabIndex = 31;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SCHEDULE";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "SUBJECT";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "SECTION";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "YEAR LEVEL";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "TEACHER";
            this.columnHeader15.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CLASS";
            this.columnHeader1.Width = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvConflicts);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(342, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 164);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WITH CONFLICTS";
            // 
            // lvConflicts
            // 
            this.lvConflicts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvConflicts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConflicts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConflicts.GridLines = true;
            this.lvConflicts.Location = new System.Drawing.Point(3, 23);
            this.lvConflicts.Name = "lvConflicts";
            this.lvConflicts.Size = new System.Drawing.Size(518, 138);
            this.lvConflicts.TabIndex = 31;
            this.lvConflicts.UseCompatibleStateImageBehavior = false;
            this.lvConflicts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SCHEDULE";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SUBJECT";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SECTION";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "YEAR LEVEL";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TEACHER";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CLASS";
            this.columnHeader8.Width = 100;
            // 
            // frmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmScheduler_Load);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtSubject;
        private DBaseDataSet2 dBaseDataSet2;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private DBaseDataSet2TableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cboYL;
        private System.Windows.Forms.TextBox cboClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvConflicts;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}