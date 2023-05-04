using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> users = new List<string>() {"mohamed@gmail.com","ahmed","samy" };
            List<string> passes = new List<string>() { "123", "345", "12345" };

            if(users.Contains(textBox1.Text) && passes.Contains(textBox2.Text))
            {
                var i = users.IndexOf(textBox1.Text);
                var j = passes.IndexOf(textBox2.Text);
                if (i == j)
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your password or Users name is wrong mashy");
                }

            }
            else
            {
                MessageBox.Show("Your password or Users name is wrong mashy");
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> users = new List<string> { "Jamil", "Ali", "Amir" };
            List<string> passes = new List<string> { "123", "231", "456" };

            if (users.Contains(textBox3.Text) && passes.Contains(textBox4.Text))
            {
                var k = users.IndexOf(textBox3.Text);
                var l = passes.IndexOf(textBox4.Text);
                if (k == l)
                {
                    Form3 f1 = new Form3();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Text");
                }
            }
        
            }
        }
    }

