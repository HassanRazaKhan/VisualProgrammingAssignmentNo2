using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VPassignment2
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public static string search;
        private void Searchbutton_Click(object sender, EventArgs e)
        {

           
            if (SearchByIDradioButton.Checked)
            {
                search = SearchtextBox.Text;
                if (search == StudentProfile.ID)
                {

                    table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university);
                    SearchdataGridView.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Invalid Search, Try Again!");
                }

            }
            else if(SearchByNameradioButton.Checked)
            {
                search = SearchtextBox.Text;
                if (search == StudentProfile.name)
                {
                    table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university);
                    SearchdataGridView.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Invalid Search, Try Again!");
                }
            }
          
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Semester", typeof(string));
            table.Columns.Add("CGPA", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("University", typeof(string));
            SearchdataGridView.DataSource = table;
        }

        private void GotoMenubutton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void AllStudentsradioButton_CheckedChanged(object sender, EventArgs e)
        {

            table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university);
            SearchdataGridView.DataSource = table;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
