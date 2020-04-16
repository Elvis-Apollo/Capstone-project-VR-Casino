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
        public partial class Test : Form
    {
        public static String slot_machine="" ;
        public static String outcome = "";
        public static String env_type = "";
        public static int trial_num = 1;
        public static String[] results= new String[10];
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            slot_machine = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) env_type = "calm";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) env_type = "chaos";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) outcome = "win";
        }
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (outcome == "" || env_type == "" || slot_machine == "")
            {
                MessageBox.Show("One or more fields are empty");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Test;Integrated Security=True");
                String command = $"INSERT INTO slot (slot_session_id, outcome,outcome_no, slot_type) VALUES({2},'{outcome}',{trial_num},{slot_machine})";
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                trial_num++;
                //MessageBox.Show($"User With Details username:{username}, password:{password}, user type:{userType} has been registered");
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked) outcome = "loss";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) outcome = "near_miss";
        }
    }
}
