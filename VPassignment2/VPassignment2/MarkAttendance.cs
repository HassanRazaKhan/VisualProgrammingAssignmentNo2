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
    public partial class MarkAttendance : Form
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public static string present;
        public static string absent;
        private void PresentradioButton_CheckedChanged(object sender, EventArgs e)
        {
            present = PresentradioButton.Text;
            absent = AbsenrradioButton.Text;
            if(PresentradioButton.Checked)
            {

                table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university, present);
                MarkAttendancedataGridView.DataSource = table;
            }
         
            
        }
        private void AbsenrradioButton_CheckedChanged(object sender, EventArgs e)
        {
            absent = AbsenrradioButton.Text;
            if (AbsenrradioButton.Checked)
            {
                table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university, absent);
                MarkAttendancedataGridView.DataSource = table;
            }
        }
        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            attendaneIdtextBox.Text = StudentProfile.ID;
            attendaneNametextBoxtextBox.Text = StudentProfile.name;

           
                table.Columns.Add("ID", typeof(string));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Semester", typeof(string));
                table.Columns.Add("CGPA", typeof(string));
                table.Columns.Add("Department", typeof(string));
                table.Columns.Add("University", typeof(string));
                table.Columns.Add("Attendance", typeof(string));
                MarkAttendancedataGridView.DataSource = table;

            }

      

        private void GotoMenubutton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

