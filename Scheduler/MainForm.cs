using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Scheduler
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern long GetPrivateProfileString(string lpApplicationName, object lpKeyName, string lpDefault, string lpReturnedString, long nSize, string lpFileName);

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void manageSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectionAE sections = new frmSectionAE();
            sections.ShowDialog();
        }

        private void classRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduler Fsched = new frmScheduler();
            Fsched.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyAE FFaculty = new frmFacultyAE();
            FFaculty.ShowDialog();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomAE FFRoom = new frmRoomAE();
            FFRoom.ShowDialog();
        }

        private void schedulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFacultySchedule faculty = new frmFacultySchedule();
            //faculty.MdiParent = this;
            faculty.WindowState = FormWindowState.Normal;
            faculty.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyList fList = new frmFacultyList();
            //faculty.MdiParent = this;
            fList.WindowState = FormWindowState.Normal;
            fList.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmScheduler frmSch = new frmScheduler();
            frmSch.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmFacultyAE frFact = new frmFacultyAE();
            frFact.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmFacultySchedule Sked = new frmFacultySchedule();
            Sked.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSectionAE frmSAE = new frmSectionAE();
            frmSAE.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmFacultyList fList = new frmFacultyList();
            fList.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomAE frmDept = new frmRoomAE();
            frmDept.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
