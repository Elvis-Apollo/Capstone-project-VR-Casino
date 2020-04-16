using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Data;

namespace CasinoAdmin
{


    public partial class HLTest_Form : Form
    {
        public static string JsonFolderDirectory = MainForm.JsonFolderDirectory;

        private List<RadioButton> radioButtons = new List<RadioButton>() { };

        public HLTest_Form()
        {
            InitializeComponent();

            // hook up  ok and cancel button to form default Acept and Cancel buttons
            this.AcceptButton = OK_btn;
            this.CancelButton = Cancel_btn;
            initalTextA(Payoff_form.OptionA_Max, Payoff_form.OptionA_Min);
            initalTextB(Payoff_form.OptionB_Max, Payoff_form.OptionB_Min);
            //this.ResumeLayout(false);

            radioButtons.Add(A1_radioBtn);
            radioButtons.Add(A2_radioBtn);
            radioButtons.Add(A3_radioBtn);
            radioButtons.Add(A4_radioBtn);
            radioButtons.Add(A5_radioBtn);
            radioButtons.Add(A6_radioBtn);
            radioButtons.Add(A7_radioBtn);
            radioButtons.Add(A8_radioBtn);
            radioButtons.Add(A9_radioBtn);
            radioButtons.Add(A10_radioBtn);

            radioButtons.Add(B1_radioBtn);
            radioButtons.Add(B2_radioBtn);
            radioButtons.Add(B3_radioBtn);
            radioButtons.Add(B4_radioBtn);
            radioButtons.Add(B5_radioBtn);
            radioButtons.Add(B6_radioBtn);
            radioButtons.Add(B7_radioBtn);
            radioButtons.Add(B8_radioBtn);
            radioButtons.Add(B9_radioBtn);
            radioButtons.Add(B10_radioBtn);
        }

        public void initalTextA(decimal max_a, decimal min_a)
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

        public void initalTextB(decimal max_b, decimal min_b)
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

            if (getListOfSelectedChoices().Count != 10) // not exactly 10 items
            {
                MessageBox.Show("Please select 1 choice from each row, 10 in total.", "Select 10 choices");
            }
            else
            {
                HoltLaury holt = new HoltLaury()
                {
                    OptionA_Max = Payoff_form.OptionA_Max,
                    OptionA_Min = Payoff_form.OptionA_Min,
                    OptionB_Max = Payoff_form.OptionB_Max,
                    OptionB_Min = Payoff_form.OptionB_Min,
                    Decision_Choices = getListOfSelectedChoices()
                }; //create object

                // writes to json file
                TextWriter txt = new StreamWriter(JsonFolderDirectory + "\\" + "HoltLaury_1.json"); // holtLaury_1.json
                txt.Write(JsonSerializer.Serialize(holt));
                txt.Close();

                HL_panel.Visible = false;
                HL_panel.SendToBack();
                HL_Thanks_panel.BringToFront();
                HL_Thanks_panel.Visible = true;
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cancel button clicked");
        }

        private List<String> getListOfSelectedChoices()
        {
            List<String> checkedBtns = new List<String>() { };

            foreach (RadioButton radioBtn in radioButtons)
            {
                if (radioBtn.Checked)
                {
                    checkedBtns.Add(radioBtn.Name.Replace("_radioBtn", ""));  // add A1, B1 etc. Note format, removing _radioBtn
                }
            }

            return checkedBtns;
        }
    }
    public class HoltLaury
    {

        public decimal OptionA_Max { get; set; }
        public decimal OptionA_Min { get; set; }
        public decimal OptionB_Max { get; set; }
        public decimal OptionB_Min { get; set; }
        public List<String> Decision_Choices { get; set; }
    }
}


