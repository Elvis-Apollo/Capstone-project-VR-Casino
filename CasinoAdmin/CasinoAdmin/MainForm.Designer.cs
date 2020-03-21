namespace CasinoAdmin
{
    partial class MainForm
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableLayout_main = new System.Windows.Forms.TableLayoutPanel();
            this.label_heading_main = new System.Windows.Forms.Label();
            this.button_Admin_main = new System.Windows.Forms.Button();
            this.button_HLTest_main = new System.Windows.Forms.Button();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.tableLayout_admin = new System.Windows.Forms.TableLayoutPanel();
            this.payoff_btn = new System.Windows.Forms.Button();
            this.slotMach_btn = new System.Windows.Forms.Button();
            this.tableLayout_admin_selFolder = new System.Windows.Forms.TableLayoutPanel();
            this.sel_folder_btn = new System.Windows.Forms.Button();
            this.directory_label = new System.Windows.Forms.Label();
            this.folder_dir_example_label = new System.Windows.Forms.Label();
            this.admin_settings_sub_panel = new System.Windows.Forms.Panel();
            this.back_toMain_btn = new System.Windows.Forms.Button();
            this.admin_header_label = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.tableLayout_main.SuspendLayout();
            this.panel_admin.SuspendLayout();
            this.tableLayout_admin.SuspendLayout();
            this.tableLayout_admin_selFolder.SuspendLayout();
            this.admin_settings_sub_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.tableLayout_main);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1030, 870);
            this.panel_main.TabIndex = 0;
            // 
            // tableLayout_main
            // 
            this.tableLayout_main.AutoScroll = true;
            this.tableLayout_main.ColumnCount = 1;
            this.tableLayout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_main.Controls.Add(this.label_heading_main, 0, 0);
            this.tableLayout_main.Controls.Add(this.button_Admin_main, 0, 2);
            this.tableLayout_main.Controls.Add(this.button_HLTest_main, 0, 1);
            this.tableLayout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_main.Name = "tableLayout_main";
            this.tableLayout_main.RowCount = 3;
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_main.Size = new System.Drawing.Size(1028, 868);
            this.tableLayout_main.TabIndex = 2;
            // 
            // label_heading_main
            // 
            this.label_heading_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_heading_main.AutoSize = true;
            this.label_heading_main.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading_main.Location = new System.Drawing.Point(306, 66);
            this.label_heading_main.Name = "label_heading_main";
            this.label_heading_main.Size = new System.Drawing.Size(415, 41);
            this.label_heading_main.TabIndex = 3;
            this.label_heading_main.Text = "Welcome to Casino Admin";
            // 
            // button_Admin_main
            // 
            this.button_Admin_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Admin_main.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Admin_main.Location = new System.Drawing.Point(402, 667);
            this.button_Admin_main.Name = "button_Admin_main";
            this.button_Admin_main.Size = new System.Drawing.Size(224, 53);
            this.button_Admin_main.TabIndex = 2;
            this.button_Admin_main.Text = "Admin Settings";
            this.button_Admin_main.UseVisualStyleBackColor = true;
            this.button_Admin_main.Click += new System.EventHandler(this.button_Admin_main_Click);
            // 
            // button_HLTest_main
            // 
            this.button_HLTest_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_HLTest_main.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HLTest_main.Location = new System.Drawing.Point(402, 320);
            this.button_HLTest_main.Name = "button_HLTest_main";
            this.button_HLTest_main.Size = new System.Drawing.Size(224, 53);
            this.button_HLTest_main.TabIndex = 1;
            this.button_HLTest_main.Text = "Take Holt Laury Test";
            this.button_HLTest_main.UseVisualStyleBackColor = true;
            this.button_HLTest_main.Click += new System.EventHandler(this.button_HLTest_main_Click);
            // 
            // panel_admin
            // 
            this.panel_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_admin.Controls.Add(this.tableLayout_admin);
            this.panel_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_admin.Location = new System.Drawing.Point(0, 0);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(1030, 870);
            this.panel_admin.TabIndex = 3;
            // 
            // tableLayout_admin
            // 
            this.tableLayout_admin.ColumnCount = 1;
            this.tableLayout_admin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_admin.Controls.Add(this.payoff_btn, 0, 3);
            this.tableLayout_admin.Controls.Add(this.slotMach_btn, 0, 2);
            this.tableLayout_admin.Controls.Add(this.tableLayout_admin_selFolder, 0, 1);
            this.tableLayout_admin.Controls.Add(this.admin_settings_sub_panel, 0, 0);
            this.tableLayout_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_admin.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_admin.Name = "tableLayout_admin";
            this.tableLayout_admin.RowCount = 4;
            this.tableLayout_admin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_admin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_admin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_admin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_admin.Size = new System.Drawing.Size(1028, 868);
            this.tableLayout_admin.TabIndex = 2;
            // 
            // payoff_btn
            // 
            this.payoff_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payoff_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payoff_btn.Location = new System.Drawing.Point(402, 733);
            this.payoff_btn.Name = "payoff_btn";
            this.payoff_btn.Size = new System.Drawing.Size(224, 53);
            this.payoff_btn.TabIndex = 2;
            this.payoff_btn.Text = "HoltLaury Payoff";
            this.payoff_btn.UseVisualStyleBackColor = true;
            this.payoff_btn.Click += new System.EventHandler(this.payoff_btn_Click);
            // 
            // slotMach_btn
            // 
            this.slotMach_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slotMach_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotMach_btn.Location = new System.Drawing.Point(402, 516);
            this.slotMach_btn.Name = "slotMach_btn";
            this.slotMach_btn.Size = new System.Drawing.Size(224, 53);
            this.slotMach_btn.TabIndex = 1;
            this.slotMach_btn.Text = "Slot Machine";
            this.slotMach_btn.UseVisualStyleBackColor = true;
            this.slotMach_btn.Click += new System.EventHandler(this.slotMach_btn_Click);
            // 
            // tableLayout_admin_selFolder
            // 
            this.tableLayout_admin_selFolder.AutoScroll = true;
            this.tableLayout_admin_selFolder.ColumnCount = 1;
            this.tableLayout_admin_selFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_admin_selFolder.Controls.Add(this.sel_folder_btn, 0, 0);
            this.tableLayout_admin_selFolder.Controls.Add(this.directory_label, 0, 2);
            this.tableLayout_admin_selFolder.Controls.Add(this.folder_dir_example_label, 0, 1);
            this.tableLayout_admin_selFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_admin_selFolder.Location = new System.Drawing.Point(3, 220);
            this.tableLayout_admin_selFolder.Name = "tableLayout_admin_selFolder";
            this.tableLayout_admin_selFolder.RowCount = 3;
            this.tableLayout_admin_selFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.18045F));
            this.tableLayout_admin_selFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.81955F));
            this.tableLayout_admin_selFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayout_admin_selFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_admin_selFolder.Size = new System.Drawing.Size(1022, 211);
            this.tableLayout_admin_selFolder.TabIndex = 4;
            // 
            // sel_folder_btn
            // 
            this.sel_folder_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sel_folder_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_folder_btn.Location = new System.Drawing.Point(399, 21);
            this.sel_folder_btn.Name = "sel_folder_btn";
            this.sel_folder_btn.Size = new System.Drawing.Size(224, 53);
            this.sel_folder_btn.TabIndex = 3;
            this.sel_folder_btn.Text = "Select Json Folder";
            this.sel_folder_btn.UseVisualStyleBackColor = true;
            this.sel_folder_btn.Click += new System.EventHandler(this.sel_folder_btn_Click);
            // 
            // directory_label
            // 
            this.directory_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.directory_label.AutoSize = true;
            this.directory_label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directory_label.Location = new System.Drawing.Point(426, 160);
            this.directory_label.Name = "directory_label";
            this.directory_label.Size = new System.Drawing.Size(170, 23);
            this.directory_label.TabIndex = 4;
            this.directory_label.Text = "Selected directory: ";
            this.directory_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folder_dir_example_label
            // 
            this.folder_dir_example_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folder_dir_example_label.AutoSize = true;
            this.folder_dir_example_label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folder_dir_example_label.Location = new System.Drawing.Point(323, 106);
            this.folder_dir_example_label.Name = "folder_dir_example_label";
            this.folder_dir_example_label.Size = new System.Drawing.Size(375, 16);
            this.folder_dir_example_label.TabIndex = 5;
            this.folder_dir_example_label.Text = "Example: C:\\Users\\MyName\\CasinoVR\\Assets\\scripts\\Json_files";
            // 
            // admin_settings_sub_panel
            // 
            this.admin_settings_sub_panel.Controls.Add(this.back_toMain_btn);
            this.admin_settings_sub_panel.Controls.Add(this.admin_header_label);
            this.admin_settings_sub_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_settings_sub_panel.Location = new System.Drawing.Point(3, 3);
            this.admin_settings_sub_panel.Name = "admin_settings_sub_panel";
            this.admin_settings_sub_panel.Size = new System.Drawing.Size(1022, 211);
            this.admin_settings_sub_panel.TabIndex = 5;
            // 
            // back_toMain_btn
            // 
            this.back_toMain_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_toMain_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_toMain_btn.Location = new System.Drawing.Point(8, 8);
            this.back_toMain_btn.Name = "back_toMain_btn";
            this.back_toMain_btn.Size = new System.Drawing.Size(224, 53);
            this.back_toMain_btn.TabIndex = 7;
            this.back_toMain_btn.Text = "Back to Casino Admin";
            this.back_toMain_btn.UseVisualStyleBackColor = true;
            this.back_toMain_btn.Click += new System.EventHandler(this.back_toMain_btn_Click);
            // 
            // admin_header_label
            // 
            this.admin_header_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.admin_header_label.AutoSize = true;
            this.admin_header_label.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_header_label.Location = new System.Drawing.Point(375, 63);
            this.admin_header_label.Name = "admin_header_label";
            this.admin_header_label.Size = new System.Drawing.Size(248, 41);
            this.admin_header_label.TabIndex = 6;
            this.admin_header_label.Text = "Admin Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 870);
            this.Controls.Add(this.panel_admin);
            this.Controls.Add(this.panel_main);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel_main.ResumeLayout(false);
            this.tableLayout_main.ResumeLayout(false);
            this.tableLayout_main.PerformLayout();
            this.panel_admin.ResumeLayout(false);
            this.tableLayout_admin.ResumeLayout(false);
            this.tableLayout_admin_selFolder.ResumeLayout(false);
            this.tableLayout_admin_selFolder.PerformLayout();
            this.admin_settings_sub_panel.ResumeLayout(false);
            this.admin_settings_sub_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayout_main;
        private System.Windows.Forms.Label label_heading_main;
        private System.Windows.Forms.Button button_Admin_main;
        private System.Windows.Forms.Button button_HLTest_main;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.TableLayoutPanel tableLayout_admin;
        private System.Windows.Forms.Button payoff_btn;
        private System.Windows.Forms.Button slotMach_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayout_admin_selFolder;
        private System.Windows.Forms.Button sel_folder_btn;
        private System.Windows.Forms.Label directory_label;
        private System.Windows.Forms.Label folder_dir_example_label;
        private System.Windows.Forms.Panel admin_settings_sub_panel;
        private System.Windows.Forms.Button back_toMain_btn;
        private System.Windows.Forms.Label admin_header_label;
    }
}

