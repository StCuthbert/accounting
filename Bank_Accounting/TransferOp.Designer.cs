namespace Bank_Accounting
{
    partial class TransferOp
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
            this.currency_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboPay = new System.Windows.Forms.ComboBox();
            this.comboRate = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Totalsum = new System.Windows.Forms.Label();
            this.Comission = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccID = new System.Windows.Forms.TextBox();
            this.AccNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SumOfTrans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RecieverAccID = new System.Windows.Forms.TextBox();
            this.RecieverAcc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RecieverID = new System.Windows.Forms.TextBox();
            this.RecieverName = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currency_label
            // 
            this.currency_label.AutoSize = true;
            this.currency_label.Location = new System.Drawing.Point(445, 148);
            this.currency_label.Name = "currency_label";
            this.currency_label.Size = new System.Drawing.Size(0, 13);
            this.currency_label.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Назначение платежа";
            // 
            // ComboPay
            // 
            this.ComboPay.FormattingEnabled = true;
            this.ComboPay.Location = new System.Drawing.Point(158, 220);
            this.ComboPay.Name = "ComboPay";
            this.ComboPay.Size = new System.Drawing.Size(500, 21);
            this.ComboPay.TabIndex = 44;
            // 
            // comboRate
            // 
            this.comboRate.FormattingEnabled = true;
            this.comboRate.Location = new System.Drawing.Point(594, 145);
            this.comboRate.Name = "comboRate";
            this.comboRate.Size = new System.Drawing.Size(64, 21);
            this.comboRate.TabIndex = 43;
            this.comboRate.SelectedIndexChanged += new System.EventHandler(this.comboRate_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Зачислить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Totalsum
            // 
            this.Totalsum.AutoSize = true;
            this.Totalsum.Location = new System.Drawing.Point(119, 195);
            this.Totalsum.Name = "Totalsum";
            this.Totalsum.Size = new System.Drawing.Size(0, 13);
            this.Totalsum.TabIndex = 40;
            // 
            // Comission
            // 
            this.Comission.AutoSize = true;
            this.Comission.Location = new System.Drawing.Point(119, 173);
            this.Comission.Name = "Comission";
            this.Comission.Size = new System.Drawing.Size(0, 13);
            this.Comission.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Итоговая сумма:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Размер комиссии:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(123, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 13);
            this.button2.TabIndex = 36;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID:";
            // 
            // AccID
            // 
            this.AccID.Location = new System.Drawing.Point(594, 52);
            this.AccID.Name = "AccID";
            this.AccID.ReadOnly = true;
            this.AccID.Size = new System.Drawing.Size(64, 20);
            this.AccID.TabIndex = 33;
            // 
            // AccNumber
            // 
            this.AccNumber.Location = new System.Drawing.Point(149, 49);
            this.AccNumber.Name = "AccNumber";
            this.AccNumber.ReadOnly = true;
            this.AccNumber.Size = new System.Drawing.Size(412, 20);
            this.AccNumber.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Счет:";
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(594, 22);
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Size = new System.Drawing.Size(64, 20);
            this.ClientID.TabIndex = 30;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(149, 22);
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Size = new System.Drawing.Size(412, 20);
            this.ClientName.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 13);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Клиент-отправитель:";
            // 
            // SumOfTrans
            // 
            this.SumOfTrans.Location = new System.Drawing.Point(123, 145);
            this.SumOfTrans.Name = "SumOfTrans";
            this.SumOfTrans.Size = new System.Drawing.Size(316, 20);
            this.SumOfTrans.TabIndex = 26;
            this.SumOfTrans.Text = "0,00";
            this.SumOfTrans.TextChanged += new System.EventHandler(this.SumOfTrans_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Процент комиссии:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Сумма зачисления:";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(123, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(17, 13);
            this.button5.TabIndex = 56;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "ID:";
            // 
            // RecieverAccID
            // 
            this.RecieverAccID.Location = new System.Drawing.Point(594, 102);
            this.RecieverAccID.Name = "RecieverAccID";
            this.RecieverAccID.ReadOnly = true;
            this.RecieverAccID.Size = new System.Drawing.Size(64, 20);
            this.RecieverAccID.TabIndex = 53;
            // 
            // RecieverAcc
            // 
            this.RecieverAcc.Location = new System.Drawing.Point(149, 102);
            this.RecieverAcc.Name = "RecieverAcc";
            this.RecieverAcc.ReadOnly = true;
            this.RecieverAcc.Size = new System.Drawing.Size(412, 20);
            this.RecieverAcc.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Счет:";
            // 
            // RecieverID
            // 
            this.RecieverID.Location = new System.Drawing.Point(594, 75);
            this.RecieverID.Name = "RecieverID";
            this.RecieverID.ReadOnly = true;
            this.RecieverID.Size = new System.Drawing.Size(64, 20);
            this.RecieverID.TabIndex = 50;
            // 
            // RecieverName
            // 
            this.RecieverName.Location = new System.Drawing.Point(149, 75);
            this.RecieverName.Name = "RecieverName";
            this.RecieverName.ReadOnly = true;
            this.RecieverName.Size = new System.Drawing.Size(412, 20);
            this.RecieverName.TabIndex = 49;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(123, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(17, 13);
            this.button6.TabIndex = 48;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Клиент-получатель:";
            // 
            // TransferOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 298);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RecieverAccID);
            this.Controls.Add(this.RecieverAcc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RecieverID);
            this.Controls.Add(this.RecieverName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
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
            this.Name = "TransferOp";
            this.Text = "Денежный перевод";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currency_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboPay;
        private System.Windows.Forms.ComboBox comboRate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Totalsum;
        private System.Windows.Forms.Label Comission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AccID;
        private System.Windows.Forms.TextBox AccNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumOfTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RecieverAccID;
        private System.Windows.Forms.TextBox RecieverAcc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RecieverID;
        private System.Windows.Forms.TextBox RecieverName;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
    }
}