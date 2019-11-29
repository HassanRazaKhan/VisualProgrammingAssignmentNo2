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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }
        public static string ID, name, semester, CGPA, department, university;

        private void GotoMenubutton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void Addmorebutton_Click(object sender, EventArgs e)
        {
            StudentProfile sf = new StudentProfile();
            sf.Show();
            this.Dispose(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Assignment2.txt");
            ID = IDtextBox.Text;
            name = NametextBox.Text;
            semester = SemestertextBox.Text;
            CGPA = CGPAtextBox.Text;
            department = DepartmenttextBox.Text;
            university = UniversitytextBox.Text;
            sw.WriteLine(ID + "\t" + name + "\t" + semester + "\t" + CGPA + "\t" + department + "\t" + university);
            sw.Flush();
            sw.Close();
        }
    }
}
