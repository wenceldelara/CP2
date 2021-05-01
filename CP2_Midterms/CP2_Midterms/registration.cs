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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            MaximizeBox = false;
            numericUpDown1.ResetText();
        }
        int sex;
        String sex_x;
        int year;
        String year_x;
        int sem;
        String sem_x;
        int status;
        String status_x;

        public static string last_e;
        public static string first_e;
        public static string mi_e;
        public static string age_e;
        public static string sex_e;
        public static string birthdate_e;
        public static string address_e;
        public static string email_e;
        public static string contact_e;
        public static string year_e;
        public static string sem_e;
        public static string status_e;

        private void button1_Click(object sender, EventArgs e)
        {
            String first = textBox1.Text;
            String second = textBox2.Text;
            String mi = textBox3.Text;
            String age = Convert.ToString(numericUpDown1.Value);
            String birthdate = dateTimePicker1.Value.ToShortDateString();
            String address = textBox4.Text;
            String mail = textBox5.Text;
            String contact = textBox6.Text;

            switch(sex)
            {
                case 1:
                    sex_x = "Male";
                    break;
                case 2:
                    sex_x = "Female";
                    break;
                default:
                    sex_x = "N/A";
                    break;
            }
            switch(year)
            {
                case 1:
                    year_x = "1st Year";
                    break;
                case 2:
                    year_x = "2nd Year";
                    break;
                case 3:
                    year_x = "3rd Year";
                    break;
                case 4:
                    year_x = "4th Year";
                    break;
                default:
                    year_x = "N/A";
                    break;
            }
            switch(sem)
            {
                case 1:
                    sem_x = "1st Semester";
                    break;
                case 2:
                    sem_x = "2nd Semester";
                    break;
                default:
                    sem_x = "N/A";
                    break;
            }
            switch(status)
            {
                case 1:
                    status_x = "Regular";
                    break;
                case 2:
                    status_x = "Irregular";
                    break;
                default:
                    status_x = "N/A";
                    break;
            }

            //user data
            last_e = textBox1.Text;
            first_e = textBox2.Text;
            mi_e = textBox3.Text;

            String conv_age = Convert.ToString(numericUpDown1.Value);
            age_e = conv_age;

            sex_e = sex_x;

            String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            birthdate_e = theDate;

            address_e = textBox4.Text;
            email_e = textBox5.Text;
            contact_e = textBox6.Text;

            year_e = year_x;
            sem_e = sem_x;
            status_e = status_x;
            //end user data

            if (first.Equals("") | second.Equals("") | mi.Equals("") | age.Equals("") |
                birthdate.Equals("") | address.Equals("") | mail.Equals("") | contact.Equals("") |
                sex == 0 | year == 0 | sem == 0 | status == 0)
            {
                MessageBox.Show("Registration form incomplete");
            }
            else
            {
                if(status_x.Equals("Regular"))
                {
                    this.Hide();
                    enrollment enrol = new enrollment();
                    enrol.ShowDialog();
                    this.Close();
                }
                else if(status_x.Equals("Irregular"))
                {

                    this.Hide();
                    Irregular irreg = new Irregular();
                    irreg.ShowDialog();
                    this.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                sex = 1;
            }
            else
            {
                sex = 0;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                sex = 2;
            }
            else
            {
                sex = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                year = 1;
            }
            else
            {
                year = 0;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                year = 2;
            }
            else
            {
                year = 0;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                year = 3;
            }
            else
            {
                year = 0;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                year = 4;
            }
            else
            {
                year = 0;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                sem = 1;
            }
            else
            {
                sem = 0;
            }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                sem = 2;
            }
            else
            {
                sem = 0;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                status = 2;
            }
            else
            {
                status = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            numericUpDown1.ResetText();
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
        }
    }
}
