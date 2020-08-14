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
    public partial class frmFacultyList : Form
    {
        //DATABASE CONNECTION
        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        String fullname;
        MemoryStream MS;
        String Selected;

        public frmFacultyList()
        {
            InitializeComponent();
        }

        //MemoryStream mem;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacultyList_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            COuntItems();
            LoadDepts();
        }

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

        private void COuntItems()
        {
            lblCount.Text = Convert.ToString(lvSchedule.Items.Count);

            if (lvSchedule.Items.Count < 1)
            {
                
                btndel.Enabled = false;
                //btnRefresh.Enabled = false;
            }
            else
            {
                btndel.Enabled = true;
                //btnRefresh.Enabled = true;
            }
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
                cboDept.Items.Add(reader["DepTitle"].ToString());
            }

            reader.Close();
            cn.Close();

        }

        private void LoadFaculty()
        {
        lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Faculty ORDER BY LName ASC";

            SqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["FacultyID"].ToString());
                lv.SubItems.Add(dr["FullName"].ToString());                
                lv.SubItems.Add(dr["Gender"].ToString());
                lv.SubItems.Add(dr["Contact"].ToString());
                lv.SubItems.Add(dr["Address"].ToString());
                //lv.SubItems.Add(dr["Room"].ToString());
                lv.SubItems.Add(dr["Department"].ToString());

                lvSchedule.Items.Add(lv);
             }

            dr.Close();
            cn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFaculty();
            lblCount.Text = Convert.ToString(lvSchedule.Items.Count);
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cboDept.Text.ToString()))
            {
                MessageBox.Show("No Department selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDept.Focus();
                return;
            }


            lvSchedule.Items.Clear();
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Faculty WHERE Department='" + cboDept.Text + "'  ORDER BY LName ASC ";

            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["FacultyID"].ToString());
                lv.SubItems.Add(dr["FullName"].ToString());
                lv.SubItems.Add(dr["Gender"].ToString());
                lv.SubItems.Add(dr["Contact"].ToString());
                lv.SubItems.Add(dr["Address"].ToString());
                //lv.SubItems.Add(dr["Room"].ToString());
                lv.SubItems.Add(dr["Department"].ToString());

                lvSchedule.Items.Add(lv);
            }

            if (lvSchedule.Items.Count < 1){
                MessageBox.Show("No Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btndel.Enabled = false;
            }
            else {
                MessageBox.Show(lvSchedule.Items.Count + " Record(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btndel.Enabled = true;
            }

            dr.Close();
            cn.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string DelRec = System.Convert.ToString(MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DelRec == Convert.ToString(DialogResult.Yes))
            {
                foreach (int i in lvSchedule.SelectedIndices)
                {
                    string Selected = lvSchedule.Items[i].Text;
                    lvSchedule.Items.Remove(lvSchedule.Items[i]);

                    cn.Open();

                    cmd.Connection = cn;

                    cmd.CommandText = "DELETE FROM Faculty WHERE FacultyID = '" + Selected + "' ";
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Record deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
                LoadFaculty();
                COuntItems();
            }
        }


        private void LoadImage()
        {
            foreach (int i in lvSchedule.SelectedIndices)
            {
                Selected = lvSchedule.Items[i].Text;

                cn.Open();

                cmd.Connection = cn;

                cmd.CommandText = "SELECT * FROM Faculty WHERE FacultyID = '" + Selected + "' ";
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "Faculty");
                int count = ds.Tables["Faculty"].Rows.Count;

                if (count > 0)
                {
                    var data = (Byte[])(ds.Tables["Faculty"].Rows[count - 1]["IMG"]);
                    MemoryStream stream = new MemoryStream(data);
                    imgPicture.Image = Image.FromStream(stream);

                    txtLName.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["LName"]);
                    txtFName.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["FName"]);
                    txtMName.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["MName"]);
                    txtAddress.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["Address"]);
                    cboGender.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["Gender"]);

                    //cn.Open();
                    cmd2.Connection = cn;

                    cmd2.CommandText = "SELECT * FROM Depts ORDER BY DepTitle ASC";


                    SqlDataReader reader = cmd2.ExecuteReader();
                    cboDept2.Items.Clear();

                    while (reader.Read())
                    {
                        cboDept2.Items.AddRange(new object[] { reader[1].ToString() });
                    }

                    reader.Close();
                    cn.Close();

                    reader.Close();
                    
                    cboDept2.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["Department"]);
                    txtContact.Text = Convert.ToString(ds.Tables["Faculty"].Rows[count - 1]["Contact"]);

                } 

                // LOAD ENDS

                cn.Close();
            }

        }

        private void lvSchedule_ItemActivate(object sender, EventArgs e)
        {
            //cboDept2.Enabled = true;
            LoadImage();
            button1.Enabled = true;
            
        }

        private void cboDept_SelectedValueChanged(object sender, EventArgs e)
        {
            lvSchedule.Items.Clear();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Faculty WHERE Department ='" + cboDept.Text + "'  ORDER BY FacultyID ASC ";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["FacultyID"].ToString());
                lv.SubItems.Add(dr["FullName"].ToString());
                lv.SubItems.Add(dr["Gender"].ToString());
                lv.SubItems.Add(dr["Contact"].ToString());
                lv.SubItems.Add(dr["Address"].ToString());
                lv.SubItems.Add(dr["Department"].ToString());

                lvSchedule.Items.Add(lv);
            }

            COuntItems();
            dr.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLName.Enabled = true;
            txtMName.Enabled = true;
            txtFName.Enabled = true;
            txtAddress.Enabled = true;
            txtContact.Enabled = true;

            btnBrowse.Enabled = true;
            btnCancel.Enabled = true;

            txtLName.Focus();
            btnUpdate.Enabled = true;
            button1.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisAble();
        }

        private void DisAble()
        {
            txtLName.Enabled = false;
            txtMName.Enabled = false;
            txtFName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;

            btnBrowse.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;

            txtLName.Text = "";
            txtMName.Text = "";
            txtFName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            cboDept.Text = "";
            cboDept.Text = "";
            cboGender.Text = "";

            imgPicture.Image = imgPicture.InitialImage;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            /*
            if (String.IsNullOrEmpty(cboGender.Text.Trim()))
            {
                MessageBox.Show("Select Gender.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboGender.Focus();
                return;
            }
            */
             
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("Address Required.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAddress.Focus();
                return;
            }


            /*
            if (String.IsNullOrEmpty(cboDept.Text.Trim()))
            {
                MessageBox.Show("Select Department.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDept.Focus();
                return;
            }
            */

            //CHECK FOR EMPTY PICTURE

            if (imgPicture.Image == imgPicture.InitialImage)
            {
                string SkipUpload = System.Convert.ToString(MessageBox.Show("Are you sure to not upload image?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (SkipUpload == Convert.ToString(DialogResult.Yes))
                {
                    btnUpdate.Focus();
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

            cmd.CommandText = "SELECT COUNT(*) FROM Faculty WHERE LName='" + txtLName.Text + "' AND FName ='" + txtFName.Text + "' AND MName ='" + txtMName.Text + "' AND Address = '" + txtAddress.Text + "' AND Contact = '" + txtContact.Text + "' AND FullName = '" + fullname + "' AND IMG = '" + imgPicture.Image  + "' ";

            var Res = cmd.ExecuteScalar();
            int RecCount = Convert.ToInt32(Res);

            if (RecCount > 0)
            {
                MessageBox.Show("No updates were made.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //rdr.Close();
                cn.Close();
                DisAble();
                //this.Close();
            }

            //UPDATE SELECTED RECORD
            else
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

                cn.Open();
                cmd.Connection = cn;

                //cmd.CommandText = "INSERT INTO Faculty (FacultyID, LName, FName, MName, Gender, Address, Contact, Department, IMG, FullName) VALUES (@FID, @LNname, @FName, @MName, @Gender, @Addr, @CP, @Dept, @photo, @FullN)";

                //SQL TO UPDATE RECORD
                cmd.CommandText = "UPDATE Faculty  SET LName = @LNname, FName = @FName, MName = @MName, Address = @Addr, Contact = @CP, IMG = @photo, FullName = @FullN WHERE FacultyID = '" + Selected + "' ";
                
                cmd.Parameters.AddWithValue("@LNname", txtLName.Text);
                cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                cmd.Parameters.AddWithValue("@MName", txtMName.Text);
                //cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@Addr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CP", txtContact.Text);
                //cmd.Parameters.AddWithValue("@Dept", cboDept.Text);

                fullname = txtLName.Text + ", " + txtFName.Text + " " + txtMName.Text;
                cmd.Parameters.AddWithValue("@FullN", fullname);
                conv_photo();

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                MessageBox.Show("Record updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisAble();
                cn.Close();
               // this.Close();
                lvSchedule.Items.Clear();
                lvSchedule.Refresh();
                LoadFaculty();

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

     }
}
