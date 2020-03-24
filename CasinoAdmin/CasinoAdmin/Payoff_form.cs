using System;
using System.Windows.Forms;

namespace CasinoAdmin
{
    /*
     * Developed By: Aleem Ul Haq
     * Date: March 2020
     * This is a Form class for editing Payoffs
     * 
     */
    public partial class Payoff_form : Form
    {
        // use these in HLTest_Form.cs
        // init with default vals.(used to access even before form loads)
        public static decimal OptionA_Max = 2.0M;
        public static decimal OptionA_Min = 1.60M;

        public static decimal OptionB_Max = 3.85M;
        public static decimal OptionB_Min = 0.10M;

        // used for default button
        private decimal default_A_Max = 2.0M;
        private decimal default_A_Min = 1.60M;

        private decimal default_B_Max = 3.85M;
        private decimal default_B_Min = 0.10M;

        public Payoff_form()
        {
            InitializeComponent();
        }

        //------------------------ Runs when form loads ------------------------
        private void Payoff_form_Load(object sender, EventArgs e)
        {
            // init counters
            initCounters();
            setCounterToDefaults();
            setPayoffsToCounterVals();
        }

        //------------------------ Save current counter values to global  ------------------------
        private void save_payoffs_btn_Click(object sender, EventArgs e)
        {
            setPayoffsToCounterVals();
        }


        //------------------------ Restores payoffs to defaults ------------------------
        private void restoreDefaults_payoffs_btn_Click(object sender, EventArgs e)
        {
            setCounterToDefaults();
        }

        //------------------------ init counter properties ------------------------
        private void initCounters()
        {
            optionA_Max_counter.DecimalPlaces = 2;
            optionA_Max_counter.Increment = 0.05M;

            optionA_Min_counter.DecimalPlaces = 2;
            optionA_Min_counter.Increment = 0.05M;

            optionB_Max_counter.DecimalPlaces = 2;
            optionB_Max_counter.Increment = 0.05M;

            optionB_Min_counter.DecimalPlaces = 2;
            optionB_Min_counter.Increment = 0.05M;
        }

        //------------------------ set counter to default holt and laury payoffs ------------------------
        private void setCounterToDefaults()
        {
            this.optionA_Max_counter.Value = default_A_Max;
            this.optionA_Min_counter.Value = default_A_Min;

            this.optionB_Max_counter.Value = default_B_Max;
            this.optionB_Min_counter.Value = default_B_Min;
        }

        //------------------------ Save current counter values to global  ------------------------
        private void setPayoffsToCounterVals()
        {
            OptionA_Max = this.optionA_Max_counter.Value;
            OptionA_Min = this.optionA_Min_counter.Value;

            OptionB_Max = this.optionB_Max_counter.Value;
            OptionB_Min = this.optionB_Min_counter.Value;
        }
    }
}
