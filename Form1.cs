using System;
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
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 2024; i >= 1950; i--)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lastname, FirstName, MiddleName, Gender, Month, Day, Year; 
            

            Lastname = txtLASTNAME.Text;
            FirstName = txtFIRSTNAME.Text;
            MiddleName = txtMIDDLENAME.Text;

            Gender = radioButton1.Checked == true ? "Male" : "Female";
            string month = comboBox1.GetItemText(comboBox3.SelectedItem);
            string day = comboBox2.GetItemText(comboBox1.SelectedItem);
            string year = comboBox3.GetItemText(comboBox2.SelectedItem);
          

            MessageBox.Show("Student Name: " + Lastname + "," + FirstName + " " + MiddleName + "\nGeder: " + Gender + "\nDate of Birth: " + month + "/" + day + "/" + year);
        }
    }
}
