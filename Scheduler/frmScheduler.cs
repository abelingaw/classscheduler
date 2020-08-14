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
    public partial class frmScheduler : Form
    {
        //DATABASE CONNECTION
        SqlConnection cn = new SqlConnection(@"SERVER =.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DBase.mdf;Database=DBase;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        String SECT, SKD, FCT, TS, TE, DAY;

        public int myID,sYearID,sYearLevel;
        public int sDay, sDay1,sDay2;
        public string sSubjectCode,mFormState;

        String Sked, SC, SCHED, YL, FCTY;        

        public frmScheduler()
        {
            InitializeComponent();
        }

        public bool FacultyInUse()
        {
            
            //OleDbCommand com = new OleDbCommand("Select * from qrySubjectOfferring Where cTimeIn >=#" + cboFrom.Text + "# and cTimeOut <=#" + cboTo.Text + "# and Faculty like'" + cboFaculty.Text + "%' and cDay Like '%" + cboDay.Text + "%'", clsCon.con);
            
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects WHERE TimeStart >=#" + cboFrom.Text + "# and TimeEnd <=#" + cboTo.Text + "# AND Faculty LIKE'" + cboFaculty.Text + "%'";
            
            //OleDbDataReader dr = com.ExecuteReader();

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            if (rdr.HasRows)
                { 
                    return true; 
                }
            else
                { 
                    return false; 
                }
        }

        public bool RoomInUse()
        {
            //OleDbCommand com = new OleDbCommand("Select * from qrySubjectOfferring Where cTimeIn >=#" + cboFrom.Text + "# and cTimeOut <=#" + cboTo.Text + "# and cRoom like'%" + cboRoom.Text + "%' and cDay like '%" + cboDay.Text + "%'", clsCon.con);
           
            cn.Open();
            cmd.Connection = cn;
            //cmd.CommandText = "SELECT * FROM Subjects WHERE TimeStart >=#" + cboFrom.Text + "# and TimeEnd <=#" + cboTo.Text + "# AND Room LIKE'" + cboRoom.Text + "%' ";

            //OleDbDataReader dr = com.ExecuteReader();

            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            if (rdr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void DisplayLabelConflictForFaculty()
        {
            if (lvSchedule.Items.Count >= 1)
            {
                txtStatus.Text = "Conflict Schedules For: " + cboFaculty.Text;
            }
            else
            {
                txtStatus.Text = "NO CONFLICT(S) FOUND.";
            }
        }

        
        void ClearItems()
        {
            //cboFaculty.Text = "";
            txtSubject.Text = "";
            cboFrom.Text = "";
            cboTo.Text = "";
            cboYL.Text = "";
            cboClass.Text = "";
            groupBox1.Enabled = false;

        }

        
        private void LoadRooms()
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Rooms";
           
            SqlDataReader rdr = cmd.ExecuteReader();
            //cboFaculty.Items.Clear();

            while (rdr.Read())
            {
               // cboRoom.Items.Add(rdr["Room"].ToString());
            }
            rdr.Close();
            cn.Close();
        }

       

        private void DisplayAddSchedule(string sFaculty)
        {

            Random randonGen = new Random();
            //OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjectOfferring Where Faculty Like'" + sFaculty + "%'", clsCon.con);
            
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects WHERE Faculty LIKE'" + sFaculty + "%'";

            SqlDataReader dr = cmd.ExecuteReader();
            
            lvSchedule.Items.Clear();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subj"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["Room"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());
                lv.ForeColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                lvSchedule.Items.AddRange(new ListViewItem[] { lv });
                
            }
            dr.Close();
        }


       
        private void frmScheduler_Load(object sender, EventArgs e)
        {
            
            LoadScheds();
           // LoadConflicts();
            LoadTeachers();
            //LoadRooms();
            LoadSections();
            //LoadYL();
            //cn.Close();
           
        }

        private void LoadScheds()
        {
            lvSchedule.Items.Clear();

            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects ORDER BY TimeStart";

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["Sked"].ToString());

                    item.SubItems.Add(rdr["Subj"].ToString());
                    item.SubItems.Add(rdr["Section"].ToString());
                    item.SubItems.Add(rdr["YearLevel"].ToString());
                    item.SubItems.Add(rdr["Faculty"].ToString());
                    item.SubItems.Add(rdr["SecClass"].ToString());

                    lvSchedule.Items.Add(item);

                }
                rdr.Close();
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void LoadConflicts()
        {
            //lvConflicts.Items.Clear();

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            cn.Open();

            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Subjects";

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["Sked"].ToString());

                    //String Sked, SC, SCHED, YL, SBJ, FCTY; 

                   // SBJ = rdr["Subj"].ToString();
                    YL = rdr["Section"].ToString();
                    FCTY = rdr["Faculty"].ToString();
                    SCHED = rdr["Sked"].ToString();

              
                    cmd2.Connection = cn;
                    cmd2.CommandText = "SELECT * FROM Subjects WHERE Sked = '" + SCHED  + "' AND Yearlevel ='" + YL + "' AND Faculty = '" + FCTY + "' ";
                   
                    try
                    {
                        //SqlDataReader dr = cmd2.ExecuteReader();

                        while (rdr.Read())
                        {
                            ListViewItem item2 = new ListViewItem(rdr["Sked"].ToString());

                            item2.SubItems.Add(rdr["Subj"].ToString()).ForeColor = Color.Red; ;
                            item2.SubItems.Add(rdr["Section"].ToString());
                            item2.SubItems.Add(rdr["YearLevel"].ToString());
                            item2.SubItems.Add(rdr["Faculty"].ToString());
                            item2.SubItems.Add(rdr["SecClass"].ToString());

                            lvConflicts.Items.Add(item2);
                        }
                        var CNT = lvConflicts.Items.Count;
                        MessageBox.Show("There are " + CNT + " conflict(s) found.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                //rdr.Close();
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            cmdSave.Enabled = true;
            btnNew.Enabled = false;

            txtSubject.Focus();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            //string sSQL = "Select * from qrySubjectOfferring Where [cTimeIn] >= #" + cTimeIn + "# and [cTimeOut] <= #" + cTimeOut + "# and [Faculty] like'%" + cFaculty + "%' and [Subject] like '%" + cSubject + "%' and [cRoom] like '%" + cRoom + "%' and [cDay] like '%" + cDay + "%'";
           
            //CHECK NULL ENTRIES

            if (String.IsNullOrEmpty(txtSubject.Text.Trim()))
            {
                MessageBox.Show("Enter Subject Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSubject.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboSection.Text.Trim()))
            {
                MessageBox.Show("Select Section.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSection.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboFaculty.Text.Trim()))
            {
                MessageBox.Show("Select Adviser.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFaculty.Focus();
                return;
            }

            
            if (String.IsNullOrEmpty(cboFrom.Text.Trim()))
            {
                MessageBox.Show("Select Start Time.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboFrom.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboTo.Text.Trim()))
            {
                MessageBox.Show("Select End Time.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTo.Focus();
                return;
            }


            if (String.IsNullOrEmpty(cboYL.Text.Trim()))
            {
                MessageBox.Show("Select Year Level.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboYL.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboClass.Text.Trim()))
            {
                MessageBox.Show("Select Class.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboClass.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboDay.Text.Trim()))
            {
                MessageBox.Show("Select Day.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDay.Focus();
                return;
            }


            //CHECK FOR CONFLICTING SCHEDULES
            cn.Open();
            cmd.Connection = cn;
            cmd2.Connection = cn;

            //
            cmd2.CommandText = "SELECT * FROM Subjects WHERE [Section] ='" + cboSection.Text + "' AND [TimeStart] ='" + cboFrom.Text + "' AND [TimeEnd] ='" + cboTo.Text + "' OR [Faculty] ='" + cboFaculty.Text + "' AND Day = '" + cboDay.Text + "' ";

                SqlDataReader rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {

                      SECT =  rdr["Section"].ToString();
                      SKD = rdr["Sked"].ToString();
                      FCT = rdr["Faculty"].ToString();
                      TS = rdr["TimeStart"].ToString();
                      TE = rdr["TimeEnd"].ToString();
                      DAY = rdr["Day"].ToString();

                }
                rdr.Close();
               

            //



            String Sked2 = cboFrom.Text + "-" + cboTo.Text + " " + cboDay.Text;

            //cmd.CommandText = "SELECT COUNT(*) FROM Subjects WHERE [Section] ='" + cboSection.Text + "' AND [TimeStart] ='" + cboFrom.Text + "' AND [TimeEnd] ='" + cboTo.Text + "' AND [Faculty] ='" + cboFaculty.Text + "'";
            //cmd.CommandText = "SELECT * FROM Subjects WHERE [TimeStart] >= '#" + cboFrom.Text + "# AND [TimeEnd] <= #" + cboTo.Text + "# AND [Faculty] =" + cboFaculty.Text + " AND [Subj] =" + txtSubject.Text + " AND [Room] LIKE =" + cboRoom.Text + "'";

            cmd.CommandText = "SELECT * FROM Subjects WHERE [Section] ='" + cboSection.Text + "' AND [TimeStart] ='" + cboFrom.Text + "' AND [TimeEnd] ='" + cboTo.Text + "' OR [Faculty] ='" + cboFaculty.Text + "' AND Day = '" + cboDay.Text + "' ";

            //SqlDataReader rdr = cmd.ExecuteReader();
            //rdr.Read();

            var Res = cmd.ExecuteScalar();
            int RecCount = Convert.ToInt32(Res);

            if (RecCount > 0)
            {
                MessageBox.Show("Schedule Conflict. Check schedule details.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //rdr.Close();
                cn.Close();
                txtSubject.Text = "";
                txtSubject.Focus();
                return;
            }

            else
            {
               //rdr.Close();
                cn.Close();
                Sked = cboFrom.Text.ToString() + "-" + cboTo.Text.ToString() + " " + cboDay.Text.ToString();

                //GenSID();

                cn.Open();
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO Subjects (Subj, Section, Faculty, Day, TimeStart, TimeEnd, Sked, YearLevel, SecClass) VALUES (@Sub, @Sec, @Fac, @Day, @START, @END, @sked, @YL, @SC)";
                //cmd.Parameters.AddWithValue("@SID", txtFacultyID.Text);
                cmd.Parameters.AddWithValue("@Sub", txtSubject.Text);
                cmd.Parameters.AddWithValue("@Sec", cboSection.Text);
                cmd.Parameters.AddWithValue("@Fac", cboFaculty.Text);
                cmd.Parameters.AddWithValue("@Day", cboDay.Text);
                cmd.Parameters.AddWithValue("@START", cboFrom.Text);
                cmd.Parameters.AddWithValue("@END", cboTo.Text);
                cmd.Parameters.AddWithValue("@sked", Sked);
                cmd.Parameters.AddWithValue("@YL", cboYL.Text);
                cmd.Parameters.AddWithValue("@SC", cboClass.Text);

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();


                MessageBox.Show("Schedule Successully Added.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cn.Close();
                lvSchedule.Refresh();
                ClearItems();
                LoadScheds();
                cmdSave.Enabled = false;
                btnNew.Enabled = true;
                //this.Close();
            }
        }

        

        private void LoadSections()
        {
            
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections ORDER BY YearLevel";

            SqlDataReader rdr = cmd.ExecuteReader();
            cboSection.Items.Clear();

            while (rdr.Read())
            {
                cboSection.Items.Add(rdr["SecTitle"].ToString());
            }
            rdr.Close();
            cn.Close();
             
        }

        private void LoadTeachers()
        {
            cn.Open();
            cmd.Connection = cn;
            /*
            cmd.CommandText = "SELECT * FROM Faculty";

            SqlDataReader rdr = cmd.ExecuteReader();
            //String x;

            cboFaculty.Items.Clear();

            while (rdr.Read())
            {
                cboFaculty.Items.Add(rdr["LName"].ToString() + ", " + rdr["FName"].ToString() + " " + rdr["MName"].ToString());
                //cboFaculty.Items.Add(rdr["FullName"].ToString());
            }
            
            rdr.Close();
             */
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Faculty ORDER BY FacultyID ASC", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboFaculty.DataSource = ds.Tables[0];
            cboFaculty.DisplayMember = "FullName";

            cn.Close();
        }

        private void GenSID()
        {

            cn.Open();
            cmd.Connection = cn;

            cmd.CommandText = "SELECT COUNT (*) FROM Subjects";
            int COUNT = Convert.ToInt16(cmd.ExecuteScalar()) + 1;

            txtFacultyID.Text = "SUBJECT-" + DateTime.Now.Year + "-00" + COUNT.ToString();
            //txtFacultyID.Enabled = false;

            cn.Close();
        }

        private void cboSection_Leave(object sender, EventArgs e)
        {

            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Sections WHERE SecTitle = '" + cboSection.Text  + "' ORDER BY SecID";

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                YL = rdr["YearLevel"].ToString();
                SC = rdr["SecClass"].ToString();

                cboYL.Text = YL;
                cboClass.Text = SC;

            }

            rdr.Close();
            cn.Close();
        }


     }
}
