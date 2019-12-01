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

        private void Addmorebutton_Click_1(object sender, EventArgs e)
        {
            IDtextBox.Clear();
            NametextBox.Clear();
            SemestertextBox.Clear();
            CGPAtextBox.Clear();
            DepartmenttextBox.Clear();
            UniversitytextBox.Clear();
        }

        public static int size;
       

        private void GotoMenubutton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void Addmorebutton_Click(object sender, EventArgs e)
        {
           

        }
       
           
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var filestream = @"C:\Users\Hassan Raza Khan\Source\Repos\HassanRazaKhan\VisualProgrammingAssignmentNo2\VPassignment2\VPassignment2\bin\Debug\Assignment2.txt";
            using (StreamWriter sw = File.AppendText(filestream))
            {
                ID = IDtextBox.Text;
                name = NametextBox.Text;
                semester = SemestertextBox.Text;
                CGPA = CGPAtextBox.Text;
                department = DepartmenttextBox.Text;
                university = UniversitytextBox.Text;
                sw.WriteLine(ID);
                sw.WriteLine(name);
                sw.WriteLine(semester);
                sw.WriteLine(CGPA);
                sw.WriteLine(department);
                sw.WriteLine(university);
                sw.Flush();
                sw.Close();
            }
        }
        }
    }

