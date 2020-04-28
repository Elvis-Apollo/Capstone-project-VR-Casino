using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace CasinoAdmin

/*
 * Developed By: Aleem Ul Haq
 * Date: March 2020
 * This is a Form class for Main form of the app
 * 
 */
{
    public partial class MainForm : Form
    {

        //************************** Class Variables ******************************************

        //------------------------ json directory for slot machines.json ------------------------
        public static string JsonFolderDirectory = "";
       

       
              
        //------------------------ Visual Variables ------------------------
        private FolderBrowserDialog folderBrowsePopup;
        private string directoryLabelText = "Selected directory: ";

        //************************** Constructor ******************************************
        public MainForm()
        {
             
            InitializeComponent();
            panel_main.BringToFront();
            panel_admin.Visible = false;
            panel_admin.SendToBack();
        } // constructor ends here



        //********************************* Init **************************************************

        //------------------------ Executed when main form loads ------------------------
        private void Main_Form_Load(object sender, EventArgs e)
        {
            folderBrowsePopup = new FolderBrowserDialog(); // create new folder browser dialog
            directory_label.Text = directoryLabelText + "None, please select a folder.";

            // if json folder already saved, then load that path
            string currentPath = Directory.GetCurrentDirectory() + "\\path.txt";
            if (File.Exists(currentPath))
            {
                string pathText = System.IO.File.ReadAllText(@"" + currentPath).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty); // remove newline char
                JsonFolderDirectory = pathText;
                directory_label.Text = directoryLabelText + JsonFolderDirectory;
            }
        }

        //**************** Helpers Functions *****************************************************



        //**************** Gui Action Functions **************************************************


        //------------------------ Main HoltLaury test btn ------------------------
        private void button_HLTest_main_Click(object sender, EventArgs e)
        {
            if (JsonFolderDirectory == "") // if folder has not been set yet
            {
                MessageBox.Show("Please contact Admin to initalize test.", "Contact Admin!");

            }
            else
            {
                // create holt laury test form 
                HLTest_Form hlTest_form = new HLTest_Form();
                hlTest_form.ShowDialog();
            }
        }

        //------------------------ Main Admin btn ------------------------
        // Add login check here
        private void button_Admin_main_Click(object sender, EventArgs e)
        {
            // Add log in check here
            MessageBox.Show("Admin logged in!", "Authorization");
            //this leads to Admin state on MainForm

            panel_main.Visible = false;
            panel_main.SendToBack();

            panel_admin.BringToFront();
            panel_admin.Visible = true;
        }

        //------------------------ Admin payoff btn ------------------------
        private void payoff_btn_Click(object sender, EventArgs e)
        {
            if (JsonFolderDirectory == "") // if folder has not been set yet
            {
                MessageBox.Show("Please select json folder first.", "Error");
            }
            else
            {
                // create payoff form 
                Payoff_form payoff_form = new Payoff_form();
                payoff_form.ShowDialog();
            }
        }

        //------------------------ SlotMachine btn ------------------------
        private void slotMach_btn_Click(object sender, EventArgs e)
        {
            if (JsonFolderDirectory == "") // if folder has not been set yet
            {
                MessageBox.Show("Please select json folder first.", "Error");
            }
            else
            {
                // create slot mach form 
                SlotMachineForm slotMach_form = new SlotMachineForm();
                slotMach_form.ShowDialog();
            }
        }

        //------------------------ Selects folder for json files ------------------------
        // This must be the unity game/assets/scripts/jsonFiles path
        private void sel_folder_btn_Click(object sender, EventArgs e)
        {
            string path = "\\path.txt";
            string currentPath = Directory.GetCurrentDirectory() + path;

            DialogResult dialogResult = folderBrowsePopup.ShowDialog();
            if (dialogResult == DialogResult.OK) // if able to select a  folder
            {
                // The user selected a folder and pressed the OK button.

                string[] files = Directory.GetFiles(folderBrowsePopup.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                JsonFolderDirectory = folderBrowsePopup.SelectedPath; // set global directory string
                directory_label.Text = directoryLabelText + folderBrowsePopup.SelectedPath; // set directory text

                //save json folder path to text file
                TextWriter txtWrite = new StreamWriter(currentPath);
                txtWrite.WriteLine(JsonFolderDirectory);
                txtWrite.Close();
            }
        }

        //------------------------ Returns admin to main menu ------------------------
        private void back_toMain_btn_Click(object sender, EventArgs e)
        {
            panel_admin.Visible = false;
            panel_main.BringToFront();
            panel_admin.SendToBack();
            panel_main.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm  reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Login.logged_in_user == "")
            {
                MessageBox.Show("NO USER IS LOGGED IN");
            }
            else
            {
                Test test = new Test();
                test.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserResults user = new UserResults();
            user.ShowDialog();
        }

        private void tableLayout_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Casino;Integrated Security=True");
            String command = @"
BEGIN
CREATE TABLE users (
	user_id varchar(30) NOT NULL,
    password varchar(255),
    user_role varchar(255)
	PRIMARY KEY (user_id)
);
CREATE TABLE actions(
	action_id int NOT NULL,
	user_id varchar(30) NOT NULL,
	user_action varchar(255) NOT NULL,
	x_coord real NOT NULL,
	y_coord real NOT NULL,
	z_coord real NOT NULL,
	time_action datetime NOT NULL,
	PRIMARY KEY (action_id),
	FOREIGN KEY (user_id) REFERENCES users(user_id) 

);
CREATE TABLE environment (
	env_id varchar(30) NOT NULL,
	type int NOT NULL
);

CREATE TABLE slot(
	slot_session_id int NOT NULL,
	outcome varchar(30),
	outcome_no int NOT NULL,
	slot_type int NOT NULL
);

CREATE TABLE round(
	round_id varchar(30) NOT NULL,
	user_id varchar(30) NOT NULL,
	env_id varchar(30) NOT NULL,
	slot_session_id int NOT NULL,
	earn real NOT NULL,
	start_time datetime NOT NULL,
	end_time datetime NOT NULL
);
END 


";
            SqlCommand cmd = new SqlCommand(command, sqlCon);
            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
