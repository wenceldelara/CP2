using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP2_Midterms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username.Equals("a") & password.Equals("1"))
            {
                this.Hide();
                registration reg = new registration();
                reg.ShowDialog();
                this.Close();
            }
            else
            {
                textBox3.Text = "Incorrect username and password, try again";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
