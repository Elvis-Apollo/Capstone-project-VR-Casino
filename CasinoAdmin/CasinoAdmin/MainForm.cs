using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panel_main.BringToFront();
            panel_admin.Visible = false ;
            panel_admin.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // create holt laury form
        /*   private void button1_Click(object sender, EventArgs e)
           {
               // create holt laury form 
               HoltLauryForm hl_form = new HoltLauryForm();
               hl_form.CreateHoltLauryForm();
               //this.Hide();
           }*/

        private void button2_Click(object sender, EventArgs e)
        {
            // create admin form 
            SlotMachineForm admin_form = new SlotMachineForm();
            //admin_form.CreateAdminForm();            
        }

        private void button_HLTest_main_Click(object sender, EventArgs e)
        {
            // create holt laury form 
            HoltLauryForm hl_form = new HoltLauryForm();
            hl_form.CreateHoltLauryForm();
            //this.Hide();
        }

        private void button_Admin_main_Click(object sender, EventArgs e)
        {
            // Add log in check here
            //this leads to Admin state on MainForm

            panel_main.Visible = false;
            panel_main.SendToBack();

            panel_admin.BringToFront();
            panel_admin.Visible = true;


            //AdminForm admin_form = new AdminForm() { Dock = DockStyle.Fill };
            //this.Controls.Add(admin_form);
            //this.panel_main.Controls.Add(admin_form);

            /*admin_form.ShowDialog();
            this.Close();
*/
            //admin_form.CreateAdminForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // create admin form 
            SlotMachineForm admin_form = new SlotMachineForm();
            admin_form.ShowDialog();
            //admin_form.CreateAdminForm();  
        }
    }
}
