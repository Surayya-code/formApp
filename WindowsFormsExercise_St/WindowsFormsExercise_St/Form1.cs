using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise_St
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

            string fullName = name +" "+ surname;

            richTextBoxSiyahi.Text=fullName;

        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            string fileName = "Students.txt";
            File.AppendAllText(fileName, $"{richTextBoxSiyahi.Text}{Environment.NewLine}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "Students.txt";
            if(File.Exists(fileName))
            {
            richTextBoxSiyahi.Text= File.ReadAllText(fileName);
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string fileName = "Students.txt";
            File.Delete(fileName);
        }
    }
}
