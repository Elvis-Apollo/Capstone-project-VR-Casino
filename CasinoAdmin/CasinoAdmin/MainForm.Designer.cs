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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            this.tableLayout_main.SuspendLayout();
            this.panel_admin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.button_Admin_main.Text = "Admin Portal";
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
            this.panel_admin.Controls.Add(this.tableLayoutPanel1);
            this.panel_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_admin.Location = new System.Drawing.Point(0, 0);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(1030, 870);
            this.panel_admin.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.86175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.04608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 868);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Settings";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(402, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "HoltLaury Payoff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(402, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Slot Machine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 870);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_admin);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_main.ResumeLayout(false);
            this.tableLayout_main.ResumeLayout(false);
            this.tableLayout_main.PerformLayout();
            this.panel_admin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayout_main;
        private System.Windows.Forms.Label label_heading_main;
        private System.Windows.Forms.Button button_Admin_main;
        private System.Windows.Forms.Button button_HLTest_main;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

