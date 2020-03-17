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
        }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // create holt laury form
        private void button1_Click(object sender, EventArgs e)
        {
            // create holt laury form 
            HoltLauryForm hl_form = new HoltLauryForm();
            hl_form.CreateHoltLauryForm();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create admin form 
            AdminForm admin_form = new AdminForm();
            admin_form.CreateAdminForm();            
        }
    }
}
