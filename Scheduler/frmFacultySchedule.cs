using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Scheduler
{
    public partial class frmFacultySchedule : Form
    {

        //DATABASE CONNECTION
        //SqlConnection cn = new SqlConnection(@"SERVER=Database=PRODUCTION;Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Integrated Security=True;User Instance=True");

        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();                
        SqlCommand cmd2 = new SqlCommand();

        public int sDay,sDay1,sDay2;
        public frmFacultySchedule()
        {
            InitializeComponent();
        }

        
        private void frmFacultySchedule_Load(object sender, EventArgs e)
        {
            
            DisplayFacultySchedule();
            CountItems();

        }

        
       void DisplayFacultySchedule()
        {

            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects ORDER BY TimeStart ASC";

            SqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["ID"].ToString());
                lv.SubItems.Add(dr["Sked"].ToString());                
                lv.SubItems.Add(dr["Subj"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());

                lvSchedule.Items.Add(lv);
             }

            dr.Close();
            cn.Close();

         }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayFacultySchedule();
        }

        private void rdTeacher_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            LoadTeachers();
            cboTeach.Focus();
        }

        private void rdSYL_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            LoadSections();

            cboSect.Focus();
        }

        private void LoadSections()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections ORDER BY YearLevel ASC";

            SqlDataReader rdr = cmd.ExecuteReader();
            cboSect.Items.Clear();

            while (rdr.Read())
            {
                cboSect.Items.Add(rdr["SecTitle"].ToString());
            }
            rdr.Close();
            cn.Close();
        }


        private void LoadTeachers()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Faculty ORDER BY LName ASC";

            SqlDataReader rdr = cmd.ExecuteReader();
            cboTeach.Items.Clear();

            while (rdr.Read())
            {
                //cboTeach.Items.Add(rdr["LName"].ToString() + ", " + rdr["FName"].ToString() + " " + rdr["MName"].ToString());
                cboTeach.Items.Add(rdr["FullName"].ToString());
            }
            rdr.Close();
            cn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            
            string DelRec = System.Convert.ToString(MessageBox.Show("Are you sure to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DelRec == Convert.ToString(DialogResult.Yes))
            {
                foreach (int i in lvSchedule.SelectedIndices)
                {
                    string Selected = lvSchedule.Items[i].Text;
                    lvSchedule.Items.Remove(lvSchedule.Items[i]);

                    cn.Open();

                    cmd.Connection = cn;

                    cmd.CommandText = "DELETE FROM Subjects WHERE ID = '" + Selected + "' ";
                    cmd.ExecuteNonQuery();
                    

                    MessageBox.Show("Record deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
                DisplayFacultySchedule();
                CountItems();

                }
            }
        

        private void lvSchedule_MouseDown(object sender, MouseEventArgs e)
        {
            btndel.Enabled = true;
        }


        private void CountItems()
        {
            if (lvSchedule.Items.Count > 0)
            {
                MessageBox.Show("There are : " + lvSchedule.Items.Count + " record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayFacultySchedule();
                btndel.Enabled = true;
                btnRefresh.Enabled = true;
            }
            else
            {
                MessageBox.Show("There are : " + lvSchedule.Items.Count + " record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btndel.Enabled = false;
                btnRefresh.Enabled = false;

            }
        }

        private void cboSect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboSect.Text.ToString()))
            {
                MessageBox.Show("No Section selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSect.Focus();
                return;
            }


            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects WHERE Section='" + cboSect.Text + "'  ORDER BY TimeStart ASC ";

            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["ID"].ToString());
                lv.SubItems.Add(dr["Sked"].ToString());
                lv.SubItems.Add(dr["Subj"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());

                lvSchedule.Items.Add(lv);
            }

            dr.Close();
            cn.Close();
        }

        private void cboTeach_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboTeach.Text.ToString()))
            {
                MessageBox.Show("No Teacher selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTeach.Focus();
                return;
            }

            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects WHERE Faculty='" + cboTeach.Text + "' ORDER BY TimeStart ASC ";

            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["ID"].ToString());
                lv.SubItems.Add(dr["Sked"].ToString());
                lv.SubItems.Add(dr["Subj"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());

                lvSchedule.Items.Add(lv);
            }

            dr.Close();
            cn.Close();
        }

    }
}
