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
        public static String session_id = "";
        public static int session = 0;
        public static DateTime now = DateTime.Now;
        public static String[] results= new String[10];
        public Test()
        {
          
           
                InitializeComponent();
                
                label5.Text = $"{label5.Text} {Login.logged_in_user}";
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Casino;Integrated Security=True");
                String command = $"select max(slot_session_id) from slot;";
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    session_id = da.GetValue(0).ToString();
                    
                
                }
            if (session_id == "")
            {

            }
            else
            {
                session = int.Parse(session_id) + 1;
            }
                

                sqlCon.Close();
                label1.Text = $"{label1.Text} {session}";
            
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
                SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Casino;Integrated Security=True");
                String command = $"INSERT INTO slot (slot_session_id, outcome,outcome_no, slot_type) VALUES({session},'{outcome}',{trial_num},{slot_machine})";
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(command, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Trial Saved");
                trial_num++;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Casino;Integrated Security=True");
            String command = $"INSERT INTO round (round_id, user_id,env_id ,slot_session_id,earn,start_time,end_time) VALUES('test','{Login.logged_in_user}','{env_type}',{session},{10.8},'{now}','{DateTime.Now}')";
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(command, sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("All results of the current trial have been saved, you may safley close the window");
        }
        // below two functions do nothing but are needed otherwise program crashes
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
