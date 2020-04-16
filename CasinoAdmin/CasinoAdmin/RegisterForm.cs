using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
namespace CasinoAdmin
{
    public partial class RegisterForm : Form
    {
        // variables for registering a new user
        public static String username="";
        public static String password="";
        public static String pw2="";
        public static String userType="";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // anytime the text changes save the new password in username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password != pw2)
            {
                MessageBox.Show("Passowrds do not match");
            }
            else if (username == ""|| password=="")
            {
                MessageBox.Show("Username/Password cannot be left blank");
            }
            else if (userType == "")
            {
                MessageBox.Show("Please Select a user type");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Test;Integrated Security=True");
                String command = $"INSERT INTO users (user_id, password,user_role) VALUES('{username}','{password}','{userType}')";
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show($"User With Details username:{username}, password:{password}, user type:{userType} has been registered");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pw2 = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) userType = "admin";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) userType = "user";
        }
    }
}
