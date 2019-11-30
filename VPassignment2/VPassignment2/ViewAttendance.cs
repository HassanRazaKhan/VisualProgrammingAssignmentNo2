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
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void ViewAttendancebutton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(StudentProfile.ID, StudentProfile.name, StudentProfile.semester, StudentProfile.CGPA, StudentProfile.department, StudentProfile.university, MarkAttendance.absent);
            ViewAttendancedataGridView.DataSource = table;
        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Semester", typeof(string));
            table.Columns.Add("CGPA", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("University", typeof(string));
            table.Columns.Add("Attendance", typeof(string));
            ViewAttendancedataGridView.DataSource = table;
        }
    }
}
