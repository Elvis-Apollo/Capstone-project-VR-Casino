﻿using System;
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
            initalTextA(Payoff_form.OptionA_Max,Payoff_form.OptionA_Min);
            initalTextB(Payoff_form.OptionB_Max,Payoff_form.OptionB_Min);
            //this.ResumeLayout(false);
        }

        public void initalTextA(decimal max_a,decimal min_a)
        {
            
            A1_radioBtn.Text = $"1/10 Chance Of ${max_a}, 9/10 Chance of ${min_a}";
            A2_radioBtn.Text = $"2/10 Chance Of ${max_a}, 8/10 Chance of ${min_a}";
            A3_radioBtn.Text = $"3/10 Chance Of ${max_a}, 7/10 Chance of ${min_a}";
            A4_radioBtn.Text = $"4/10 Chance Of ${max_a}, 6/10 Chance of ${min_a}";
            A5_radioBtn.Text = $"5/10 Chance Of ${max_a}, 5/10 Chance of ${min_a}";
            A6_radioBtn.Text = $"6/10 Chance Of ${max_a}, 4/10 Chance of ${min_a}";
            A7_radioBtn.Text = $"7/10 Chance Of ${max_a}, 3/10 Chance of ${min_a}";
            A8_radioBtn.Text = $"8/10 Chance Of ${max_a}, 2/10 Chance of ${min_a}";
            A9_radioBtn.Text = $"9/10 Chance Of ${max_a}, 1/10 Chance of ${min_a}";
            A10_radioBtn.Text = $"10/10 Chance Of ${max_a}, 0/10 Chance of ${min_a}";
        }

        public void initalTextB(decimal max_b,decimal min_b)
        {
            B1_radioBtn.Text = $"1/10 Chance Of ${max_b}, 9/10 Chance of ${min_b}";
            B2_radioBtn.Text = $"2/10 Chance Of ${max_b}, 8/10 Chance of ${min_b}";
            B3_radioBtn.Text = $"3/10 Chance Of ${max_b}, 7/10 Chance of ${min_b}";
            B4_radioBtn.Text = $"4/10 Chance Of ${max_b}, 6/10 Chance of ${min_b}";
            B5_radioBtn.Text = $"5/10 Chance Of ${max_b}, 5/10 Chance of ${min_b}";
            B6_radioBtn.Text = $"6/10 Chance Of ${max_b}, 4/10 Chance of ${min_b}";
            B7_radioBtn.Text = $"7/10 Chance Of ${max_b}, 3/10 Chance of ${min_b}";
            B8_radioBtn.Text = $"8/10 Chance Of ${max_b}, 2/10 Chance of ${min_b}";
            B9_radioBtn.Text = $"9/10 Chance Of ${max_b}, 1/10 Chance of ${min_b}";
            B10_radioBtn.Text = $"10/10 Chance Of ${max_b}, 0/10 Chance of ${min_b}";
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

        private void A1_radioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
