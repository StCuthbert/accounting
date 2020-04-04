namespace Bank_Accounting
{
    partial class EnrollmentOp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SumOfTrans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccNumber = new System.Windows.Forms.TextBox();
            this.AccID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Comission = new System.Windows.Forms.Label();
            this.Totalsum = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboRate = new System.Windows.Forms.ComboBox();
            this.ComboPay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.currency_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма зачисления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процент комиссии:";
            // 
            // SumOfTrans
            // 
            this.SumOfTrans.Location = new System.Drawing.Point(124, 79);
            this.SumOfTrans.Name = "SumOfTrans";
            this.SumOfTrans.Size = new System.Drawing.Size(177, 20);
            this.SumOfTrans.TabIndex = 2;
            this.SumOfTrans.Text = "0,00";
            this.SumOfTrans.TextChanged += new System.EventHandler(this.SumOfTrans_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Клиент:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 13);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(87, 24);
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Size = new System.Drawing.Size(412, 20);
            this.ClientName.TabIndex = 6;
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(532, 24);
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Size = new System.Drawing.Size(64, 20);
            this.ClientID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Счет:";
            // 
            // AccNumber
            // 
            this.AccNumber.Location = new System.Drawing.Point(87, 51);
            this.AccNumber.Name = "AccNumber";
            this.AccNumber.ReadOnly = true;
            this.AccNumber.Size = new System.Drawing.Size(412, 20);
            this.AccNumber.TabIndex = 9;
            // 
            // AccID
            // 
            this.AccID.Location = new System.Drawing.Point(532, 51);
            this.AccID.Name = "AccID";
            this.AccID.ReadOnly = true;
            this.AccID.Size = new System.Drawing.Size(64, 20);
            this.AccID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(64, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 13);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Размер комиссии:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Итоговая сумма:";
            // 
            // Comission
            // 
            this.Comission.AutoSize = true;
            this.Comission.Location = new System.Drawing.Point(120, 107);
            this.Comission.Name = "Comission";
            this.Comission.Size = new System.Drawing.Size(0, 13);
            this.Comission.TabIndex = 16;
            this.Comission.Click += new System.EventHandler(this.label9_Click);
            // 
            // Totalsum
            // 
            this.Totalsum.AutoSize = true;
            this.Totalsum.Location = new System.Drawing.Point(120, 129);
            this.Totalsum.Name = "Totalsum";
            this.Totalsum.Size = new System.Drawing.Size(0, 13);
            this.Totalsum.TabIndex = 17;
            this.Totalsum.Click += new System.EventHandler(this.label10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Зачислить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboRate
            // 
            this.comboRate.FormattingEnabled = true;
            this.comboRate.Location = new System.Drawing.Point(532, 82);
            this.comboRate.Name = "comboRate";
            this.comboRate.Size = new System.Drawing.Size(64, 21);
            this.comboRate.TabIndex = 20;
            this.comboRate.SelectedIndexChanged += new System.EventHandler(this.comboRate_SelectedIndexChanged);
            // 
            // ComboPay
            // 
            this.ComboPay.FormattingEnabled = true;
            this.ComboPay.Location = new System.Drawing.Point(159, 154);
            this.ComboPay.Name = "ComboPay";
            this.ComboPay.Size = new System.Drawing.Size(428, 21);
            this.ComboPay.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Назначение платежа";
            // 
            // currency_label
            // 
            this.currency_label.AutoSize = true;
            this.currency_label.Location = new System.Drawing.Point(307, 82);
            this.currency_label.Name = "currency_label";
            this.currency_label.Size = new System.Drawing.Size(0, 13);
            this.currency_label.TabIndex = 23;
            // 
            // EnrollmentOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 228);
            this.Controls.Add(this.currency_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboPay);
            this.Controls.Add(this.comboRate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Totalsum);
            this.Controls.Add(this.Comission);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccID);
            this.Controls.Add(this.AccNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SumOfTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentOp";
            this.Text = "Зачисление средств на счет";
            this.Load += new System.EventHandler(this.EnrollmentOp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumOfTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccNumber;
        private System.Windows.Forms.TextBox AccID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Comission;
        private System.Windows.Forms.Label Totalsum;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboRate;
        private System.Windows.Forms.ComboBox ComboPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label currency_label;
    }
}