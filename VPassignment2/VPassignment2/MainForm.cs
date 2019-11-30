using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPassignment2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StudentProfilebutton_Click(object sender, EventArgs e)
        {
            StudentProfile sf = new StudentProfile();
            this.Hide();
            sf.Show();
        }

        private void SearchStudentbutton_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            this.Hide();
            ss.Show();
        }

        private void DeleteStudentbutton_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            this.Hide();
            ds.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MarkAttendancebutton_Click(object sender, EventArgs e)
        {
            MarkAttendance ma = new MarkAttendance();
            this.Hide();
            ma.Show();
        }

        private void ViewAttendancebutton_Click(object sender, EventArgs e)
        {
            ViewAttendance va = new ViewAttendance();
            this.Hide();
            va.Show();
        }
    }
}
