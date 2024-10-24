namespace Major_Project_1
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLoanlbl = new System.Windows.Forms.Label();
            this.totalInterestlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.aprComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.loanListBox = new System.Windows.Forms.ListBox();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(21, 83);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(673, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Academic and Industry Collaboration";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Loan Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "NC STATE UNIVERSITY";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calcBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(812, 24);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(273, 105);
            this.calcBtn.TabIndex = 3;
            this.calcBtn.Text = "&Calculate Loan";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.acceptBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(812, 136);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(273, 105);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "&Accept Loan";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.displayBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.Location = new System.Drawing.Point(812, 246);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(273, 105);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "&Display All Loans";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(812, 357);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(273, 105);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(807, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Interest:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(807, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Loans:";
            // 
            // totalLoanlbl
            // 
            this.totalLoanlbl.AutoSize = true;
            this.totalLoanlbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.totalLoanlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLoanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLoanlbl.Location = new System.Drawing.Point(812, 623);
            this.totalLoanlbl.Name = "totalLoanlbl";
            this.totalLoanlbl.Size = new System.Drawing.Size(2, 31);
            this.totalLoanlbl.TabIndex = 10;
            // 
            // totalInterestlbl
            // 
            this.totalInterestlbl.AutoSize = true;
            this.totalInterestlbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.totalInterestlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalInterestlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestlbl.Location = new System.Drawing.Point(812, 528);
            this.totalInterestlbl.Name = "totalInterestlbl";
            this.totalInterestlbl.Size = new System.Drawing.Size(2, 31);
            this.totalInterestlbl.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loan Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Annual APR (%):";
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(220, 352);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(193, 26);
            this.rebateTextBox.TabIndex = 15;
            this.rebateTextBox.Click += new System.EventHandler(this.rebateTextBox_Click);
            this.rebateTextBox.TextChanged += new System.EventHandler(this.rebateTextBox_TextChanged);
            this.rebateTextBox.Enter += new System.EventHandler(this.rebateTextBox_Enter);
            this.rebateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateTextBox_KeyPress);
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rebateCheckBox.Location = new System.Drawing.Point(29, 345);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(129, 33);
            this.rebateCheckBox.TabIndex = 16;
            this.rebateCheckBox.Text = "Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = true;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.RebateCheckBox_CheckedChanged);
            // 
            // aprComboBox
            // 
            this.aprComboBox.FormattingEnabled = true;
            this.aprComboBox.Location = new System.Drawing.Point(220, 275);
            this.aprComboBox.Name = "aprComboBox";
            this.aprComboBox.Size = new System.Drawing.Size(193, 28);
            this.aprComboBox.TabIndex = 17;
            this.aprComboBox.TextChanged += new System.EventHandler(this.aprComboBox_TextChanged);
            this.aprComboBox.Click += new System.EventHandler(this.aprComboBox_Click);
            this.aprComboBox.Enter += new System.EventHandler(this.aprComboBox_Enter);
            this.aprComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprComboBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(446, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(121, 75);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 24);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.Text = "24 Months";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(121, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 24);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.Text = "18 Months";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 24);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.Text = "12 Months";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "6 Months";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Interest";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Principal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Payment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(587, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Balance";
            // 
            // loanListBox
            // 
            this.loanListBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanListBox.FormattingEnabled = true;
            this.loanListBox.ItemHeight = 22;
            this.loanListBox.Location = new System.Drawing.Point(29, 455);
            this.loanListBox.Name = "loanListBox";
            this.loanListBox.Size = new System.Drawing.Size(658, 180);
            this.loanListBox.TabIndex = 24;
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(189, 198);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(224, 26);
            this.loanTextBox.TabIndex = 25;
            this.loanTextBox.Click += new System.EventHandler(this.loanTextBox_Click);
            this.loanTextBox.TextChanged += new System.EventHandler(this.loanTextBox_TextChanged);
            this.loanTextBox.Enter += new System.EventHandler(this.loanTextBox_Enter);
            this.loanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1102, 678);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.loanListBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aprComboBox);
            this.Controls.Add(this.rebateCheckBox);
            this.Controls.Add(this.rebateTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalInterestlbl);
            this.Controls.Add(this.totalLoanlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLoanlbl;
        private System.Windows.Forms.Label totalInterestlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.ComboBox aprComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox loanListBox;
        private System.Windows.Forms.TextBox loanTextBox;
    }
}

