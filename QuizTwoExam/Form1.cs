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

namespace QuizTwoExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("First Name Cannot be empty!!");
            }
            if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Last Name Cannot be empty!!");
            }
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Telephone Cannot be empty!!");
            }

            FileStream userFile = new FileStream(@"C:\Users\1896153\source\repos\QuizTwoExam\QuizTwoExam\users.txt", FileMode.Append);

            StreamWriter sw = new StreamWriter(userFile);

            User newUser = new User(textBox1.Text, textBox2.Text, textBox3.Text);

            sw.Write(newUser.ToString());

            sw.Close();
            
        } //Last of Register

        private void btnCountOfUser_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\1896153\source\repos\QuizTwoExam\QuizTwoExam\users.txt")) { 
            StreamReader sr = new StreamReader(@"C:\Users\1896153\source\repos\QuizTwoExam\QuizTwoExam\users.txt");
            int i = sr.ReadToEnd().Split(new char[] { '\n' }).Length;
            
            MessageBox.Show("Total Users: " + Convert.ToString(i-1));

            sr.Close();
            } else
            {
                MessageBox.Show("No user added...");
            }

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            
            File.Delete(@"C:\Users\1896153\source\repos\QuizTwoExam\QuizTwoExam\users.txt");
            MessageBox.Show("All Users Deleted...");
        }
    }
}
