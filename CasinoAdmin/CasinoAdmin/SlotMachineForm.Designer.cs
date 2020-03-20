namespace CasinoAdmin
{
    partial class SlotMachineForm
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
            this.panel_sm_body = new System.Windows.Forms.Panel();
            this.sm_title_label = new System.Windows.Forms.Label();
            this.restoreDefaults_slotMac_btn = new System.Windows.Forms.Button();
            this.reelD_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelC_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelB_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelA_spinTime_counter = new System.Windows.Forms.NumericUpDown();
            this.reelD_spinTime_label = new System.Windows.Forms.Label();
            this.reelC_spinTime_label = new System.Windows.Forms.Label();
            this.reelB_spinTime_label = new System.Windows.Forms.Label();
            this.reelA_spinTime_label = new System.Windows.Forms.Label();
            this.listSizeNum_label_slotMach = new System.Windows.Forms.Label();
            this.randomizeItems_btn_slotMach = new System.Windows.Forms.Button();
            this.delSelectedItem_btn_slotMach = new System.Windows.Forms.Button();
            this.clear_ListBox = new System.Windows.Forms.Button();
            this.listSizeText_label_slotMach = new System.Windows.Forms.Label();
            this.addLoss_btn_slotMach = new System.Windows.Forms.Button();
            this.listBox_slotMach = new System.Windows.Forms.ListBox();
            this.addNearMiss_btn_slotMach = new System.Windows.Forms.Button();
            this.addWin_btn_slotMach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_sm_header = new System.Windows.Forms.Panel();
            this.slotMachine_comboBox = new System.Windows.Forms.ComboBox();
            this.saveAll_btn = new System.Windows.Forms.Button();
            this.restoreAllDefaults_btn = new System.Windows.Forms.Button();
            this.panel_sm_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reelD_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelC_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelB_spinTime_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelA_spinTime_counter)).BeginInit();
            this.panel_sm_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sm_body
            // 
            this.panel_sm_body.Controls.Add(this.sm_title_label);
            this.panel_sm_body.Controls.Add(this.restoreDefaults_slotMac_btn);
            this.panel_sm_body.Controls.Add(this.reelD_spinTime_counter);
            this.panel_sm_body.Controls.Add(this.reelC_spinTime_counter);
            this.panel_sm_body.Controls.Add(this.reelB_spinTime_counter);
            this.panel_sm_body.Controls.Add(this.reelA_spinTime_counter);
            this.panel_sm_body.Controls.Add(this.reelD_spinTime_label);
            this.panel_sm_body.Controls.Add(this.reelC_spinTime_label);
            this.panel_sm_body.Controls.Add(this.reelB_spinTime_label);
            this.panel_sm_body.Controls.Add(this.reelA_spinTime_label);
            this.panel_sm_body.Controls.Add(this.listSizeNum_label_slotMach);
            this.panel_sm_body.Controls.Add(this.randomizeItems_btn_slotMach);
            this.panel_sm_body.Controls.Add(this.delSelectedItem_btn_slotMach);
            this.panel_sm_body.Controls.Add(this.clear_ListBox);
            this.panel_sm_body.Controls.Add(this.listSizeText_label_slotMach);
            this.panel_sm_body.Controls.Add(this.addLoss_btn_slotMach);
            this.panel_sm_body.Controls.Add(this.listBox_slotMach);
            this.panel_sm_body.Controls.Add(this.addNearMiss_btn_slotMach);
            this.panel_sm_body.Controls.Add(this.addWin_btn_slotMach);
            this.panel_sm_body.Controls.Add(this.button1);
            this.panel_sm_body.Location = new System.Drawing.Point(12, 131);
            this.panel_sm_body.Name = "panel_sm_body";
            this.panel_sm_body.Size = new System.Drawing.Size(1012, 605);
            this.panel_sm_body.TabIndex = 0;
            // 
            // sm_title_label
            // 
            this.sm_title_label.AutoSize = true;
            this.sm_title_label.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sm_title_label.Location = new System.Drawing.Point(71, 20);
            this.sm_title_label.Name = "sm_title_label";
            this.sm_title_label.Size = new System.Drawing.Size(443, 42);
            this.sm_title_label.TabIndex = 36;
            this.sm_title_label.Text = "No Slot Machine Selected!";
            // 
            // restoreDefaults_slotMac_btn
            // 
            this.restoreDefaults_slotMac_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreDefaults_slotMac_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreDefaults_slotMac_btn.Location = new System.Drawing.Point(786, 12);
            this.restoreDefaults_slotMac_btn.Name = "restoreDefaults_slotMac_btn";
            this.restoreDefaults_slotMac_btn.Size = new System.Drawing.Size(197, 50);
            this.restoreDefaults_slotMac_btn.TabIndex = 35;
            this.restoreDefaults_slotMac_btn.Tag = "SlotMachine";
            this.restoreDefaults_slotMac_btn.Text = "Restore defaults";
            this.restoreDefaults_slotMac_btn.UseVisualStyleBackColor = true;
            this.restoreDefaults_slotMac_btn.Click += new System.EventHandler(this.restoreDefaults_slotMac_btn_Click);
            // 
            // reelD_spinTime_counter
            // 
            this.reelD_spinTime_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelD_spinTime_counter.Location = new System.Drawing.Point(711, 268);
            this.reelD_spinTime_counter.Name = "reelD_spinTime_counter";
            this.reelD_spinTime_counter.Size = new System.Drawing.Size(120, 28);
            this.reelD_spinTime_counter.TabIndex = 34;
            this.reelD_spinTime_counter.ValueChanged += new System.EventHandler(this.reelD_spinTime_counter_ValueChanged);
            // 
            // reelC_spinTime_counter
            // 
            this.reelC_spinTime_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelC_spinTime_counter.Location = new System.Drawing.Point(711, 213);
            this.reelC_spinTime_counter.Name = "reelC_spinTime_counter";
            this.reelC_spinTime_counter.Size = new System.Drawing.Size(120, 28);
            this.reelC_spinTime_counter.TabIndex = 33;
            this.reelC_spinTime_counter.ValueChanged += new System.EventHandler(this.reelC_spinTime_counter_ValueChanged);
            // 
            // reelB_spinTime_counter
            // 
            this.reelB_spinTime_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelB_spinTime_counter.Location = new System.Drawing.Point(711, 153);
            this.reelB_spinTime_counter.Name = "reelB_spinTime_counter";
            this.reelB_spinTime_counter.Size = new System.Drawing.Size(120, 28);
            this.reelB_spinTime_counter.TabIndex = 32;
            this.reelB_spinTime_counter.ValueChanged += new System.EventHandler(this.reelB_spinTime_counter_ValueChanged);
            // 
            // reelA_spinTime_counter
            // 
            this.reelA_spinTime_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelA_spinTime_counter.Location = new System.Drawing.Point(711, 99);
            this.reelA_spinTime_counter.Name = "reelA_spinTime_counter";
            this.reelA_spinTime_counter.Size = new System.Drawing.Size(120, 28);
            this.reelA_spinTime_counter.TabIndex = 31;
            this.reelA_spinTime_counter.ValueChanged += new System.EventHandler(this.reelA_spinTime_counter_ValueChanged);
            // 
            // reelD_spinTime_label
            // 
            this.reelD_spinTime_label.AutoSize = true;
            this.reelD_spinTime_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelD_spinTime_label.Location = new System.Drawing.Point(518, 270);
            this.reelD_spinTime_label.Name = "reelD_spinTime_label";
            this.reelD_spinTime_label.Size = new System.Drawing.Size(190, 21);
            this.reelD_spinTime_label.TabIndex = 30;
            this.reelD_spinTime_label.Text = "ReelD Spin time(seconds):";
            // 
            // reelC_spinTime_label
            // 
            this.reelC_spinTime_label.AutoSize = true;
            this.reelC_spinTime_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelC_spinTime_label.Location = new System.Drawing.Point(518, 213);
            this.reelC_spinTime_label.Name = "reelC_spinTime_label";
            this.reelC_spinTime_label.Size = new System.Drawing.Size(189, 21);
            this.reelC_spinTime_label.TabIndex = 29;
            this.reelC_spinTime_label.Text = "ReelC Spin time(seconds):";
            // 
            // reelB_spinTime_label
            // 
            this.reelB_spinTime_label.AutoSize = true;
            this.reelB_spinTime_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelB_spinTime_label.Location = new System.Drawing.Point(517, 153);
            this.reelB_spinTime_label.Name = "reelB_spinTime_label";
            this.reelB_spinTime_label.Size = new System.Drawing.Size(188, 21);
            this.reelB_spinTime_label.TabIndex = 28;
            this.reelB_spinTime_label.Text = "ReelB Spin time(seconds):";
            // 
            // reelA_spinTime_label
            // 
            this.reelA_spinTime_label.AutoSize = true;
            this.reelA_spinTime_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reelA_spinTime_label.Location = new System.Drawing.Point(516, 99);
            this.reelA_spinTime_label.Name = "reelA_spinTime_label";
            this.reelA_spinTime_label.Size = new System.Drawing.Size(189, 21);
            this.reelA_spinTime_label.TabIndex = 27;
            this.reelA_spinTime_label.Text = "ReelA Spin time(seconds):";
            // 
            // listSizeNum_label_slotMach
            // 
            this.listSizeNum_label_slotMach.AutoSize = true;
            this.listSizeNum_label_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSizeNum_label_slotMach.Location = new System.Drawing.Point(332, 421);
            this.listSizeNum_label_slotMach.Name = "listSizeNum_label_slotMach";
            this.listSizeNum_label_slotMach.Size = new System.Drawing.Size(36, 21);
            this.listSizeNum_label_slotMach.TabIndex = 25;
            this.listSizeNum_label_slotMach.Tag = "SlotMachine";
            this.listSizeNum_label_slotMach.Text = "size";
            // 
            // randomizeItems_btn_slotMach
            // 
            this.randomizeItems_btn_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeItems_btn_slotMach.Location = new System.Drawing.Point(48, 326);
            this.randomizeItems_btn_slotMach.Name = "randomizeItems_btn_slotMach";
            this.randomizeItems_btn_slotMach.Size = new System.Drawing.Size(139, 45);
            this.randomizeItems_btn_slotMach.TabIndex = 23;
            this.randomizeItems_btn_slotMach.Tag = "SlotMachine";
            this.randomizeItems_btn_slotMach.Text = "Randomize";
            this.randomizeItems_btn_slotMach.UseVisualStyleBackColor = true;
            this.randomizeItems_btn_slotMach.Click += new System.EventHandler(this.randomizeItems_btn_slotMach_Click);
            // 
            // delSelectedItem_btn_slotMach
            // 
            this.delSelectedItem_btn_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delSelectedItem_btn_slotMach.Location = new System.Drawing.Point(48, 268);
            this.delSelectedItem_btn_slotMach.Name = "delSelectedItem_btn_slotMach";
            this.delSelectedItem_btn_slotMach.Size = new System.Drawing.Size(139, 52);
            this.delSelectedItem_btn_slotMach.TabIndex = 21;
            this.delSelectedItem_btn_slotMach.Tag = "SlotMachine";
            this.delSelectedItem_btn_slotMach.Text = "Delete selected outcome";
            this.delSelectedItem_btn_slotMach.UseVisualStyleBackColor = true;
            this.delSelectedItem_btn_slotMach.Click += new System.EventHandler(this.delSelectedItem_btn_slotMach_Click);
            // 
            // clear_ListBox
            // 
            this.clear_ListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_ListBox.Location = new System.Drawing.Point(48, 377);
            this.clear_ListBox.Name = "clear_ListBox";
            this.clear_ListBox.Size = new System.Drawing.Size(139, 45);
            this.clear_ListBox.TabIndex = 26;
            this.clear_ListBox.Tag = "SlotMachine";
            this.clear_ListBox.Text = "Clear List";
            this.clear_ListBox.UseVisualStyleBackColor = true;
            this.clear_ListBox.Click += new System.EventHandler(this.clear_ListBox_btn_Click);
            // 
            // listSizeText_label_slotMach
            // 
            this.listSizeText_label_slotMach.AutoSize = true;
            this.listSizeText_label_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSizeText_label_slotMach.Location = new System.Drawing.Point(190, 421);
            this.listSizeText_label_slotMach.Name = "listSizeText_label_slotMach";
            this.listSizeText_label_slotMach.Size = new System.Drawing.Size(152, 21);
            this.listSizeText_label_slotMach.TabIndex = 20;
            this.listSizeText_label_slotMach.Tag = "SlotMachine";
            this.listSizeText_label_slotMach.Text = "Size of outcome list: ";
            // 
            // addLoss_btn_slotMach
            // 
            this.addLoss_btn_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLoss_btn_slotMach.Location = new System.Drawing.Point(48, 213);
            this.addLoss_btn_slotMach.Name = "addLoss_btn_slotMach";
            this.addLoss_btn_slotMach.Size = new System.Drawing.Size(140, 49);
            this.addLoss_btn_slotMach.TabIndex = 24;
            this.addLoss_btn_slotMach.Tag = "SlotMachine";
            this.addLoss_btn_slotMach.Text = "Add Loss";
            this.addLoss_btn_slotMach.UseVisualStyleBackColor = true;
            this.addLoss_btn_slotMach.Click += new System.EventHandler(this.addLoss_btn_slotMach_Click);
            // 
            // listBox_slotMach
            // 
            this.listBox_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_slotMach.FormattingEnabled = true;
            this.listBox_slotMach.ItemHeight = 21;
            this.listBox_slotMach.Location = new System.Drawing.Point(194, 99);
            this.listBox_slotMach.Name = "listBox_slotMach";
            this.listBox_slotMach.Size = new System.Drawing.Size(260, 319);
            this.listBox_slotMach.TabIndex = 18;
            this.listBox_slotMach.Tag = "SlotMachine";
            // 
            // addNearMiss_btn_slotMach
            // 
            this.addNearMiss_btn_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNearMiss_btn_slotMach.Location = new System.Drawing.Point(48, 153);
            this.addNearMiss_btn_slotMach.Name = "addNearMiss_btn_slotMach";
            this.addNearMiss_btn_slotMach.Size = new System.Drawing.Size(140, 54);
            this.addNearMiss_btn_slotMach.TabIndex = 22;
            this.addNearMiss_btn_slotMach.Tag = "SlotMachine";
            this.addNearMiss_btn_slotMach.Text = "Add NearMiss";
            this.addNearMiss_btn_slotMach.UseVisualStyleBackColor = true;
            this.addNearMiss_btn_slotMach.Click += new System.EventHandler(this.addNearMiss_btn_slotMach_Click);
            // 
            // addWin_btn_slotMach
            // 
            this.addWin_btn_slotMach.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWin_btn_slotMach.Location = new System.Drawing.Point(48, 98);
            this.addWin_btn_slotMach.Name = "addWin_btn_slotMach";
            this.addWin_btn_slotMach.Size = new System.Drawing.Size(140, 49);
            this.addWin_btn_slotMach.TabIndex = 19;
            this.addWin_btn_slotMach.Tag = "SlotMachine";
            this.addWin_btn_slotMach.Text = "Add Win";
            this.addWin_btn_slotMach.UseVisualStyleBackColor = true;
            this.addWin_btn_slotMach.Click += new System.EventHandler(this.addWin_btn_slotMach_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // panel_sm_header
            // 
            this.panel_sm_header.Controls.Add(this.slotMachine_comboBox);
            this.panel_sm_header.Controls.Add(this.saveAll_btn);
            this.panel_sm_header.Controls.Add(this.restoreAllDefaults_btn);
            this.panel_sm_header.Location = new System.Drawing.Point(12, 16);
            this.panel_sm_header.Name = "panel_sm_header";
            this.panel_sm_header.Size = new System.Drawing.Size(1012, 100);
            this.panel_sm_header.TabIndex = 1;
            // 
            // slotMachine_comboBox
            // 
            this.slotMachine_comboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotMachine_comboBox.FormattingEnabled = true;
            this.slotMachine_comboBox.Location = new System.Drawing.Point(48, 37);
            this.slotMachine_comboBox.Name = "slotMachine_comboBox";
            this.slotMachine_comboBox.Size = new System.Drawing.Size(304, 31);
            this.slotMachine_comboBox.TabIndex = 36;
            this.slotMachine_comboBox.Text = "Select a slot machine here...";
            this.slotMachine_comboBox.SelectedIndexChanged += new System.EventHandler(this.slotMachine_comboBox_SelectedIndexChanged);
            // 
            // saveAll_btn
            // 
            this.saveAll_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAll_btn.ForeColor = System.Drawing.Color.Black;
            this.saveAll_btn.Location = new System.Drawing.Point(564, 24);
            this.saveAll_btn.Name = "saveAll_btn";
            this.saveAll_btn.Size = new System.Drawing.Size(175, 50);
            this.saveAll_btn.TabIndex = 11;
            this.saveAll_btn.Text = "Save All";
            this.saveAll_btn.UseVisualStyleBackColor = true;
            // 
            // restoreAllDefaults_btn
            // 
            this.restoreAllDefaults_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreAllDefaults_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreAllDefaults_btn.Location = new System.Drawing.Point(786, 24);
            this.restoreAllDefaults_btn.Name = "restoreAllDefaults_btn";
            this.restoreAllDefaults_btn.Size = new System.Drawing.Size(197, 50);
            this.restoreAllDefaults_btn.TabIndex = 11;
            this.restoreAllDefaults_btn.Text = "Restore All Defaults";
            this.restoreAllDefaults_btn.UseVisualStyleBackColor = true;
            this.restoreAllDefaults_btn.Click += new System.EventHandler(this.restoreAllDefaults_btn_Click);
            // 
            // SlotMachineForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 843);
            this.Controls.Add(this.panel_sm_header);
            this.Controls.Add(this.panel_sm_body);
            this.Name = "SlotMachineForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load_1);
            this.panel_sm_body.ResumeLayout(false);
            this.panel_sm_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reelD_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelC_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelB_spinTime_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reelA_spinTime_counter)).EndInit();
            this.panel_sm_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sm_body;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_sm_header;
        private System.Windows.Forms.Label reelD_spinTime_label;
        private System.Windows.Forms.Label reelC_spinTime_label;
        private System.Windows.Forms.Label reelB_spinTime_label;
        private System.Windows.Forms.Label reelA_spinTime_label;
        private System.Windows.Forms.Label listSizeNum_label_slotMach;
        private System.Windows.Forms.Button randomizeItems_btn_slotMach;
        private System.Windows.Forms.Button delSelectedItem_btn_slotMach;
        private System.Windows.Forms.Button clear_ListBox;
        private System.Windows.Forms.Label listSizeText_label_slotMach;
        private System.Windows.Forms.Button addLoss_btn_slotMach;
        private System.Windows.Forms.ListBox listBox_slotMach;
        private System.Windows.Forms.Button addNearMiss_btn_slotMach;
        private System.Windows.Forms.Button addWin_btn_slotMach;
        private System.Windows.Forms.NumericUpDown reelD_spinTime_counter;
        private System.Windows.Forms.NumericUpDown reelC_spinTime_counter;
        private System.Windows.Forms.NumericUpDown reelB_spinTime_counter;
        private System.Windows.Forms.NumericUpDown reelA_spinTime_counter;
        private System.Windows.Forms.Button saveAll_btn;
        private System.Windows.Forms.Button restoreAllDefaults_btn;
        private System.Windows.Forms.ComboBox slotMachine_comboBox;
        private System.Windows.Forms.Button restoreDefaults_slotMac_btn;
        private System.Windows.Forms.Label sm_title_label;
    }
}