using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace AdminSettings
{
    public partial class Form1 : Form
    {
        //****************Class Vars*********************************************        
        private List<OutCome> outcomeList_slotMachine_1 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_2 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_3 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_4 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_5 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_6 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_7 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_8 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_9 = new List<OutCome> { };
        private List<OutCome> outcomeList_slotMachine_10 = new List<OutCome> { };

        private List<float> spinReelsTime_slotMachine_1 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_2 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_3 = new List<float> { };

        private List<float> spinReelsTime_slotMachine_4 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_5 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_6 = new List<float> { };


        private List<float> spinReelsTime_slotMachine_7 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_8 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_9 = new List<float> { };
        private List<float> spinReelsTime_slotMachine_10 = new List<float> { };


        //add more json lists here        
        // use this list for deafult values for a slotMachine        
        private List<OutCome> outcomeList_slotMachine_default = new List<OutCome> { OutCome.W, OutCome.W, OutCome.L, OutCome.NM, OutCome.L };
        private List<float> spinReels_default = new List<float> { 3.0f, 4.0f, 5.0f, 6.0f }; //[3,4,5,6]
        enum Settings
        {
            SlotMachine_1,
            SlotMachine_2,
            SlotMachine_3,
            SlotMachine_4,
            SlotMachine_5,
            SlotMachine_6,
            SlotMachine_7,
            SlotMachine_8,
            SlotMachine_9,
            SlotMachine_10,
            Environment_Calm,
            Environment_Chaos
        }

        enum OutCome
        {
            W,
            L,
            NM
        }

        class SlotMachineObj
        {
            public String ObjectName { get; set; }
            public List<String> OutcomeList { get; set; }

            public List<float> ReelSpinTime { get; set; }
        }

        //****************Constructor********************************************
        public Form1()
        {
            InitializeComponent();
            // add settings(options) to combobox
            settings_comboBox.Items.Add(Settings.SlotMachine_1);
            settings_comboBox.Items.Add(Settings.SlotMachine_2);
            settings_comboBox.Items.Add(Settings.SlotMachine_3);
            settings_comboBox.Items.Add(Settings.SlotMachine_4);
            settings_comboBox.Items.Add(Settings.SlotMachine_5);
            settings_comboBox.Items.Add(Settings.SlotMachine_6);
            settings_comboBox.Items.Add(Settings.SlotMachine_7);
            settings_comboBox.Items.Add(Settings.SlotMachine_8);
            settings_comboBox.Items.Add(Settings.SlotMachine_9);
            settings_comboBox.Items.Add(Settings.SlotMachine_10);
            // do not show environ stuff for now
            /*settings_comboBox.Items.Add(Settings.Environment_Calm);
            settings_comboBox.Items.Add(Settings.Environment_Chaos);*/

            // init all data lists with default values
            initDataListsWithDefaults();

            // set spinTime counter input mask
            initSpinReelsTimeCounters();

            //activate tooltips
            activateToolTips_SlotMach();
        }

        //****************Helpers Functions***********************************

        private void initDataListsWithDefaults()
        {
            overwriteOutComeList(outcomeList_slotMachine_1, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_2, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_3, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_4, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_5, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_6, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_7, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_8, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_9, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_10, outcomeList_slotMachine_default);

        }

        //init all the spinTime counter mask(1 decimal point and 0.1 counter)
        private void initSpinReelsTimeCounters()
        {
            //reela
            reelA_spinTime_counter.DecimalPlaces = 1;
            reelA_spinTime_counter.Increment = 0.1M;
            reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
            //reelb
            reelB_spinTime_counter.DecimalPlaces = 1;
            reelB_spinTime_counter.Increment = 0.1M;
            reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
            //reelc
            reelC_spinTime_counter.DecimalPlaces = 1;
            reelC_spinTime_counter.Increment = 0.1M;
            reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
            //reeld
            reelD_spinTime_counter.DecimalPlaces = 1;
            reelD_spinTime_counter.Increment = 0.1M;
            reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);

            // init data lists with default values            
            foreach (float spinDefault in spinReels_default)
            {
                spinReelsTime_slotMachine_1.Add(spinDefault);
                spinReelsTime_slotMachine_2.Add(spinDefault);
                spinReelsTime_slotMachine_3.Add(spinDefault);
                spinReelsTime_slotMachine_4.Add(spinDefault);
                spinReelsTime_slotMachine_5.Add(spinDefault);
                spinReelsTime_slotMachine_6.Add(spinDefault);
                spinReelsTime_slotMachine_7.Add(spinDefault);
                spinReelsTime_slotMachine_8.Add(spinDefault);
                spinReelsTime_slotMachine_9.Add(spinDefault);
                spinReelsTime_slotMachine_10.Add(spinDefault);
            }
        }

        // function used as delegate for converting all items in outcome list to string
        private String outComeToString(OutCome outcome)
        {
            return outcome.ToString();
        }

        // overwrites a outcome list with another
        private void overwriteOutComeList(List<OutCome> listToOverwrite, List<OutCome> overwireFromList)
        {
            Console.WriteLine("Overwriting list");
            listToOverwrite.Clear();
            foreach (OutCome outcome in overwireFromList)
            {
                listToOverwrite.Add(outcome);
            }
        }


        //sets a listBox to an outcomeList
        //setListBoxToOutcomeList(ListBox listBox, List<OutCome> outcomeList)
        private void setListBoxToOutcomeList(List<OutCome> outcomeList)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Clear(); //delete listBox items 
            foreach (OutCome outCome in outcomeList) //update listBox with new items
            {
                listBox_slotMach.Items.Add(outCome);
            }
            listBox_slotMach.EndUpdate();
        }

        private void addWinBtnAction(ListBox listBoxList)
        {
            Console.WriteLine("Running helper func for AddWin");
            listBoxList.BeginUpdate();
            listBoxList.Items.Add(OutCome.W);
            listBoxList.EndUpdate();
        }
        private void addNearMissBtnAction(ListBox listBoxList)
        {
            Console.WriteLine("Running helper func for AddNearMiss");
            listBoxList.BeginUpdate();
            listBoxList.Items.Add(OutCome.NM);
            listBoxList.EndUpdate();
        }

        private void addLossBtnAction(ListBox listBoxList)
        {
            Console.WriteLine("Running helper func for AddLoss");
            listBoxList.BeginUpdate();
            listBoxList.Items.Add(OutCome.L);
            listBoxList.EndUpdate();
        }

        private void writeJsonToFile(Object settings)
        {
            string exePath = "" + Application.StartupPath;
            string currentPath = Directory.GetCurrentDirectory();
            string parentPath = Directory.GetParent(currentPath).FullName;

            string fileName = "";
            Console.WriteLine(exePath);
            Console.WriteLine(currentPath);
            Console.WriteLine(parentPath);
            SlotMachineObj slotObj;

            switch (settings)
            {
                case Settings.SlotMachine_1:
                    List<String> jsonOutputString_slotMachine1 = outcomeList_slotMachine_1.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_1.ToString(), OutcomeList = jsonOutputString_slotMachine1, ReelSpinTime = spinReelsTime_slotMachine_1 };
                    fileName = Settings.SlotMachine_1.ToString();
                    break;
                case Settings.SlotMachine_2:
                    List<String> jsonOutputString_slotMachine2 = outcomeList_slotMachine_2.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_2.ToString(), OutcomeList = jsonOutputString_slotMachine2, ReelSpinTime = spinReelsTime_slotMachine_2 };
                    fileName = Settings.SlotMachine_2.ToString();
                    break;
                case Settings.SlotMachine_3:
                    List<String> jsonOutputString_slotMachine3 = outcomeList_slotMachine_3.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_3.ToString(), OutcomeList = jsonOutputString_slotMachine3, ReelSpinTime = spinReelsTime_slotMachine_3 };
                    fileName = Settings.SlotMachine_3.ToString();
                    break;
                case Settings.SlotMachine_4:
                    List<String> jsonOutputString_slotMachine4 = outcomeList_slotMachine_4.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_4.ToString(), OutcomeList = jsonOutputString_slotMachine4, ReelSpinTime = spinReelsTime_slotMachine_4 };
                    fileName = Settings.SlotMachine_4.ToString();
                    break;
                case Settings.SlotMachine_5:
                    List<String> jsonOutputString_slotMachine5 = outcomeList_slotMachine_5.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_5.ToString(), OutcomeList = jsonOutputString_slotMachine5, ReelSpinTime = spinReelsTime_slotMachine_5 };
                    fileName = Settings.SlotMachine_5.ToString();
                    break;
                case Settings.SlotMachine_6:
                    List<String> jsonOutputString_slotMachine6 = outcomeList_slotMachine_6.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_6.ToString(), OutcomeList = jsonOutputString_slotMachine6, ReelSpinTime = spinReelsTime_slotMachine_6 };
                    fileName = Settings.SlotMachine_6.ToString();
                    break;
                case Settings.SlotMachine_7:
                    List<String> jsonOutputString_slotMachine7 = outcomeList_slotMachine_7.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_7.ToString(), OutcomeList = jsonOutputString_slotMachine7, ReelSpinTime = spinReelsTime_slotMachine_7 };
                    fileName = Settings.SlotMachine_7.ToString();
                    break;
                case Settings.SlotMachine_8:
                    List<String> jsonOutputString_slotMachine8 = outcomeList_slotMachine_8.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_8.ToString(), OutcomeList = jsonOutputString_slotMachine8, ReelSpinTime = spinReelsTime_slotMachine_8 };
                    fileName = Settings.SlotMachine_8.ToString();
                    break;
                case Settings.SlotMachine_9:
                    List<String> jsonOutputString_slotMachine9 = outcomeList_slotMachine_9.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_9.ToString(), OutcomeList = jsonOutputString_slotMachine9, ReelSpinTime = spinReelsTime_slotMachine_9 };
                    fileName = Settings.SlotMachine_9.ToString();
                    break;
                case Settings.SlotMachine_10:
                    List<String> jsonOutputString_slotMachine10 = outcomeList_slotMachine_10.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = Settings.SlotMachine_10.ToString(), OutcomeList = jsonOutputString_slotMachine10, ReelSpinTime = spinReelsTime_slotMachine_10 };
                    fileName = Settings.SlotMachine_10.ToString();
                    break;
                default:
                    List<String> jsonOutputString_default = outcomeList_slotMachine_default.ConvertAll(new Converter<OutCome, string>(outComeToString));
                    slotObj = new SlotMachineObj() { ObjectName = "Default slot Obj", OutcomeList = jsonOutputString_default, ReelSpinTime = spinReels_default };
                    fileName = "slotmachine_default_case";
                    break;

            }
            TextWriter txt = new StreamWriter(currentPath + "\\" + fileName + ".json");
            txt.Write(JsonSerializer.Serialize(slotObj));
            txt.Close();
        }

        private void activateToolTips_SlotMach()
        {
            ttip_default_SM.SetToolTip(restoreDefaults_slotMac_btn, "Careful, Restores default values for this json");
            ttip_clearJson_SM.SetToolTip(clearJson_slotMac_btn, "Careful, Clears values for this json");
            ttip_default_All.SetToolTip(restoreAllDefaults_btn, "Careful! Restores all jsons to default values");
            ttip_save_All.SetToolTip(saveAll_btn, "Saves all jsons at once!");
        }


        //****************Gui Action Functions***********************************
        //settings_comboBox (DropDown)
        private void settings_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            save_btn.Enabled = true;

            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    Console.WriteLine("case settings: " + Settings.SlotMachine_1);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_1);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show current list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_1[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_1[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_1[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_1[3]);
                    break;
                case Settings.SlotMachine_2:
                    Console.WriteLine("case settings: " + Settings.SlotMachine_2);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_2);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_2[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_2[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_2[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_2[3]);
                    break;
                case Settings.SlotMachine_3:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_3);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_3);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_3[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_3[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_3[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_3[3]);
                    break;
                case Settings.SlotMachine_4:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_4);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_4);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_4[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_4[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_4[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_4[3]);
                    break;
                case Settings.SlotMachine_5:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_5);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_5);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_5[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_5[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_5[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_5[3]);
                    break;
                case Settings.SlotMachine_6:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_6);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_6);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_6[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_6[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_6[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_6[3]);
                    break;
                case Settings.SlotMachine_7:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_7);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_7);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_7[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_7[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_7[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_7[3]);
                    break;
                case Settings.SlotMachine_8:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_8);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_8);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_8[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_8[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_8[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_8[3]);
                    break;
                case Settings.SlotMachine_9:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_9);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_9);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_9[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_9[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_9[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_9[3]);
                    break;
                case Settings.SlotMachine_10:
                    Console.WriteLine("case settings slot machine1: " + Settings.SlotMachine_10);
                    groupBox_slotMach.Visible = true;
                    groupBox_Envr.Visible = false;
                    setListBoxToOutcomeList(outcomeList_slotMachine_10);
                    listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show default list size
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_10[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_10[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_10[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReelsTime_slotMachine_10[3]);
                    break;
                case Settings.Environment_Calm:
                    Console.WriteLine("case settings: " + Settings.Environment_Calm);
                    groupBox_slotMach.Visible = false;
                    groupBox_Envr.Visible = true;

                    break;
                case Settings.Environment_Chaos:
                    Console.WriteLine("case settings: " + Settings.Environment_Chaos);
                    groupBox_slotMach.Visible = false;
                    groupBox_Envr.Visible = true;
                    break;
                default:
                    Console.WriteLine("Default case for comboBox");
                    groupBox_slotMach.Visible = false;
                    groupBox_Envr.Visible = false;
                    break;
            }
        }

        //_slotMach_1
        private void addWin_btn_slotMach_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + addWin_btn_slotMach.Name);

            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    outcomeList_slotMachine_1.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_1);
                    break;
                case Settings.SlotMachine_2:
                    outcomeList_slotMachine_2.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_2);
                    break;
                case Settings.SlotMachine_3:
                    outcomeList_slotMachine_3.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_3);
                    break;
                case Settings.SlotMachine_4:
                    outcomeList_slotMachine_4.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_4);
                    break;
                case Settings.SlotMachine_5:
                    outcomeList_slotMachine_5.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_5);
                    break;
                case Settings.SlotMachine_6:
                    outcomeList_slotMachine_6.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_6);
                    break;
                case Settings.SlotMachine_7:
                    outcomeList_slotMachine_7.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_7);
                    break;
                case Settings.SlotMachine_8:
                    outcomeList_slotMachine_8.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_8);
                    break;
                case Settings.SlotMachine_9:
                    outcomeList_slotMachine_9.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_9);
                    break;
                case Settings.SlotMachine_10:
                    outcomeList_slotMachine_10.Add(OutCome.W);
                    setListBoxToOutcomeList(outcomeList_slotMachine_10);
                    break;
                default:
                    Console.WriteLine("No slot machine selected  but W button clicked");
                    break;
            }
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
            Console.WriteLine(outcomeList_slotMachine_1.Count);
        }

        //_slotMach_1
        private void addNearMiss_btn_slotMach_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + addNearMiss_btn_slotMach.Name);
            // addNearMissBtnAction(listBox_slotMach_1);


            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    outcomeList_slotMachine_1.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_1);
                    Console.WriteLine("outcomelist1 size: " + outcomeList_slotMachine_1.Count);
                    break;
                case Settings.SlotMachine_2:
                    outcomeList_slotMachine_2.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_2);
                    Console.WriteLine("outcomelist2 size: " + outcomeList_slotMachine_2.Count);
                    break;
                case Settings.SlotMachine_3:
                    outcomeList_slotMachine_3.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_3);
                    Console.WriteLine("outcomelist3 size: " + outcomeList_slotMachine_3.Count);
                    break;
                case Settings.SlotMachine_4:
                    outcomeList_slotMachine_4.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_4);
                    Console.WriteLine("outcomelist4 size: " + outcomeList_slotMachine_4.Count);
                    break;
                case Settings.SlotMachine_5:
                    outcomeList_slotMachine_5.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_5);
                    Console.WriteLine("outcomelist3 size: " + outcomeList_slotMachine_5.Count);
                    break;
                case Settings.SlotMachine_6:
                    outcomeList_slotMachine_6.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_6);
                    Console.WriteLine("outcomelist6 size: " + outcomeList_slotMachine_6.Count);
                    break;
                case Settings.SlotMachine_7:
                    outcomeList_slotMachine_7.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_7);
                    Console.WriteLine("outcomelist7 size: " + outcomeList_slotMachine_7.Count);
                    break;
                case Settings.SlotMachine_8:
                    outcomeList_slotMachine_8.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_8);
                    Console.WriteLine("outcomelist8 size: " + outcomeList_slotMachine_8.Count);
                    break;
                case Settings.SlotMachine_9:
                    outcomeList_slotMachine_9.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_9);
                    Console.WriteLine("outcomelist9 size: " + outcomeList_slotMachine_9.Count);
                    break;
                case Settings.SlotMachine_10:
                    outcomeList_slotMachine_10.Add(OutCome.NM);
                    setListBoxToOutcomeList(outcomeList_slotMachine_10);
                    Console.WriteLine("outcomelist10 size: " + outcomeList_slotMachine_10.Count);
                    break;
                default:
                    Console.WriteLine("No slot machine selected  but NM button clicked");
                    break;
            }
            //Console.WriteLine(outcomeList_slotMachine_1.Count);
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
        }

        //_slotMach_1 --10
        private void addLoss_btn_slotMach_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + addLoss_btn_slotMach.Name);
            //addLossBtnAction(listBox_slotMach_1);            

            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    outcomeList_slotMachine_1.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_1);
                    Console.WriteLine("outcomelist1 size: " + outcomeList_slotMachine_1.Count);
                    break;
                case Settings.SlotMachine_2:
                    outcomeList_slotMachine_2.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_2);
                    Console.WriteLine("outcomelist2 size: " + outcomeList_slotMachine_2.Count);
                    break;
                case Settings.SlotMachine_3:
                    outcomeList_slotMachine_3.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_3);
                    Console.WriteLine("outcomelist3 size: " + outcomeList_slotMachine_3.Count);
                    break;
                case Settings.SlotMachine_4:
                    outcomeList_slotMachine_4.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_4);
                    Console.WriteLine("outcomelist4 size: " + outcomeList_slotMachine_4.Count);
                    break;
                case Settings.SlotMachine_5:
                    outcomeList_slotMachine_5.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_5);
                    Console.WriteLine("outcomelist5 size: " + outcomeList_slotMachine_5.Count);
                    break;
                case Settings.SlotMachine_6:
                    outcomeList_slotMachine_6.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_6);
                    Console.WriteLine("outcomelist6 size: " + outcomeList_slotMachine_6.Count);
                    break;
                case Settings.SlotMachine_7:
                    outcomeList_slotMachine_7.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_7);
                    Console.WriteLine("outcomelist7 size: " + outcomeList_slotMachine_7.Count);
                    break;
                case Settings.SlotMachine_8:
                    outcomeList_slotMachine_8.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_8);
                    Console.WriteLine("outcomelist8 size: " + outcomeList_slotMachine_8.Count);
                    break;
                case Settings.SlotMachine_9:
                    outcomeList_slotMachine_9.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_9);
                    Console.WriteLine("outcomelist9 size: " + outcomeList_slotMachine_9.Count);
                    break;
                case Settings.SlotMachine_10:
                    outcomeList_slotMachine_10.Add(OutCome.L);
                    setListBoxToOutcomeList(outcomeList_slotMachine_10);
                    Console.WriteLine("outcomelist10 size: " + outcomeList_slotMachine_10.Count);
                    break;

                default:
                    Console.WriteLine("No slot machine selected  but L button clicked");
                    break;
            }
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
            //nsole.WriteLine(outcomeList_slotMachine_1.Count);
        }

        private void listBox_slotMach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearJson_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + clearJson_slotMac_btn.Name);
            Console.WriteLine("clear list box");
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Clear();
            listBox_slotMach.EndUpdate();

            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    outcomeList_slotMachine_1.Clear();
                    Console.WriteLine("outcome list1 size: " + outcomeList_slotMachine_1.Count);
                    break;
                case Settings.SlotMachine_2:
                    outcomeList_slotMachine_2.Clear();
                    Console.WriteLine("outcome list2 size: " + outcomeList_slotMachine_2.Count);
                    break;
                case Settings.SlotMachine_3:
                    outcomeList_slotMachine_3.Clear();
                    Console.WriteLine("outcome list3 size: " + outcomeList_slotMachine_3.Count);
                    break;
                case Settings.SlotMachine_4:
                    outcomeList_slotMachine_4.Clear();
                    Console.WriteLine("outcome list4 size: " + outcomeList_slotMachine_4.Count);
                    break;
                case Settings.SlotMachine_5:
                    outcomeList_slotMachine_5.Clear();
                    Console.WriteLine("outcome list5 size: " + outcomeList_slotMachine_5.Count);
                    break;
                case Settings.SlotMachine_6:
                    outcomeList_slotMachine_6.Clear();
                    Console.WriteLine("outcome list6 size: " + outcomeList_slotMachine_6.Count);
                    break;
                case Settings.SlotMachine_7:
                    outcomeList_slotMachine_7.Clear();
                    Console.WriteLine("outcome list7 size: " + outcomeList_slotMachine_7.Count);
                    break;
                case Settings.SlotMachine_8:
                    outcomeList_slotMachine_8.Clear();
                    Console.WriteLine("outcome list8 size: " + outcomeList_slotMachine_8.Count);
                    break;
                case Settings.SlotMachine_9:
                    outcomeList_slotMachine_9.Clear();
                    Console.WriteLine("outcome list9 size: " + outcomeList_slotMachine_9.Count);
                    break;
                case Settings.SlotMachine_10:
                    outcomeList_slotMachine_10.Clear();
                    Console.WriteLine("outcome list10 size: " + outcomeList_slotMachine_10.Count);
                    break;
                default:
                    Console.WriteLine("No slot machine selected  but ClearJson button clicked");
                    break;
            }
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
        }

        private void restoreAllDefaults_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + restoreAllDefaults_btn.Name);
            Console.WriteLine("Clear and then Restore default json values");

            //set defaults for all slot machines
            setListBoxToOutcomeList(outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_1, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_2, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_3, outcomeList_slotMachine_default);            
            overwriteOutComeList(outcomeList_slotMachine_4, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_5, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_6, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_7, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_8, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_9, outcomeList_slotMachine_default);
            overwriteOutComeList(outcomeList_slotMachine_10, outcomeList_slotMachine_default);
            reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
            reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
            reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
            reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
            
            for(int i = 0; i<spinReels_default.Count; i++)
            {
                spinReelsTime_slotMachine_1[i] = spinReels_default[i];
                spinReelsTime_slotMachine_2[i] = spinReels_default[i];
                spinReelsTime_slotMachine_3[i] = spinReels_default[i];
                spinReelsTime_slotMachine_4[i] = spinReels_default[i];
                spinReelsTime_slotMachine_5[i] = spinReels_default[i];
                spinReelsTime_slotMachine_6[i] = spinReels_default[i];
                spinReelsTime_slotMachine_7[i] = spinReels_default[i];
                spinReelsTime_slotMachine_8[i] = spinReels_default[i];
                spinReelsTime_slotMachine_9[i] = spinReels_default[i];
                spinReelsTime_slotMachine_10[i] = spinReels_default[i];
            }

            //set defaults for all environs

            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
        }

        private void delSelectedItem_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + delSelectedItem_btn_slotMach.Name);
            if (listBox_slotMach.SelectedIndex < 0)
            {
                Console.WriteLine("No List box option selected to remove");
            }
            else
            {
                int indexToRemove = listBox_slotMach.SelectedIndex;
                Console.WriteLine("Deleting selected item: " + listBox_slotMach.SelectedItem);

                Object settings = settings_comboBox.SelectedItem;
                switch (settings)
                {
                    case Settings.SlotMachine_1:
                        outcomeList_slotMachine_1.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_1);
                        Console.WriteLine("outcome list1 size: " + outcomeList_slotMachine_1.Count);
                        break;
                    case Settings.SlotMachine_2:
                        outcomeList_slotMachine_2.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_2);
                        Console.WriteLine("outcome list2 size: " + outcomeList_slotMachine_2.Count);
                        break;
                    case Settings.SlotMachine_3:
                        outcomeList_slotMachine_3.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_3);
                        Console.WriteLine("outcome list3 size: " + outcomeList_slotMachine_3.Count);
                        break;
                    case Settings.SlotMachine_4:
                        outcomeList_slotMachine_4.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_4);
                        Console.WriteLine("outcome list4 size: " + outcomeList_slotMachine_4.Count);
                        break;
                    case Settings.SlotMachine_5:
                        outcomeList_slotMachine_5.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_5);
                        Console.WriteLine("outcome list5 size: " + outcomeList_slotMachine_5.Count);
                        break;
                    case Settings.SlotMachine_6:
                        outcomeList_slotMachine_6.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_6);
                        Console.WriteLine("outcome list6 size: " + outcomeList_slotMachine_6.Count);
                        break;
                    case Settings.SlotMachine_7:
                        outcomeList_slotMachine_7.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_7);
                        Console.WriteLine("outcome list7 size: " + outcomeList_slotMachine_7.Count);
                        break;
                    case Settings.SlotMachine_8:
                        outcomeList_slotMachine_8.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_8);
                        Console.WriteLine("outcome list8 size: " + outcomeList_slotMachine_8.Count);
                        break;
                    case Settings.SlotMachine_9:
                        outcomeList_slotMachine_9.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_9);
                        Console.WriteLine("outcome list9 size: " + outcomeList_slotMachine_9.Count);
                        break;
                    case Settings.SlotMachine_10:
                        outcomeList_slotMachine_10.RemoveAt(indexToRemove);
                        setListBoxToOutcomeList(outcomeList_slotMachine_10);
                        Console.WriteLine("outcome list10 size: " + outcomeList_slotMachine_10.Count);
                        break;
                    default:
                        Console.WriteLine("No slot machine selected  but Random button clicked");
                        break;
                }
                listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
            }
        }

        private void randomizeItems_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + randomizeItems_btn_slotMach.Name);

            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    outcomeListRandomizer(outcomeList_slotMachine_1);
                    setListBoxToOutcomeList(outcomeList_slotMachine_1);
                    Console.WriteLine("outcome list1 size: " + outcomeList_slotMachine_1.Count);
                    break;
                case Settings.SlotMachine_2:
                    outcomeListRandomizer(outcomeList_slotMachine_2);
                    setListBoxToOutcomeList(outcomeList_slotMachine_2);
                    Console.WriteLine("outcome list2 size: " + outcomeList_slotMachine_2.Count);
                    break;
                case Settings.SlotMachine_3:
                    outcomeListRandomizer(outcomeList_slotMachine_3);
                    setListBoxToOutcomeList(outcomeList_slotMachine_3);
                    Console.WriteLine("outcome list3 size: " + outcomeList_slotMachine_3.Count);
                    break;
                case Settings.SlotMachine_4:
                    outcomeListRandomizer(outcomeList_slotMachine_4);
                    setListBoxToOutcomeList(outcomeList_slotMachine_4);
                    Console.WriteLine("outcome list4 size: " + outcomeList_slotMachine_4.Count);
                    break;
                case Settings.SlotMachine_5:
                    outcomeListRandomizer(outcomeList_slotMachine_5);
                    setListBoxToOutcomeList(outcomeList_slotMachine_5);
                    Console.WriteLine("outcome list5 size: " + outcomeList_slotMachine_5.Count);
                    break;
                case Settings.SlotMachine_6:
                    outcomeListRandomizer(outcomeList_slotMachine_6);
                    setListBoxToOutcomeList(outcomeList_slotMachine_6);
                    Console.WriteLine("outcome list6 size: " + outcomeList_slotMachine_6.Count);
                    break;
                case Settings.SlotMachine_7:
                    outcomeListRandomizer(outcomeList_slotMachine_7);
                    setListBoxToOutcomeList(outcomeList_slotMachine_7);
                    Console.WriteLine("outcome list7 size: " + outcomeList_slotMachine_7.Count);
                    break;
                case Settings.SlotMachine_8:
                    outcomeListRandomizer(outcomeList_slotMachine_8);
                    setListBoxToOutcomeList(outcomeList_slotMachine_8);
                    Console.WriteLine("outcome list8 size: " + outcomeList_slotMachine_8.Count);
                    break;
                case Settings.SlotMachine_9:
                    outcomeListRandomizer(outcomeList_slotMachine_9);
                    setListBoxToOutcomeList(outcomeList_slotMachine_9);
                    Console.WriteLine("outcome list9 size: " + outcomeList_slotMachine_9.Count);
                    break;
                case Settings.SlotMachine_10:
                    outcomeListRandomizer(outcomeList_slotMachine_10);
                    setListBoxToOutcomeList(outcomeList_slotMachine_10);
                    Console.WriteLine("outcome list10 size: " + outcomeList_slotMachine_10.Count);
                    break;
                default:
                    Console.WriteLine("No slot machine selected  but Random button clicked");
                    break;
            }
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;

        }

        private void outcomeListRandomizer(List<OutCome> listToRandomize)
        {
            Random r = new Random();
            //  Randomize items in list
            //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
            Console.WriteLine("Randomizing list");
            for (int n = listToRandomize.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                OutCome temp = listToRandomize[n];
                listToRandomize[n] = listToRandomize[k];
                listToRandomize[k] = temp;
            }
        }

        private void saveAll_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + saveAll_btn.Name);
            //List<String> jsonOutputStringList = new List<String> { };                                 
            //save json for each file           
            //writeJsonToFile(settings_comboBox.SelectedItem);
            foreach (Settings setting in settings_comboBox.Items)
            {
                writeJsonToFile(setting);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + save_btn.Name);
            writeJsonToFile(settings_comboBox.SelectedItem);
        }
        private void restoreDefaults_slotMac_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked: " + restoreDefaults_slotMac_btn.Name);
            setListBoxToOutcomeList(outcomeList_slotMachine_default);
            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    overwriteOutComeList(outcomeList_slotMachine_1, outcomeList_slotMachine_default);                    
                    Console.WriteLine("outcome list1 size: " + outcomeList_slotMachine_1.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_2:
                    overwriteOutComeList(outcomeList_slotMachine_2, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list2 size: " + outcomeList_slotMachine_2.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_3:
                    overwriteOutComeList(outcomeList_slotMachine_3, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list3 size: " + outcomeList_slotMachine_3.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_4:
                    overwriteOutComeList(outcomeList_slotMachine_4, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list4 size: " + outcomeList_slotMachine_4.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_5:
                    overwriteOutComeList(outcomeList_slotMachine_5, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list5 size: " + outcomeList_slotMachine_5.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_6:
                    overwriteOutComeList(outcomeList_slotMachine_6, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list6 size: " + outcomeList_slotMachine_6.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_7:
                    overwriteOutComeList(outcomeList_slotMachine_7, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list7 size: " + outcomeList_slotMachine_7.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_8:
                    overwriteOutComeList(outcomeList_slotMachine_8, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list8 size: " + outcomeList_slotMachine_8.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_9:
                    overwriteOutComeList(outcomeList_slotMachine_9, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list9 size: " + outcomeList_slotMachine_9.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                case Settings.SlotMachine_10:
                    overwriteOutComeList(outcomeList_slotMachine_10, outcomeList_slotMachine_default);
                    Console.WriteLine("outcome list10 size: " + outcomeList_slotMachine_10.Count);
                    reelA_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[0]);
                    reelB_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[1]);
                    reelC_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[2]);
                    reelD_spinTime_counter.Value = Convert.ToDecimal(spinReels_default[3]);
                    break;
                default:
                    Console.WriteLine("No slot machine selected  but restore def button clicked");
                    break;
            }
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count;
        }

        private void reelA_spinTime_counter_ValueChanged(object sender, EventArgs e)
        {
            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {

                case Settings.SlotMachine_1:
                    spinReelsTime_slotMachine_1[0] = (float)reelA_spinTime_counter.Value;                    
                    break;

                case Settings.SlotMachine_2:
                    spinReelsTime_slotMachine_2[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_3:
                    spinReelsTime_slotMachine_3[0] = (float)reelA_spinTime_counter.Value;                    
                    break;
                case Settings.SlotMachine_4:
                    spinReelsTime_slotMachine_4[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_5:
                    spinReelsTime_slotMachine_5[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_6:
                    spinReelsTime_slotMachine_6[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_7:
                    spinReelsTime_slotMachine_7[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_8:
                    spinReelsTime_slotMachine_8[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_9:
                    spinReelsTime_slotMachine_9[0] = (float)reelA_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_10:
                    spinReelsTime_slotMachine_10[0] = (float)reelA_spinTime_counter.Value;
                    break;
                default:
                    Console.WriteLine("Default for reelA counter");
                    break;
            }
        }

        private void reelB_spinTime_counter_ValueChanged(object sender, EventArgs e)
        {
            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    spinReelsTime_slotMachine_1[1] = (float)reelB_spinTime_counter.Value;
                    break;

                case Settings.SlotMachine_2:
                    spinReelsTime_slotMachine_2[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_3:
                    spinReelsTime_slotMachine_3[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_4:
                    spinReelsTime_slotMachine_4[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_5:
                    spinReelsTime_slotMachine_5[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_6:
                    spinReelsTime_slotMachine_6[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_7:
                    spinReelsTime_slotMachine_7[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_8:
                    spinReelsTime_slotMachine_8[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_9:
                    spinReelsTime_slotMachine_9[1] = (float)reelB_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_10:
                    spinReelsTime_slotMachine_10[1] = (float)reelB_spinTime_counter.Value;
                    break;
                default:
                    Console.WriteLine("Default for reelB counter");
                    break;
            }
        }

        private void reelC_spinTime_counter_ValueChanged(object sender, EventArgs e)
        {
            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    spinReelsTime_slotMachine_1[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_2:
                    spinReelsTime_slotMachine_2[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_3:
                    spinReelsTime_slotMachine_3[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_4:
                    spinReelsTime_slotMachine_4[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_5:
                    spinReelsTime_slotMachine_5[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_6:
                    spinReelsTime_slotMachine_6[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_7:
                    spinReelsTime_slotMachine_7[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_8:
                    spinReelsTime_slotMachine_8[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_9:
                    spinReelsTime_slotMachine_9[2] = (float)reelC_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_10:
                    spinReelsTime_slotMachine_10[2] = (float)reelC_spinTime_counter.Value;
                    break;
                default:
                    Console.WriteLine("Default for reelC counter");
                    break;
            }
        }

        private void reelD_spinTime_counter_ValueChanged(object sender, EventArgs e)
        {
            Object settings = settings_comboBox.SelectedItem;
            switch (settings)
            {
                case Settings.SlotMachine_1:
                    spinReelsTime_slotMachine_1[3] = (float)reelD_spinTime_counter.Value;
                    break;

                case Settings.SlotMachine_2:
                    spinReelsTime_slotMachine_2[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_3:
                    spinReelsTime_slotMachine_3[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_4:
                    spinReelsTime_slotMachine_4[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_5:
                    spinReelsTime_slotMachine_5[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_6:
                    spinReelsTime_slotMachine_6[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_7:
                    spinReelsTime_slotMachine_7[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_8:
                    spinReelsTime_slotMachine_8[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_9:
                    spinReelsTime_slotMachine_9[3] = (float)reelD_spinTime_counter.Value;
                    break;
                case Settings.SlotMachine_10:
                    spinReelsTime_slotMachine_10[3] = (float)reelD_spinTime_counter.Value;
                    break;
                default:
                    Console.WriteLine("Default for reelD counter");
                    break;
            }
        }
    }

}
