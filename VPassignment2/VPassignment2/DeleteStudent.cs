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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Semester", typeof(string));
            table.Columns.Add("CGPA", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("University", typeof(string));
            DeletedataGridView.DataSource = table;

            table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university);
            DeletedataGridView.DataSource = table;

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int rowIndex = DeletedataGridView.CurrentCell.RowIndex;
            DeletedataGridView.Rows.RemoveAt(rowIndex);

            MessageBox.Show("Successfully Deleted!");
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
