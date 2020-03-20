﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoAdmin
{
    public partial class SlotMachineForm : Form
    {
        //************************** Class Variables ******************************************

        //------------------------ Outcome lists for each slot machine ------------------------
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


        //------------------------Reels spinning time lists for each slot machine -------------
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


        //------------------------Default list values for outcomes and Reels spin time----------
        // outcome list
        private List<OutCome> outcomeList_default = new List<OutCome> { OutCome.W, OutCome.W, OutCome.L, OutCome.NM, OutCome.L };
        // reels spin time
        private List<float> spinReels_default = new List<float> { 3.0f, 4.0f, 5.0f, 6.0f }; //[3,4,5,6]


        //------------------------ Outcome Type Enum ------------------------------------------
        enum OutCome
        {
            W,
            L,
            NM
        }

        //------------------------ Slot Machines names Enum -----------------------------------
        enum SlotMachine
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
            SlotMachine_10
        }

        //------------------------ Slot Machines C# Json Object --------------------------------
        class SlotMachineObj
        {
            public String ObjectName { get; set; }
            public List<String> OutcomeList { get; set; }

            public List<float> ReelSpinTime { get; set; }
        }

        //************************** Constructor ***********************************************
        public SlotMachineForm()
        {
            InitializeComponent();

            initOutcomeListsWithDefaults();

            initSlotMachComboBox();

            panel_sm_body.Visible = false;  // slotmachine body panel hidden until a slotmachine is selected from combo box

        } // constructor ends here



        //********************************* Init **************************************************

        //------------------------ init slot mach combo box --------------------------------
        private void initSlotMachComboBox()
        {
            foreach (SlotMachine sm in Enum.GetValues(typeof(SlotMachine)))
            {
                slotMachine_comboBox.Items.Add(sm);
            }
        }

        //------------------------ Init outcome lists with defaults--------------------------------
        private void initOutcomeListsWithDefaults()
        {
            // init with defaults if json file not found in directory.
            overwriteOutComeList(outcomeList_slotMachine_1, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_2, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_3, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_4, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_5, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_6, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_7, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_8, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_9, outcomeList_default);
            overwriteOutComeList(outcomeList_slotMachine_10, outcomeList_default);

        }

        //**************** Helpers Functions *****************************************************


        //------------------------ Randomize a list of outcomes --------------------------------
        private void outcomeListRandomizer(List<OutCome> listToRandomize)
        {
            Random r = new Random();
            //  Randomize items in list
            //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle            
            for (int n = listToRandomize.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                OutCome temp = listToRandomize[n];
                listToRandomize[n] = listToRandomize[k];
                listToRandomize[k] = temp;
            }
        }

        //------------------------ overwrites a outcome list with another --------------------------------
        private void overwriteOutComeList(List<OutCome> listToOverwrite, List<OutCome> overwireFromList)
        {
            listToOverwrite.Clear();
            foreach (OutCome outcome in overwireFromList)
            {
                listToOverwrite.Add(outcome);
            }
        }

        // ---- Gets outcome list based off current combobox selection------
        private List<OutCome> getOutcomeListOfSlotMachine(SlotMachine sm)
        {
            switch (sm)
            {
                case SlotMachine.SlotMachine_1:
                    return outcomeList_slotMachine_1;
                case SlotMachine.SlotMachine_2:
                    return outcomeList_slotMachine_2;
                case SlotMachine.SlotMachine_3:
                    return outcomeList_slotMachine_3;
                case SlotMachine.SlotMachine_4:
                    return outcomeList_slotMachine_4;
                case SlotMachine.SlotMachine_5:
                    return outcomeList_slotMachine_5;
                case SlotMachine.SlotMachine_6:
                    return outcomeList_slotMachine_6;
                case SlotMachine.SlotMachine_7:
                    return outcomeList_slotMachine_7;
                case SlotMachine.SlotMachine_8:
                    return outcomeList_slotMachine_8;
                case SlotMachine.SlotMachine_9:
                    return outcomeList_slotMachine_9;
                case SlotMachine.SlotMachine_10:
                    return outcomeList_slotMachine_10;
                default:
                    return outcomeList_default;
            }
        }

        //**************** Gui Action Functions **************************************************

        //------------------------ REMOVE ME--------------------------------
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        //------------------------ When Form loads --------------------------------
        private void SlotMachineForm_Load_1(object sender, EventArgs e)
        {

        }

        //------------------------ choose folder button--------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

            }
        }



        // ---- Set the selected SM outcome list to list box ----------
        private void setSelectedSmToListBox()
        {
            setSlotMachOutcomeListToListBox((SlotMachine)slotMachine_comboBox.SelectedItem);
        }

        // ---- Set a SM outcome list to list box ----------

        private void setSlotMachOutcomeListToListBox(SlotMachine sm)
        {
            getOutcomeListOfSlotMachine(sm).Clear();
            //update sm outcome list with list box items
            foreach (OutCome outcome in listBox_slotMach.Items)
            {
                getOutcomeListOfSlotMachine(sm).Add(outcome);
            }

        }


        // ---- Set list box to selected slotmachine's outcome list ------
        private void setListBoxToSelectedSlotMachOutcomeList()
        {
            setListBoxToSlotMachOutcomeList((SlotMachine)slotMachine_comboBox.SelectedItem);
        }


        // ---- Set list box items to a slotmachine's outcome list ------

        private void setListBoxToSlotMachOutcomeList(SlotMachine sm)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Clear(); //delete listBox items

            //update list box with sm's outcome list
            foreach (OutCome outcome in getOutcomeListOfSlotMachine(sm))
            {
                listBox_slotMach.Items.Add(outcome);
            }
            listBox_slotMach.EndUpdate();
        }

        // ---- Slot Machine dropdown index change ------
        private void slotMachine_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlotMachine selectedSlotMach = (SlotMachine)slotMachine_comboBox.SelectedItem;
            sm_title_label.Text = (selectedSlotMach.ToString()).Replace("_", " ");  // set Title to current selected combo box

            panel_sm_body.Visible = true;  // enable slot mach body panel

            setListBoxToSelectedSlotMachOutcomeList();

            updateListBoxCountLabel();
        }

        // ---- Updates the listbox count label ------
        private void updateListBoxCountLabel()
        {
            listSizeNum_label_slotMach.Text = "" + listBox_slotMach.Items.Count; // to show current list size
        }


        // ---- Clears the list box and updates outcome list of selected Slot Machine------
        private void clear_ListBox_btn_Click(object sender, EventArgs e)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Clear(); //delete listBox items
            listBox_slotMach.EndUpdate();

            setSelectedSmToListBox();

            updateListBoxCountLabel();

        }

        // ---- Adds win to list box and to outcome list of selected Slot Machine------
        private void addWin_btn_slotMach_Click(object sender, EventArgs e)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Add(OutCome.W); //add Win to list box
            listBox_slotMach.EndUpdate();

            setSelectedSmToListBox();

            updateListBoxCountLabel();
        }


        // ---- Adds near-miss to list box and to outcome list of selected Slot Machine------
        private void addNearMiss_btn_slotMach_Click(object sender, EventArgs e)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Add(OutCome.NM); //add near-miss to list box
            listBox_slotMach.EndUpdate();

            setSelectedSmToListBox();

            updateListBoxCountLabel();
        }

        // ---- Adds loss to list box and to outcome list of selected Slot Machine------
        private void addLoss_btn_slotMach_Click(object sender, EventArgs e)
        {
            listBox_slotMach.BeginUpdate();
            listBox_slotMach.Items.Add(OutCome.L); //add loss to list box
            listBox_slotMach.EndUpdate();

            setSelectedSmToListBox();

            updateListBoxCountLabel();
        }

        // ---- Deletes a selected Outcome from listbox and outcome list of selected Slot Machine------
        private void delSelectedItem_btn_slotMach_Click(object sender, EventArgs e)
        {
            if (listBox_slotMach.SelectedIndex < 0)
            {
                Console.WriteLine("No List box option selected to remove");
            }
            else
            {
                int indexToRemove = listBox_slotMach.SelectedIndex;

                listBox_slotMach.BeginUpdate();
                listBox_slotMach.Items.RemoveAt(indexToRemove); //delete selected outcome
                listBox_slotMach.EndUpdate();

                setSelectedSmToListBox();

                updateListBoxCountLabel();
            }
        }

        // ---- Randomizes the outcome list of selected Slot Machine and updates list box ------
        private void randomizeItems_btn_slotMach_Click(object sender, EventArgs e)
        {   
            outcomeListRandomizer(getOutcomeListOfSlotMachine((SlotMachine)slotMachine_comboBox.SelectedItem)); //randomize the selected SM's outcome list

            
            setListBoxToSelectedSlotMachOutcomeList(); // set list box to the randomized list
        }

        // ---- Restore defaults for the outcome list of selected Slot Machine and updates list box ------
        private void restoreDefaults_slotMac_btn_Click(object sender, EventArgs e)
        {
            overwriteOutComeList(getOutcomeListOfSlotMachine((SlotMachine)slotMachine_comboBox.SelectedItem), outcomeList_default); //rewrite outcome list to default

            setListBoxToSelectedSlotMachOutcomeList(); // set list box to the outcome list

            updateListBoxCountLabel(); // update list count
        }

        // ---- Restore ALL defaults for all values of slot machine json and UI objects ------
        private void restoreAllDefaults_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
