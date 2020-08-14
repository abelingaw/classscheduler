using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scheduler
{
    public partial class frmManageSections : Form
    {
        public int sDay =1,sDay1 =1,sDay2=1;

        public frmManageSections()
        {
            InitializeComponent();
        }


        private void TimeTable()
        {
            String[] modules = new String[7] { "M", "T", "W", "H", "F", "S", "A" };
            lvsked.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                ListViewItem list = new ListViewItem(modules[i]);
                for (int column = 0; column <= lvsked.Columns.Count; column++)
                {
                   list.SubItems.Add(" ");
                }
                lvsked.Items.AddRange(new ListViewItem[] { list });
            }
        }

        void DisplaySectionSchedule(string section)
        {
            DateTime dTimeIn, dTimeOut;
            int num1, num2;
            Random randonGen = new Random();
            OleDbCommand com = new OleDbCommand("Select * From qrySubjectOfferring where [SectionID] Like'" + section + "%'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSchedule.Items.Clear();
            lvsked.Items.Clear();

            TimeTable();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subject"].ToString());
                lv.SubItems.Add(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());
                lv.ForeColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                lvSchedule.Items.AddRange(new ListViewItem[] { lv });


                dTimeIn = DateTime.Parse(dr["cTimeIn"].ToString());
                dTimeOut = DateTime.Parse(dr["cTimeOut"].ToString());

                ConvertsDaysToInt(dr["cDay"].ToString());
                num1 =clsSchedule.ConvertsTimeINToInt(dTimeIn.ToLongTimeString());
                num2 =clsSchedule.ConvertsTimeOUTToInt(dTimeOut.ToLongTimeString());

                switch (dr["cDay"].ToString())
                {
                    case "MH":
                         for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay1].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay1].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    case "TF":
                        for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay1].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay1].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    case "WS":
                        for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay1].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay1].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    case "MWF":
                        for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay1].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay1].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay2].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay2].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    case "THS":
                        for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay1].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay1].SubItems[time].BackColor = lv.ForeColor;

                            lvsked.Items[sDay2].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay2].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    default:
                        for (int time = num1; time <= num2; time++)
                        {
                            lvsked.Items[sDay].UseItemStyleForSubItems = false;
                            lvsked.Items[sDay].SubItems[time].BackColor = lv.ForeColor;
                        }
                        break;
                    }
            }
            dr.Close();
        }

        void ConvertsDaysToInt(string cDays)
        {
            switch (cDays)
            {
                case "M":
                    sDay = 0;
                    break;
                case "T":
                    sDay = 1;
                    break;
                case "W":
                    sDay = 2;
                    break;
                case "H":
                    sDay = 3;
                    break;
                case "F":
                    sDay = 4;
                    break;
                case "S":
                    sDay = 5;
                    break;
                case "A":
                    sDay = 6;
                    break;
                case "MH":
                    sDay = 0;
                    sDay1 = 3;
                    break;
                case "TF":
                    sDay = 1;
                    sDay1 = 4;
                    break;
                case "WS":
                    sDay = 2;
                    sDay1 = 5;
                    break;
                case "MWF":
                    sDay = 0;
                    sDay1 = 2;
                    sDay2 = 4;
                    break;
                case "THS":
                    sDay = 1;
                    sDay1 = 3;
                    sDay2 = 5;
                    break;
            }
        }


        private void frmManageSections_Load(object sender, EventArgs e)
        {
            try
            {
                if (clsCon.con.State == ConnectionState.Open)
                {
                    clsCon.con.Close();
                }
                clsCon.con.Open();


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

            cboSchoolYear.SelectedIndex = cboSchoolYear.FindStringExact("ALL");

            TimeTable();
        }


        void FillSection(string YrLvl)
        {
            if (YrLvl == "ALL")
            {
                OleDbCommand com = new OleDbCommand("Select * From qrySection", clsCon.con);
                OleDbDataReader dr = com.ExecuteReader();
                lvSections.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["SectionID"].ToString());
                    lv.SubItems.Add(dr["newSection"].ToString());
                    lv.SubItems.Add(dr["CurriculumTitle"].ToString());
                    lvSections.Items.AddRange(new ListViewItem[] { lv });
                }
                txtStatus.Text = lvSections.Items.Count.ToString() + " faculties found...";
                dr.Close();
            }
            else
            {
                OleDbCommand com = new OleDbCommand("Select * From qrySection where YearLvl='" + YrLvl + "'", clsCon.con);
                OleDbDataReader dr = com.ExecuteReader();
                lvSections.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["SectionID"].ToString());
                    lv.SubItems.Add(dr["newSection"].ToString());
                    lv.SubItems.Add(dr["CurriculumTitle"].ToString());
                    lvSections.Items.AddRange(new ListViewItem[] { lv });
                }
                txtStatus.Text = lvSections.Items.Count.ToString() + " faculties found...";
                dr.Close();
            }
        }
        void FillAllSection()
        {
                OleDbCommand com = new OleDbCommand("Select * From qrySection", clsCon.con);
                OleDbDataReader dr = com.ExecuteReader();
                lvSections.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr["SectionID"].ToString());
                    lv.SubItems.Add(dr["newSection"].ToString());
                    lv.SubItems.Add(dr["CurriculumTitle"].ToString());
                    lvSections.Items.AddRange(new ListViewItem[] { lv });
                }
                txtStatus.Text = lvSections.Items.Count.ToString() + " faculties found...";
                dr.Close();
            
        }

        private void cboSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cboSchoolYear.Text)
            { 
                case"ALL":
                    FillAllSection();
                    break;
                default:
                     int X = clsCon.YLTitleToID(cboSchoolYear.Text);
                     FillSection(X.ToString());
                    break;
            }
           
        }

        private void lvSections_Click(object sender, EventArgs e)
        {
            DisplaySectionSchedule(lvSections.FocusedItem.Text);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillAllSection();
        }

        void DeleteSection(string sSectionID)
        {
            OleDbCommand com = new OleDbCommand("Delete * From tblSection WHERE (((tblSection.SectionID)='" + sSectionID + "'));",clsCon.con);
            com.ExecuteNonQuery();

            MessageBox.Show("Record Successfully Deleted....");
        }

        private void lvSections_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("WARNING:You are about to delete Section entry and you cannot Undo this operation.\n Are you sure to delete it?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
                {
                    DeleteSection(lvSections.FocusedItem.Text);
                }
            }
        }

        private void cboSchoolYear_Click(object sender, EventArgs e)
        {

        }


    }
}