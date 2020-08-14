using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;


namespace Scheduler
{
    public partial class frmFacultyAE : Form
    {

        //DATABASE CONNECTION
        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        String fullname;
        int COUNT;

        public frmFacultyAE()
        {
            InitializeComponent();
        }

        MemoryStream MS;

        //GENERATE NEW FACULTY ID
        private void GenId()
        {

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT COUNT (*) FROM Faculty";
            COUNT = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

            txtFacultyID.Text = "FACULTY-" + DateTime.Now.Year + "-00" + COUNT.ToString();
            txtFacultyID.Enabled = false;

            cn.Close();
        }


       private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnNew.Enabled = false;
            btnBrowse.Enabled = true;

            txtLName.Enabled = true;
            txtFName.Enabled = true;
            txtMName.Enabled = true;
            cboGender.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            cboDept.Enabled = true;

            LoadDepts();
            txtLName.Focus();

        }

        //PHOTO CONVERT
       void conv_photo()
       {
           //converting photo to binary data
           if (imgPicture.Image != null)
           {
               //using MemoryStream:
               MS = new MemoryStream();
               imgPicture.Image.Save(MS, ImageFormat.Jpeg); 
               byte[] photo_aray = new byte[MS.Length];
               MS.Position = 0;
               MS.Read(photo_aray, 0, photo_aray.Length);
               cmd.Parameters.AddWithValue("@photo", photo_aray);
           }
       }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //CHECK FOR NULL ENTRIES AND RETURN AN ERROR
            if (String.IsNullOrEmpty(txtLName.Text.Trim()))
                {
                    MessageBox.Show("Lastname Required", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLName.Focus();
                    return;
                }

            if (String.IsNullOrEmpty(txtFName.Text.Trim()))
            {
                MessageBox.Show("Firstname Required", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFName.Focus();
                return;
            }


            if (String.IsNullOrEmpty(cboGender.Text.Trim()))
                {
                    MessageBox.Show("Select Gender.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboGender.Focus();
                    return;
                }

            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
                {
                    MessageBox.Show("Address Required.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                    return;
                }

            if (String.IsNullOrEmpty(cboDept.Text.Trim()))
            {
                MessageBox.Show("Select Department.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDept.Focus();
                return;
            }

            //CHECK FOR EMPTY PICTURE

            if (imgPicture.Image == imgPicture.InitialImage)
            {
                string SkipUpload = System.Convert.ToString(MessageBox.Show("Are you sure to not upload image?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (SkipUpload == Convert.ToString(DialogResult.Yes))
                {
                    btnSave.Focus();
                    return;
                }
                else
                {
                    openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                    DialogResult res = openFileDialog1.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        imgPicture.Image = Image.FromFile(openFileDialog1.FileName);
                    }
                }
            }
            
            //CHECKING ENDS HERE

            cn.Open();  
            cmd.Connection = cn;

            cmd.CommandText = "SELECT COUNT(*) FROM Faculty WHERE LName='" + txtLName.Text + "' AND FName ='" + txtFName.Text + "' AND MName ='" + txtMName.Text + "'";
            
            var Res = cmd.ExecuteScalar();
            int RecCount = Convert.ToInt32(Res);

            if (RecCount > 0)
            {
                MessageBox.Show("This record already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //rdr.Close();
                cn.Close();
                this.Close();
            }
            
            //SAVE RECORD TO DATABASE
            else
            {

                cn.Close();
                GenId();

                cn.Open();
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO Faculty (FacultyID, LName, FName, MName, Gender, Address, Contact, Department, IMG, FullName) VALUES (@FID, @LNname, @FName, @MName, @Gender, @Addr, @CP, @Dept, @photo, @FullN)";
                cmd.Parameters.AddWithValue("@FID", txtFacultyID.Text);
                cmd.Parameters.AddWithValue("@LNname", txtLName.Text);
                cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                cmd.Parameters.AddWithValue("@MName", txtMName.Text);
                cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@Addr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CP", txtContact.Text);
                cmd.Parameters.AddWithValue("@Dept", cboDept.Text);

                fullname = txtLName.Text + ", " + txtFName.Text + " " + txtMName.Text;
                cmd.Parameters.AddWithValue("@FullN", fullname);
                conv_photo();

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                MessageBox.Show("Record successully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
                this.Close();

            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                imgPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacultyAE_Load(object sender, EventArgs e)
        {
            txtLName.Enabled = false;
            txtMName.Enabled = false;
            txtFName.Enabled = false;
            cboGender.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            cboDept.Enabled = false;

            btnBrowse.Enabled = false;
            btnSave.Enabled = false;
            LoadDepts();

        }

        private void LoadDepts()
        { 
            cn.Open();  
            cmd.Connection = cn;

            cmd.CommandText = "SELECT * FROM Depts ORDER BY DepTitle ASC";


            SqlDataReader reader = cmd.ExecuteReader();
            cboDept.Items.Clear();

            while (reader.Read())
            {
                cboDept.Items.AddRange(new object[] { reader[1].ToString() });
            }
            
            reader.Close();
            cn.Close();


        }

    }
}
