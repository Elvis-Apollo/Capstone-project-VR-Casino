namespace CasinoAdmin
{
    partial class Payoff_form
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
            this.payoffs_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.restoreDefaults_payoffs_btn = new System.Windows.Forms.Button();
            this.optionA_Max_counter = new System.Windows.Forms.NumericUpDown();
            this.optionA_Min_counter = new System.Windows.Forms.NumericUpDown();
            this.optionB_Max_counter = new System.Windows.Forms.NumericUpDown();
            this.optionB_Min_counter = new System.Windows.Forms.NumericUpDown();
            this.optionA_Max_label = new System.Windows.Forms.Label();
            this.optionA_Min_label = new System.Windows.Forms.Label();
            this.optionB_Max_label = new System.Windows.Forms.Label();
            this.optionB_Min_label = new System.Windows.Forms.Label();
            this.save_payoffs_btn = new System.Windows.Forms.Button();
            this.payoffs_title_label = new System.Windows.Forms.Label();
            this.payoffs_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionA_Max_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionA_Min_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionB_Max_counter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionB_Min_counter)).BeginInit();
            this.SuspendLayout();
            // 
            // payoffs_panel
            // 
            this.payoffs_panel.Controls.Add(this.tableLayoutPanel1);
            this.payoffs_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payoffs_panel.Location = new System.Drawing.Point(0, 0);
            this.payoffs_panel.Name = "payoffs_panel";
            this.payoffs_panel.Size = new System.Drawing.Size(726, 689);
            this.payoffs_panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.restoreDefaults_payoffs_btn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.optionA_Max_counter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.optionA_Min_counter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.optionB_Max_counter, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.optionB_Min_counter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.optionA_Max_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.optionA_Min_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.optionB_Max_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.optionB_Min_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.save_payoffs_btn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.payoffs_title_label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // restoreDefaults_payoffs_btn
            // 
            this.restoreDefaults_payoffs_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restoreDefaults_payoffs_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreDefaults_payoffs_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreDefaults_payoffs_btn.Location = new System.Drawing.Point(83, 604);
            this.restoreDefaults_payoffs_btn.Name = "restoreDefaults_payoffs_btn";
            this.restoreDefaults_payoffs_btn.Size = new System.Drawing.Size(197, 50);
            this.restoreDefaults_payoffs_btn.TabIndex = 41;
            this.restoreDefaults_payoffs_btn.Tag = "";
            this.restoreDefaults_payoffs_btn.Text = "Restore defaults";
            this.restoreDefaults_payoffs_btn.UseVisualStyleBackColor = true;
            this.restoreDefaults_payoffs_btn.Click += new System.EventHandler(this.restoreDefaults_payoffs_btn_Click);
            // 
            // optionA_Max_counter
            // 
            this.optionA_Max_counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionA_Max_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_Max_counter.Location = new System.Drawing.Point(484, 157);
            this.optionA_Max_counter.Name = "optionA_Max_counter";
            this.optionA_Max_counter.Size = new System.Drawing.Size(120, 28);
            this.optionA_Max_counter.TabIndex = 32;
            // 
            // optionA_Min_counter
            // 
            this.optionA_Min_counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionA_Min_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_Min_counter.Location = new System.Drawing.Point(484, 271);
            this.optionA_Min_counter.Name = "optionA_Min_counter";
            this.optionA_Min_counter.Size = new System.Drawing.Size(120, 28);
            this.optionA_Min_counter.TabIndex = 33;
            // 
            // optionB_Max_counter
            // 
            this.optionB_Max_counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionB_Max_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB_Max_counter.Location = new System.Drawing.Point(484, 385);
            this.optionB_Max_counter.Name = "optionB_Max_counter";
            this.optionB_Max_counter.Size = new System.Drawing.Size(120, 28);
            this.optionB_Max_counter.TabIndex = 34;
            // 
            // optionB_Min_counter
            // 
            this.optionB_Min_counter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionB_Min_counter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB_Min_counter.Location = new System.Drawing.Point(484, 499);
            this.optionB_Min_counter.Name = "optionB_Min_counter";
            this.optionB_Min_counter.Size = new System.Drawing.Size(120, 28);
            this.optionB_Min_counter.TabIndex = 35;
            // 
            // optionA_Max_label
            // 
            this.optionA_Max_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionA_Max_label.AutoSize = true;
            this.optionA_Max_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_Max_label.Location = new System.Drawing.Point(114, 160);
            this.optionA_Max_label.Name = "optionA_Max_label";
            this.optionA_Max_label.Size = new System.Drawing.Size(134, 21);
            this.optionA_Max_label.TabIndex = 36;
            this.optionA_Max_label.Text = "Option A Max Val:";
            // 
            // optionA_Min_label
            // 
            this.optionA_Min_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionA_Min_label.AutoSize = true;
            this.optionA_Min_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA_Min_label.Location = new System.Drawing.Point(115, 274);
            this.optionA_Min_label.Name = "optionA_Min_label";
            this.optionA_Min_label.Size = new System.Drawing.Size(132, 21);
            this.optionA_Min_label.TabIndex = 37;
            this.optionA_Min_label.Text = "Option A Min Val:";
            // 
            // optionB_Max_label
            // 
            this.optionB_Max_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionB_Max_label.AutoSize = true;
            this.optionB_Max_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB_Max_label.Location = new System.Drawing.Point(115, 388);
            this.optionB_Max_label.Name = "optionB_Max_label";
            this.optionB_Max_label.Size = new System.Drawing.Size(133, 21);
            this.optionB_Max_label.TabIndex = 38;
            this.optionB_Max_label.Text = "Option B Max Val:";
            // 
            // optionB_Min_label
            // 
            this.optionB_Min_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionB_Min_label.AutoSize = true;
            this.optionB_Min_label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB_Min_label.Location = new System.Drawing.Point(116, 502);
            this.optionB_Min_label.Name = "optionB_Min_label";
            this.optionB_Min_label.Size = new System.Drawing.Size(131, 21);
            this.optionB_Min_label.TabIndex = 39;
            this.optionB_Min_label.Text = "Option B Min Val:";
            // 
            // save_payoffs_btn
            // 
            this.save_payoffs_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_payoffs_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_payoffs_btn.Location = new System.Drawing.Point(457, 605);
            this.save_payoffs_btn.Name = "save_payoffs_btn";
            this.save_payoffs_btn.Size = new System.Drawing.Size(175, 49);
            this.save_payoffs_btn.TabIndex = 40;
            this.save_payoffs_btn.Tag = "";
            this.save_payoffs_btn.Text = "Save";
            this.save_payoffs_btn.UseVisualStyleBackColor = true;
            this.save_payoffs_btn.Click += new System.EventHandler(this.save_payoffs_btn_Click);
            // 
            // payoffs_title_label
            // 
            this.payoffs_title_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payoffs_title_label.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.payoffs_title_label, 2);
            this.payoffs_title_label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payoffs_title_label.Location = new System.Drawing.Point(259, 45);
            this.payoffs_title_label.Name = "payoffs_title_label";
            this.payoffs_title_label.Size = new System.Drawing.Size(208, 23);
            this.payoffs_title_label.TabIndex = 42;
            this.payoffs_title_label.Text = "Set Holt Laury Payoffs";
            // 
            // Payoff_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 689);
            this.Controls.Add(this.payoffs_panel);
            this.Name = "Payoff_form";
            this.Text = "Payoff";
            this.Load += new System.EventHandler(this.Payoff_form_Load);
            this.payoffs_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionA_Max_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionA_Min_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionB_Max_counter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionB_Min_counter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel payoffs_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown optionA_Max_counter;
        private System.Windows.Forms.NumericUpDown optionA_Min_counter;
        private System.Windows.Forms.NumericUpDown optionB_Max_counter;
        private System.Windows.Forms.NumericUpDown optionB_Min_counter;
        private System.Windows.Forms.Label optionA_Max_label;
        private System.Windows.Forms.Label optionA_Min_label;
        private System.Windows.Forms.Label optionB_Max_label;
        private System.Windows.Forms.Label optionB_Min_label;
        private System.Windows.Forms.Button save_payoffs_btn;
        private System.Windows.Forms.Button restoreDefaults_payoffs_btn;
        private System.Windows.Forms.Label payoffs_title_label;
    }
}