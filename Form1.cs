using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsApplications
{
    public partial class Form1 : Form
    {
        private object i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList monthsList = new ArrayList();

            monthsList.Add("January");
            monthsList.Add("Febuary");
            monthsList.Add("March");
            monthsList.Add("April");
            monthsList.Add("May");
            monthsList.Add("June");
            monthsList.Add("July");
            monthsList.Add("August");
            monthsList.Add("September");
            monthsList.Add("October");
            monthsList.Add("November");
            monthsList.Add("December");

            foreach (string month in monthsList)
            {
                comboBox1.Items.Add(month);
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for (int i = 2024; i >= 1980; i--)
            {
                comboBox3.Items.Add(i.ToString());
            }

            ArrayList ProgramList = new ArrayList();

            ProgramList.Add("Bacheolor of Science in Information Technology");
            ProgramList.Add("Bacheolor of Science in Computer Science");
            ProgramList.Add("Bacheolor of Science in Information System");
            ProgramList.Add("Bacheolor of Science in Accounting Information System");
            ProgramList.Add("Bacheolor of Science in Computer Engineering");

            foreach (string Program in ProgramList)
            {
                comboBox4.Items.Add(Program);
            }
        }

        public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string program)
        {
            MessageBox.Show("Student Name" + Lastname + ", " + FirstName + MiddleName + "\nProgram" + program);
        }

        public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string Gender, string program)
        {
            MessageBox.Show("Student Name" + Lastname + ", " + FirstName + MiddleName + "\nGender" + Gender + "\nProgram");
        }

        public void DisplayInfo(string Lastname, string FirstName, string MiddleName, string Gender, string month, string day, string year, string program)
        {
            MessageBox.Show("Student Name: " + Lastname + "," + FirstName + " " + MiddleName + "\nGeder: " + Gender +
               "\nDate of Birth: " + month + "/" + day + "/" + year + "\nProgram: " + program);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lastname, FirstName, MiddleName, Gender; 
            

            Lastname = txtLASTNAME.Text;
            FirstName = txtFIRSTNAME.Text;
            MiddleName = txtMIDDLENAME.Text;

            Gender = radioButton1.Checked == true ? "Male" : "Female";
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string day = comboBox2.GetItemText(comboBox2.SelectedItem);
            string year = comboBox3.GetItemText(comboBox3.SelectedItem);
            string program = comboBox4.GetItemText(comboBox4.SelectedItem);

            DisplayInfo( Lastname, FirstName, MiddleName, program);
            DisplayInfo(Lastname, FirstName, MiddleName, Gender, program);
            DisplayInfo(Lastname, FirstName, MiddleName, Gender, month, day, year, program);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
