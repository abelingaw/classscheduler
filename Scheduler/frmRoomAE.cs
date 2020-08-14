using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Scheduler
{
    public partial class frmRoomAE : Form
    {
        public string mFormState;
        public int myID;

        //DATABASE CONNECTION
        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        public frmRoomAE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDept.Text.Trim()))
            {
                MessageBox.Show("Enter Department name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDept.Focus();
                return;
            }

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Depts WHERE  DepTitle ='" + txtDept.Text + "'";

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            if (rdr.HasRows)
            {
                MessageBox.Show("Duplicate Record.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rdr.Close();

                txtDept.Text = "";
            }
            else
            {
                rdr.Close();
                cmd.CommandText = "INSERT INTO Depts (DepTitle) VALUES (@DEPT)";
                cmd.Parameters.AddWithValue("@DEPT", txtDept.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Department added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
                this.Close();
            }
        }

        private void frmRoomAE_Load(object sender, EventArgs e)
        {

        }
    }
}
 

