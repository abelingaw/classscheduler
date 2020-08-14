using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Scheduler
{
    public partial class frmSectionAE : Form
    {

        //DATABASE CONNECTION
        //SqlConnection cn = new SqlConnection(@"SERVER=Database=PRODUCTION;Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Integrated Security=True;User Instance=True");
        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        String REG, SSC;

        public frmSectionAE()
        {
            InitializeComponent();
        }

        private void frmSectionAE_Load(object sender, EventArgs e)
        {
            LoadSections();
            LoadSSC();
            CountIt();
        }

        private void CountIt()
        {
            if (lvSchedule.Items.Count < 1)
            {
                //MessageBox.Show("No Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btndel.Enabled = false;
                return;
            }
            
            if (lvSchedule.Items.Count > 0)
            {
                btndel.Enabled = true;
                return;
            }


            if (lvSSC.Items.Count < 1)
            {
                //MessageBox.Show("No Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnDelSSC.Enabled = false;
                return;
            }

            if (lvSSC.Items.Count > 1)
            {
                btnDelSSC.Enabled = true;
                return;
            }
        }

        private void LoadYL()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM YearLevel";

            SqlDataReader rdr = cmd.ExecuteReader();
            cboYearLvl.Items.Clear();

            while (rdr.Read())
            {
                cboYearLvl.Items.Add(rdr["YL"].ToString());
            }
            rdr.Close();
            cn.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            //CHECK FOR NULL ENTRIES AND RETURN AN ERROR
            if (String.IsNullOrEmpty(txtSection.Text.Trim()))
            {
                MessageBox.Show("Section Required", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSection.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboYearLvl.Text.Trim()))
            {
                MessageBox.Show("Year Level Required", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboYearLvl.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboClass.Text.Trim()))
            {
                MessageBox.Show("Class Required", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboClass.Focus();
                return;
            }

            //CHECK FOR DUPLICATE RECORD
            cn.Open();
            cmd.Connection = cn;

            cmd.CommandText = "SELECT COUNT(*) FROM Sections WHERE SecTitle='" + txtSection.Text + "' ";

            var Res = cmd.ExecuteScalar();
            int RecCount = Convert.ToInt32(Res);

            if (RecCount > 0)
            {
                MessageBox.Show("This Section already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //rdr.Close();
                cn.Close();
                txtSection.Text = "";
                txtSection.Focus();
                //this.Close();
            }

            else
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO Sections (SecTitle, YearLevel, SecClass) VALUES (@ST, @YL, @SC)";
                cmd.Parameters.AddWithValue("@ST", txtSection.Text.Trim());
                cmd.Parameters.AddWithValue("@YL", cboYearLvl.Text.Trim());
                cmd.Parameters.AddWithValue("@SC", cboClass.Text.Trim());

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                MessageBox.Show("Section successully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();

                txtSection.Text = "";
                cboYearLvl.Items.Clear();
                cboClass.Text = "";
                LoadSections();
                LoadSSC();

                cmdSave.Enabled = false;
                btnNew.Enabled = true;
                groupBox1.Enabled = false;
                btnNew.Focus();
                //this.Close();

            }


        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            LoadYL();
            groupBox1.Enabled = true;
            txtSection.Focus();
            cmdSave.Enabled = true;
            btnNew.Enabled = false;
        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSections()
        {
            REG = "REGULAR";
            
            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections WHERE SecClass = '" + REG  + "' ORDER BY YearLevel ASC, SecTitle ASC";

            SqlDataReader dr = cmd.ExecuteReader();

            //var REG = dr["SecClass"].ToString();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["SecID"].ToString());
                lv.SubItems.Add(dr["SecTitle"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["SecClass"].ToString());

                lvSchedule.Items.Add(lv);
            }

            dr.Close();
            cn.Close();
        }

        private void LoadSSC()
        {
            SSC = "SSC";

            lvSSC.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections WHERE SecClass = '" + SSC + "' ORDER BY YearLevel ASC, SecTitle ASC";

            SqlDataReader dr = cmd.ExecuteReader();

            //var REG = dr["SecClass"].ToString();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["SecID"].ToString());
                lv.SubItems.Add(dr["SecTitle"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["SecClass"].ToString());

                lvSSC.Items.Add(lv);
            }

            dr.Close();
            cn.Close();
        }

        private void lvSchedule_ItemActivate(object sender, EventArgs e)
        {
            //btndel.Enabled = true;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string DelRec = System.Convert.ToString(MessageBox.Show("Are you sure to delete this section?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DelRec == Convert.ToString(DialogResult.Yes))
            {
                foreach (int i in lvSchedule.SelectedIndices)
                {
                    string Selected = lvSchedule.Items[i].Text;
                    lvSchedule.Items.Remove(lvSchedule.Items[i]);

                    cn.Open();

                    cmd.Connection = cn;

                    cmd.CommandText = "DELETE FROM Sections WHERE SecID = '" + Selected + "' ";
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Record deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
                LoadSections();
            }
        }

        private void btnDelSSC_Click(object sender, EventArgs e)
        {
            string DelRec = System.Convert.ToString(MessageBox.Show("Are you sure to delete this section?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DelRec == Convert.ToString(DialogResult.Yes))
            {
                foreach (int i in lvSSC.SelectedIndices)
                {
                    string Selected = lvSSC.Items[i].Text;
                    lvSSC.Items.Remove(lvSSC.Items[i]);

                    cn.Open();

                    cmd.Connection = cn;

                    cmd.CommandText = "DELETE FROM Sections WHERE SecID = '" + Selected + "' ";
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Record deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
                LoadSections();
            }
        }

        private void cboReg_TextChanged(object sender, EventArgs e)
        {
            REG = "REGULAR";

            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections WHERE SecClass = '" + REG + "' AND YearLevel = '" + cboReg.Text + "' ORDER BY YearLevel ASC, SecTitle ASC";

            SqlDataReader dr = cmd.ExecuteReader();

            //var REG = dr["SecClass"].ToString();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["SecID"].ToString());
                lv.SubItems.Add(dr["SecTitle"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["SecClass"].ToString());

                lvSchedule.Items.Add(lv);
            }

            dr.Close();
            cn.Close();

            if (lvSchedule.Items.Count < 1)
            {
                //MessageBox.Show("No Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btndel.Enabled = false;
                return;
            }
            else
            {
                btndel.Enabled = true;
                return;
            }

        }

        private void cboSCC_TextChanged(object sender, EventArgs e)
        {
            SSC = "SSC";

            lvSSC.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections WHERE SecClass = '" + SSC + "' AND YearLevel = '" + cboSCC.Text + "' ORDER BY YearLevel ASC, SecTitle ASC";

            SqlDataReader dr = cmd.ExecuteReader();

            //var REG = dr["SecClass"].ToString();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["SecID"].ToString());
                lv.SubItems.Add(dr["SecTitle"].ToString());
                lv.SubItems.Add(dr["YearLevel"].ToString());
                lv.SubItems.Add(dr["SecClass"].ToString());

                lvSSC.Items.Add(lv);
            }

            dr.Close();
            cn.Close();

            if (lvSSC.Items.Count < 1)
            {
                //MessageBox.Show("No Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnDelSSC.Enabled = false;
                return;
            }

            else
            {
                btnDelSSC.Enabled = true;
                return;
            }
        }


    }
}
