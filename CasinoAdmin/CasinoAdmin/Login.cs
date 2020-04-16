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
    public partial class Login : Form
    {
        
        public static String admin_user="";
        public static String user = "";
        public static String password="";
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == "" || password == "")
            {
                MessageBox.Show("username or password has been left blank");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Test;Integrated Security=True");
                String command = $"select user_id from users where user_id='{user}' and password = '{password}'";
               
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    
                   if(da.GetValue(0).ToString() == user)
                    {
                        MessageBox.Show("Login Successful");
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                sqlCon.Close();
            }
        }
    }
}
