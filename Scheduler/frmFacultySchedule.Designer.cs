namespace Scheduler
{
    partial class frmFacultySchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacultySchedule));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewFacultyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSect = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTeach = new System.Windows.Forms.ComboBox();
            this.rdTeacher = new System.Windows.Forms.RadioButton();
            this.rdSYL = new System.Windows.Forms.RadioButton();
            this.btndel = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEntryToolStripMenuItem,
            this.modifyEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem,
            this.toolStripSeparator4,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator5,
            this.viewFacultyInfoToolStripMenuItem,
            this.printScheduleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 148);
            // 
            // addNewEntryToolStripMenuItem
            // 
            this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
            this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addNewEntryToolStripMenuItem.Text = "Add New Entry";
            // 
            // modifyEntryToolStripMenuItem
            // 
            this.modifyEntryToolStripMenuItem.Name = "modifyEntryToolStripMenuItem";
            this.modifyEntryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modifyEntryToolStripMenuItem.Text = "Modify Entry";
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // viewFacultyInfoToolStripMenuItem
            // 
            this.viewFacultyInfoToolStripMenuItem.Name = "viewFacultyInfoToolStripMenuItem";
            this.viewFacultyInfoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewFacultyInfoToolStripMenuItem.Text = "View Faculty Info";
            // 
            // printScheduleToolStripMenuItem
            // 
            this.printScheduleToolStripMenuItem.Name = "printScheduleToolStripMenuItem";
            this.printScheduleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.printScheduleToolStripMenuItem.Text = "Print Schedule";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 0;
            this.columnHeader10.Text = "FacultyID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 1;
            this.columnHeader11.Text = "Faculty";
            this.columnHeader11.Width = 250;
            // 
            // lvSchedule
            // 
            this.lvSchedule.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16});
            this.lvSchedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(2, 182);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(898, 300);
            this.lvSchedule.TabIndex = 1;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSchedule_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SCHEDULE";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "SUBJECT";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "SECTION";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "YEAR LEVEL";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "TEACHER";
            this.columnHeader16.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(776, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 37);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "     &Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 506);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 37);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "     &Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboSect);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "SECTION";
            // 
            // cboSect
            // 
            this.cboSect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSect.ItemHeight = 16;
            this.cboSect.Location = new System.Drawing.Point(90, 26);
            this.cboSect.Name = "cboSect";
            this.cboSect.Size = new System.Drawing.Size(316, 24);
            this.cboSect.TabIndex = 15;
            this.cboSect.SelectedValueChanged += new System.EventHandler(this.cboSect_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTeach);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "TEACHER";
            // 
            // cboTeach
            // 
            this.cboTeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTeach.ItemHeight = 16;
            this.cboTeach.Location = new System.Drawing.Point(90, 28);
            this.cboTeach.Name = "cboTeach";
            this.cboTeach.Size = new System.Drawing.Size(467, 24);
            this.cboTeach.TabIndex = 15;
            this.cboTeach.SelectedValueChanged += new System.EventHandler(this.cboTeach_SelectedValueChanged);
            // 
            // rdTeacher
            // 
            this.rdTeacher.AutoSize = true;
            this.rdTeacher.Location = new System.Drawing.Point(43, 105);
            this.rdTeacher.Name = "rdTeacher";
            this.rdTeacher.Size = new System.Drawing.Size(14, 13);
            this.rdTeacher.TabIndex = 21;
            this.rdTeacher.TabStop = true;
            this.rdTeacher.UseVisualStyleBackColor = true;
            this.rdTeacher.CheckedChanged += new System.EventHandler(this.rdTeacher_CheckedChanged);
            // 
            // rdSYL
            // 
            this.rdSYL.AutoSize = true;
            this.rdSYL.Location = new System.Drawing.Point(43, 33);
            this.rdSYL.Name = "rdSYL";
            this.rdSYL.Size = new System.Drawing.Size(14, 13);
            this.rdSYL.TabIndex = 22;
            this.rdSYL.TabStop = true;
            this.rdSYL.UseVisualStyleBackColor = true;
            this.rdSYL.CheckedChanged += new System.EventHandler(this.rdSYL_CheckedChanged);
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(642, 506);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(115, 37);
            this.btndel.TabIndex = 23;
            this.btndel.Text = "     &Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // frmFacultySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 555);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.rdSYL);
            this.Controls.Add(this.rdTeacher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacultySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Schedules";
            this.Load += new System.EventHandler(this.frmFacultySchedule_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFacultyInfoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cboSect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboTeach;
        private System.Windows.Forms.RadioButton rdSYL;
        private System.Windows.Forms.RadioButton rdTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ColumnHeader columnHeader1;

    }
}