namespace Scheduler
{
    partial class frmSectionAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSectionAE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboYearLvl = new System.Windows.Forms.ComboBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelSSC = new System.Windows.Forms.Button();
            this.lvSSC = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.cboReg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSCC = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboYearLvl);
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Class:";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "REGULAR",
            "SSC"});
            this.cboClass.Location = new System.Drawing.Point(103, 156);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(139, 27);
            this.cboClass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year Level:";
            // 
            // cboYearLvl
            // 
            this.cboYearLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearLvl.FormattingEnabled = true;
            this.cboYearLvl.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboYearLvl.Location = new System.Drawing.Point(103, 90);
            this.cboYearLvl.Name = "cboYearLvl";
            this.cboYearLvl.Size = new System.Drawing.Size(121, 27);
            this.cboYearLvl.TabIndex = 1;
            // 
            // txtSection
            // 
            this.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSection.Location = new System.Drawing.Point(101, 31);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(210, 27);
            this.txtSection.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Section Title:";
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(125, 257);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(86, 39);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "     &Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtSectionID
            // 
            this.txtSectionID.BackColor = System.Drawing.SystemColors.Info;
            this.txtSectionID.Enabled = false;
            this.txtSectionID.Location = new System.Drawing.Point(91, 28);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(100, 21);
            this.txtSectionID.TabIndex = 5;
            this.txtSectionID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section ID:";
            this.label1.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 257);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 39);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboReg);
            this.groupBox2.Controls.Add(this.btndel);
            this.groupBox2.Controls.Add(this.lvSchedule);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(336, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGULAR CLASS";
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(404, 178);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(86, 37);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "     &Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lvSchedule
            // 
            this.lvSchedule.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSchedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(9, 22);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(481, 150);
            this.lvSchedule.TabIndex = 26;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.ItemActivate += new System.EventHandler(this.lvSchedule_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SECTION NAME";
            this.columnHeader8.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YEAR LEVEL";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CLASS";
            this.columnHeader3.Width = 150;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(237, 257);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(86, 39);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "      &Close";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboSCC);
            this.groupBox3.Controls.Add(this.btnDelSSC);
            this.groupBox3.Controls.Add(this.lvSSC);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(336, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 226);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SPECIAL SCIENCE CLASS";
            // 
            // btnDelSSC
            // 
            this.btnDelSSC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSSC.Image = ((System.Drawing.Image)(resources.GetObject("btnDelSSC.Image")));
            this.btnDelSSC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSSC.Location = new System.Drawing.Point(404, 183);
            this.btnDelSSC.Name = "btnDelSSC";
            this.btnDelSSC.Size = new System.Drawing.Size(86, 37);
            this.btnDelSSC.TabIndex = 4;
            this.btnDelSSC.Text = "     &Delete";
            this.btnDelSSC.UseVisualStyleBackColor = true;
            this.btnDelSSC.Click += new System.EventHandler(this.btnDelSSC_Click);
            // 
            // lvSSC
            // 
            this.lvSSC.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSSC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvSSC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSSC.FullRowSelect = true;
            this.lvSSC.GridLines = true;
            this.lvSSC.Location = new System.Drawing.Point(9, 26);
            this.lvSSC.Name = "lvSSC";
            this.lvSSC.Size = new System.Drawing.Size(481, 150);
            this.lvSSC.TabIndex = 26;
            this.lvSSC.UseCompatibleStateImageBehavior = false;
            this.lvSSC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SECTION NAME";
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "YEAR LEVEL";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CLASS";
            this.columnHeader7.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Year Level:";
            // 
            // cboReg
            // 
            this.cboReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReg.FormattingEnabled = true;
            this.cboReg.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboReg.Location = new System.Drawing.Point(92, 184);
            this.cboReg.Name = "cboReg";
            this.cboReg.Size = new System.Drawing.Size(121, 27);
            this.cboReg.TabIndex = 27;
            this.cboReg.TextChanged += new System.EventHandler(this.cboReg_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Year Level:";
            // 
            // cboSCC
            // 
            this.cboSCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSCC.FormattingEnabled = true;
            this.cboSCC.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboSCC.Location = new System.Drawing.Point(92, 189);
            this.cboSCC.Name = "cboSCC";
            this.cboSCC.Size = new System.Drawing.Size(121, 27);
            this.cboSCC.TabIndex = 29;
            
            this.cboSCC.TextChanged += new System.EventHandler(this.cboSCC_TextChanged);
            // 
            // frmSectionAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSectionID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSectionAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section";
            this.Load += new System.EventHandler(this.frmSectionAE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboYearLvl;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelSSC;
        private System.Windows.Forms.ListView lvSSC;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSCC;
    }
}