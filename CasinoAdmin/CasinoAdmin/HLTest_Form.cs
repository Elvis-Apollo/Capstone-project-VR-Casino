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
    public partial class HLTest_Form : Form
    {
        public HLTest_Form()
        {
            InitializeComponent();

            // hook up  ok and cancel button to form default Acept and Cancel buttons
            this.AcceptButton = OK_btn;
            this.CancelButton = Cancel_btn;

            //this.ResumeLayout(false);
        }


        // When OK is pressed, make sure 1 option from each row is selected, if not then throw error message.
        private void OK_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("OK button clicked");


            Console.WriteLine("maxA: " + Payoff_form.OptionA_Max);
            Console.WriteLine("maxA: " + Payoff_form.OptionA_Min);

            Console.WriteLine("maxB: " + Payoff_form.OptionB_Max);
            Console.WriteLine("minB: " + Payoff_form.OptionB_Min);

            // Loop through all row panels, make sure one radio button from each row selected.

            // else throw error like this:
            //MessageBox.Show("Error, select an option from each row!", "Error");

            // if all rows selected, save to disk(we want to save to same folder as the other jsons(slot machines)
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cancel button clicked");
        }
    }

}
