namespace AdminSettings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addWin_btn_slotMach = new System.Windows.Forms.Button();
            this.settings_comboBox = new System.Windows.Forms.ComboBox();
            this.addNearMiss_btn_slotMach = new System.Windows.Forms.Button();
            this.addLoss_btn_slotMach = new System.Windows.Forms.Button();
            this.groupBox_slotMach = new System.Windows.Forms.GroupBox();
            this.reelD_spinTime_label = new System.Windows.Forms.Label();
            this.reelC_spinTime_label = new System.Windows.Forms.Label();
            this.reelD_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelC_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelB_spinTime_label = new System.Windows.Forms.Label();
            this.reelA_spinTime_label = new System.Windows.Forms.Label();
            this.reelB_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelA_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.restoreDefaults_slotMac_btn = new System.Windows.Forms.Button();
            this.listSizeNum_label_slotMach = new System.Windows.Forms.Label();
            this.randomizeItems_btn_slotMach = new System.Windows.Forms.Button();
            this.delSelectedItem_btn_slotMach = new System.Windows.Forms.Button();
            this.clearJson_slotMac_btn = new System.Windows.Forms.Button();
            this.listSizeText_label_slotMach = new System.Windows.Forms.Label();
            this.listBox_slotMach = new System.Windows.Forms.ListBox();
            this.restoreAllDefaults_btn = new System.Windows.Forms.Button();
            this.groupBox_Envr = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox_envir = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.saveAll_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.ttip_default_SM = new System.Windows.Forms.ToolTip(this.components);
            this.ttip_clearJson_SM = new System.Windows.Forms.ToolTip(this.components);
            this.ttip_default_All = new System.Windows.Forms.ToolTip(this.components);
            this.ttip_save_All = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_slotMach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reelD_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelC_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelB_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelA_spinTime_counter)).BeginInit();
            this.groupBox_Envr.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWin_btn_slotMach
            // 
            this.addWin_btn_slotMach.Location = new System.Drawing.Point(25, 19);
            this.addWin_btn_slotMach.Name = "addWin_btn_slotMach";
            this.addWin_btn_slotMach.Size = new System.Drawing.Size(100, 33);
            this.addWin_btn_slotMach.TabIndex = 0;
            this.addWin_btn_slotMach.Tag = "SlotMachine";
            this.addWin_btn_slotMach.Text = "Add Win";
            this.addWin_btn_slotMach.UseVisualStyleBackColor = true;
            this.addWin_btn_slotMach.Click += new System.EventHandler(this.addWin_btn_slotMach_Click);
            // 
            // settings_comboBox
            // 
            this.settings_comboBox.FormattingEnabled = true;
            this.settings_comboBox.Location = new System.Drawing.Point(12, 12);
            this.settings_comboBox.Name = "settings_comboBox";
            this.settings_comboBox.Size = new System.Drawing.Size(262, 21);
            this.settings_comboBox.TabIndex = 1;
            this.settings_comboBox.Text = "Select a json here..";
            this.settings_comboBox.SelectedIndexChanged += new System.EventHandler(this.settings_comboBox_SelectedIndexChanged);
            // 
            // addNearMiss_btn_slotMach
            // 
            this.addNearMiss_btn_slotMach.Location = new System.Drawing.Point(25, 58);
            this.addNearMiss_btn_slotMach.Name = "addNearMiss_btn_slotMach";
            this.addNearMiss_btn_slotMach.Size = new System.Drawing.Size(100, 33);
            this.addNearMiss_btn_slotMach.TabIndex = 2;
            this.addNearMiss_btn_slotMach.Tag = "SlotMachine";
            this.addNearMiss_btn_slotMach.Text = "Add NearMiss";
            this.addNearMiss_btn_slotMach.UseVisualStyleBackColor = true;
            this.addNearMiss_btn_slotMach.Click += new System.EventHandler(this.addNearMiss_btn_slotMach_Click);
            // 
            // addLoss_btn_slotMach
            // 
            this.addLoss_btn_slotMach.Location = new System.Drawing.Point(25, 97);
            this.addLoss_btn_slotMach.Name = "addLoss_btn_slotMach";
            this.addLoss_btn_slotMach.Size = new System.Drawing.Size(100, 34);
            this.addLoss_btn_slotMach.TabIndex = 3;
            this.addLoss_btn_slotMach.Tag = "SlotMachine";
            this.addLoss_btn_slotMach.Text = "Add Loss";
            this.addLoss_btn_slotMach.UseVisualStyleBackColor = true;
            this.addLoss_btn_slotMach.Click += new System.EventHandler(this.addLoss_btn_slotMach_Click);
            // 
            // groupBox_slotMach
            // 
            this.groupBox_slotMach.Controls.Add(this.reelD_spinTime_label);
            this.groupBox_slotMach.Controls.Add(this.reelC_spinTime_label);
            this.groupBox_slotMach.Controls.Add(this.reelD_spinTime_counter);
            this.groupBox_slotMach.Controls.Add(this.reelC_spinTime_counter);
            this.groupBox_slotMach.Controls.Add(this.reelB_spinTime_label);
            this.groupBox_slotMach.Controls.Add(this.reelA_spinTime_label);
            this.groupBox_slotMach.Controls.Add(this.reelB_spinTime_counter);
            this.groupBox_slotMach.Controls.Add(this.reelA_spinTime_counter);
            this.groupBox_slotMach.Controls.Add(this.restoreDefaults_slotMac_btn);
            this.groupBox_slotMach.Controls.Add(this.listSizeNum_label_slotMach);
            this.groupBox_slotMach.Controls.Add(this.randomizeItems_btn_slotMach);
            this.groupBox_slotMach.Controls.Add(this.delSelectedItem_btn_slotMach);
            this.groupBox_slotMach.Controls.Add(this.clearJson_slotMac_btn);
            this.groupBox_slotMach.Controls.Add(this.listSizeText_label_slotMach);
            this.groupBox_slotMach.Controls.Add(this.addLoss_btn_slotMach);
            this.groupBox_slotMach.Controls.Add(this.listBox_slotMach);
            this.groupBox_slotMach.Controls.Add(this.addNearMiss_btn_slotMach);
            this.groupBox_slotMach.Controls.Add(this.addWin_btn_slotMach);
            this.groupBox_slotMach.Location = new System.Drawing.Point(12, 41);
            this.groupBox_slotMach.Name = "groupBox_slotMach";
            this.groupBox_slotMach.Size = new System.Drawing.Size(755, 361);
            this.groupBox_slotMach.TabIndex = 6;
            this.groupBox_slotMach.TabStop = false;
            this.groupBox_slotMach.Tag = "SlotMachine";
            this.groupBox_slotMach.Text = "Json:";
            this.groupBox_slotMach.Visible = false;
            // 
            // reelD_spinTime_label
            // 
            this.reelD_spinTime_label.AutoSize = true;
            this.reelD_spinTime_label.Location = new System.Drawing.Point(297, 103);
            this.reelD_spinTime_label.Name = "reelD_spinTime_label";
            this.reelD_spinTime_label.Size = new System.Drawing.Size(132, 13);
            this.reelD_spinTime_label.TabIndex = 17;
            this.reelD_spinTime_label.Text = "ReelD Spin time(seconds):";
            // 
            // reelC_spinTime_label
            // 
            this.reelC_spinTime_label.AutoSize = true;
            this.reelC_spinTime_label.Location = new System.Drawing.Point(297, 77);
            this.reelC_spinTime_label.Name = "reelC_spinTime_label";
            this.reelC_spinTime_label.Size = new System.Drawing.Size(131, 13);
            this.reelC_spinTime_label.TabIndex = 16;
            this.reelC_spinTime_label.Text = "ReelC Spin time(seconds):";
            // 
            // reelD_spinTime_counter
            // 
            this.reelD_spinTime_counter.Location = new System.Drawing.Point(434, 101);
            this.reelD_spinTime_counter.Name = "reelD_spinTime_counter";
            this.reelD_spinTime_counter.Size = new System.Drawing.Size(120, 20);
            this.reelD_spinTime_counter.TabIndex = 15;
            this.reelD_spinTime_counter.ValueChanged += new System.EventHandler(this.reelD_spinTime_counter_ValueChanged);
            // 
            // reelC_spinTime_counter
            // 
            this.reelC_spinTime_counter.Location = new System.Drawing.Point(434, 75);
            this.reelC_spinTime_counter.Name = "reelC_spinTime_counter";
            this.reelC_spinTime_counter.Size = new System.Drawing.Size(120, 20);
            this.reelC_spinTime_counter.TabIndex = 14;
            this.reelC_spinTime_counter.ValueChanged += new System.EventHandler(this.reelC_spinTime_counter_ValueChanged);
            // 
            // reelB_spinTime_label
            // 
            this.reelB_spinTime_label.AutoSize = true;
            this.reelB_spinTime_label.Location = new System.Drawing.Point(297, 53);
            this.reelB_spinTime_label.Name = "reelB_spinTime_label";
            this.reelB_spinTime_label.Size = new System.Drawing.Size(131, 13);
            this.reelB_spinTime_label.TabIndex = 13;
            this.reelB_spinTime_label.Text = "ReelB Spin time(seconds):";
            // 
            // reelA_spinTime_label
            // 
            this.reelA_spinTime_label.AutoSize = true;
            this.reelA_spinTime_label.Location = new System.Drawing.Point(297, 25);
            this.reelA_spinTime_label.Name = "reelA_spinTime_label";
            this.reelA_spinTime_label.Size = new System.Drawing.Size(131, 13);
            this.reelA_spinTime_label.TabIndex = 12;
            this.reelA_spinTime_label.Text = "ReelA Spin time(seconds):";
            // 
            // reelB_spinTime_counter
            // 
            this.reelB_spinTime_counter.Location = new System.Drawing.Point(434, 49);
            this.reelB_spinTime_counter.Name = "reelB_spinTime_counter";
            this.reelB_spinTime_counter.Size = new System.Drawing.Size(120, 20);
            this.reelB_spinTime_counter.TabIndex = 11;
            this.reelB_spinTime_counter.ValueChanged += new System.EventHandler(this.reelB_spinTime_counter_ValueChanged);
            // 
            // reelA_spinTime_counter
            // 
            this.reelA_spinTime_counter.Location = new System.Drawing.Point(434, 23);
            this.reelA_spinTime_counter.Name = "reelA_spinTime_counter";
            this.reelA_spinTime_counter.Size = new System.Drawing.Size(120, 20);
            this.reelA_spinTime_counter.TabIndex = 10;
            this.reelA_spinTime_counter.ValueChanged += new System.EventHandler(this.reelA_spinTime_counter_ValueChanged);
            // 
            // restoreDefaults_slotMac_btn
            // 
            this.restoreDefaults_slotMac_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreDefaults_slotMac_btn.Location = new System.Drawing.Point(607, 19);
            this.restoreDefaults_slotMac_btn.Name = "restoreDefaults_slotMac_btn";
            this.restoreDefaults_slotMac_btn.Size = new System.Drawing.Size(99, 30);
            this.restoreDefaults_slotMac_btn.TabIndex = 8;
            this.restoreDefaults_slotMac_btn.Tag = "SlotMachine";
            this.restoreDefaults_slotMac_btn.Text = "Restore defaults";
            this.restoreDefaults_slotMac_btn.UseVisualStyleBackColor = true;
            this.restoreDefaults_slotMac_btn.Click += new System.EventHandler(this.restoreDefaults_slotMac_btn_Click);
            // 
            // listSizeNum_label_slotMach
            // 
            this.listSizeNum_label_slotMach.AutoSize = true;
            this.listSizeNum_label_slotMach.Location = new System.Drawing.Point(225, 208);
            this.listSizeNum_label_slotMach.Name = "listSizeNum_label_slotMach";
            this.listSizeNum_label_slotMach.Size = new System.Drawing.Size(25, 13);
            this.listSizeNum_label_slotMach.TabIndex = 4;
            this.listSizeNum_label_slotMach.Tag = "SlotMachine";
            this.listSizeNum_label_slotMach.Text = "size";
            // 
            // randomizeItems_btn_slotMach
            // 
            this.randomizeItems_btn_slotMach.Location = new System.Drawing.Point(25, 175);
            this.randomizeItems_btn_slotMach.Name = "randomizeItems_btn_slotMach";
            this.randomizeItems_btn_slotMach.Size = new System.Drawing.Size(100, 30);
            this.randomizeItems_btn_slotMach.TabIndex = 3;
            this.randomizeItems_btn_slotMach.Tag = "SlotMachine";
            this.randomizeItems_btn_slotMach.Text = "Randomize";
            this.randomizeItems_btn_slotMach.UseVisualStyleBackColor = true;
            this.randomizeItems_btn_slotMach.Click += new System.EventHandler(this.randomizeItems_btn_Click);
            // 
            // delSelectedItem_btn_slotMach
            // 
            this.delSelectedItem_btn_slotMach.Location = new System.Drawing.Point(25, 136);
            this.delSelectedItem_btn_slotMach.Name = "delSelectedItem_btn_slotMach";
            this.delSelectedItem_btn_slotMach.Size = new System.Drawing.Size(100, 37);
            this.delSelectedItem_btn_slotMach.TabIndex = 2;
            this.delSelectedItem_btn_slotMach.Tag = "SlotMachine";
            this.delSelectedItem_btn_slotMach.Text = "Delete selected outcome";
            this.delSelectedItem_btn_slotMach.UseVisualStyleBackColor = true;
            this.delSelectedItem_btn_slotMach.Click += new System.EventHandler(this.delSelectedItem_btn_Click);
            // 
            // clearJson_slotMac_btn
            // 
            this.clearJson_slotMac_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearJson_slotMac_btn.Location = new System.Drawing.Point(26, 211);
            this.clearJson_slotMac_btn.Name = "clearJson_slotMac_btn";
            this.clearJson_slotMac_btn.Size = new System.Drawing.Size(99, 31);
            this.clearJson_slotMac_btn.TabIndex = 7;
            this.clearJson_slotMac_btn.Tag = "SlotMachine";
            this.clearJson_slotMac_btn.Text = "Clear List";
            this.clearJson_slotMac_btn.UseVisualStyleBackColor = true;
            this.clearJson_slotMac_btn.Click += new System.EventHandler(this.clearJson_btn_Click);
            // 
            // listSizeText_label_slotMach
            // 
            this.listSizeText_label_slotMach.AutoSize = true;
            this.listSizeText_label_slotMach.Location = new System.Drawing.Point(128, 208);
            this.listSizeText_label_slotMach.Name = "listSizeText_label_slotMach";
            this.listSizeText_label_slotMach.Size = new System.Drawing.Size(104, 13);
            this.listSizeText_label_slotMach.TabIndex = 1;
            this.listSizeText_label_slotMach.Tag = "SlotMachine";
            this.listSizeText_label_slotMach.Text = "Size of outcome list: ";
            // 
            // listBox_slotMach
            // 
            this.listBox_slotMach.FormattingEnabled = true;
            this.listBox_slotMach.Location = new System.Drawing.Point(131, 19);
            this.listBox_slotMach.Name = "listBox_slotMach";
            this.listBox_slotMach.Size = new System.Drawing.Size(158, 186);
            this.listBox_slotMach.TabIndex = 0;
            this.listBox_slotMach.Tag = "SlotMachine";
            this.listBox_slotMach.SelectedIndexChanged += new System.EventHandler(this.listBox_slotMach_SelectedIndexChanged);
            // 
            // restoreAllDefaults_btn
            // 
            this.restoreAllDefaults_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreAllDefaults_btn.Location = new System.Drawing.Point(589, 12);
            this.restoreAllDefaults_btn.Name = "restoreAllDefaults_btn";
            this.restoreAllDefaults_btn.Size = new System.Drawing.Size(129, 23);
            this.restoreAllDefaults_btn.TabIndex = 8;
            this.restoreAllDefaults_btn.Text = "Restore All Defaults";
            this.restoreAllDefaults_btn.UseVisualStyleBackColor = true;
            this.restoreAllDefaults_btn.Click += new System.EventHandler(this.restoreAllDefaults_btn_Click);
            // 
            // groupBox_Envr
            // 
            this.groupBox_Envr.Controls.Add(this.button1);
            this.groupBox_Envr.Controls.Add(this.label1);
            this.groupBox_Envr.Controls.Add(this.button2);
            this.groupBox_Envr.Controls.Add(this.button3);
            this.groupBox_Envr.Controls.Add(this.button4);
            this.groupBox_Envr.Controls.Add(this.label2);
            this.groupBox_Envr.Controls.Add(this.button5);
            this.groupBox_Envr.Controls.Add(this.listBox_envir);
            this.groupBox_Envr.Controls.Add(this.button6);
            this.groupBox_Envr.Controls.Add(this.button7);
            this.groupBox_Envr.Location = new System.Drawing.Point(12, 41);
            this.groupBox_Envr.Name = "groupBox_Envr";
            this.groupBox_Envr.Size = new System.Drawing.Size(755, 361);
            this.groupBox_Envr.TabIndex = 7;
            this.groupBox_Envr.TabStop = false;
            this.groupBox_Envr.Tag = "Environment_1";
            this.groupBox_Envr.Text = "Json preview:";
            this.groupBox_Envr.Visible = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(576, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 18;
            this.button1.Tag = "SlotMachine";
            this.button1.Text = "Restore defaults";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 16;
            this.label1.Tag = "SlotMachine";
            this.label1.Text = "size";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 14;
            this.button2.Tag = "SlotMachine";
            this.button2.Text = "Randomize Items";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 12;
            this.button3.Tag = "SlotMachine";
            this.button3.Text = "Delete Selected item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(576, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 31);
            this.button4.TabIndex = 17;
            this.button4.Tag = "SlotMachine";
            this.button4.Text = "Clear Json";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Tag = "SlotMachine";
            this.label2.Text = "Size of outcome list: ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 34);
            this.button5.TabIndex = 15;
            this.button5.Tag = "SlotMachine";
            this.button5.Text = "Add Loss";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox_envir
            // 
            this.listBox_envir.FormattingEnabled = true;
            this.listBox_envir.Location = new System.Drawing.Point(284, 43);
            this.listBox_envir.Name = "listBox_envir";
            this.listBox_envir.Size = new System.Drawing.Size(158, 186);
            this.listBox_envir.TabIndex = 9;
            this.listBox_envir.Tag = "SlotMachine";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(127, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 33);
            this.button6.TabIndex = 13;
            this.button6.Tag = "SlotMachine";
            this.button6.Text = "Add NearMiss";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(127, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 33);
            this.button7.TabIndex = 10;
            this.button7.Tag = "SlotMachine";
            this.button7.Text = "Add Win";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // saveAll_btn
            // 
            this.saveAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAll_btn.ForeColor = System.Drawing.Color.Black;
            this.saveAll_btn.Location = new System.Drawing.Point(457, 12);
            this.saveAll_btn.Name = "saveAll_btn";
            this.saveAll_btn.Size = new System.Drawing.Size(87, 21);
            this.saveAll_btn.TabIndex = 9;
            this.saveAll_btn.Text = "Save All";
            this.saveAll_btn.UseVisualStyleBackColor = true;
            this.saveAll_btn.Click += new System.EventHandler(this.saveAll_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.Black;
            this.save_btn.Location = new System.Drawing.Point(328, 11);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(87, 21);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.saveAll_btn);
            this.Controls.Add(this.restoreAllDefaults_btn);
            this.Controls.Add(this.settings_comboBox);
            this.Controls.Add(this.groupBox_slotMach);
            this.Controls.Add(this.groupBox_Envr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_slotMach.ResumeLayout(false);
            this.groupBox_slotMach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reelD_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelC_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelB_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelA_spinTime_counter)).EndInit();
            this.groupBox_Envr.ResumeLayout(false);
            this.groupBox_Envr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addWin_btn_slotMach;
        private System.Windows.Forms.ComboBox settings_comboBox;
        private System.Windows.Forms.Button addNearMiss_btn_slotMach;
        private System.Windows.Forms.Button addLoss_btn_slotMach;
        private System.Windows.Forms.GroupBox groupBox_slotMach;
        private System.Windows.Forms.ListBox listBox_slotMach;
        private System.Windows.Forms.Button clearJson_slotMac_btn;
        private System.Windows.Forms.Button restoreAllDefaults_btn;
        private System.Windows.Forms.Label listSizeText_label_slotMach;
        private System.Windows.Forms.Button delSelectedItem_btn_slotMach;
        private System.Windows.Forms.Button randomizeItems_btn_slotMach;
        private System.Windows.Forms.Label listSizeNum_label_slotMach;
        private System.Windows.Forms.GroupBox groupBox_Envr;
        private System.Windows.Forms.Button saveAll_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button restoreDefaults_slotMac_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox_envir;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip ttip_default_SM;
        private System.Windows.Forms.ToolTip ttip_clearJson_SM;
        private System.Windows.Forms.ToolTip ttip_default_All;
        private System.Windows.Forms.ToolTip ttip_save_All;
        private System.Windows.Forms.Label reelA_spinTime_label;
        private System.Windows.Forms.NumericUpDown reelB_spinTime_counter;
        private System.Windows.Forms.NumericUpDown reelA_spinTime_counter;
        private System.Windows.Forms.Label reelD_spinTime_label;
        private System.Windows.Forms.Label reelC_spinTime_label;
        private System.Windows.Forms.NumericUpDown reelD_spinTime_counter;
        private System.Windows.Forms.NumericUpDown reelC_spinTime_counter;
        private System.Windows.Forms.Label reelB_spinTime_label;
    }
}

