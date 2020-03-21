using System;
using System.IO;
using System.Windows.Forms;

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
            panel_admin.Visible = false ;
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
            // create holt laury form 
            HoltLauryForm hl_form = new HoltLauryForm();
            hl_form.CreateHoltLauryForm();
            //this.Hide();
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
                Console.WriteLine("Payoff button clicked");
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
    }
}
