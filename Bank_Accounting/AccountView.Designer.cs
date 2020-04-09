namespace Bank_Accounting
{
    partial class AccountView
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
            this.button1 = new System.Windows.Forms.Button();
            this.Currency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Central_corr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BIK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bank_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Acc_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.Currency_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Currency
            // 
            this.Currency.Enabled = false;
            this.Currency.Location = new System.Drawing.Point(370, 153);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(245, 20);
            this.Currency.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Валюта:";
            // 
            // Kind
            // 
            this.Kind.Enabled = false;
            this.Kind.Location = new System.Drawing.Point(47, 153);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(245, 20);
            this.Kind.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Вид:";
            // 
            // Central_corr
            // 
            this.Central_corr.Enabled = false;
            this.Central_corr.Location = new System.Drawing.Point(155, 127);
            this.Central_corr.Name = "Central_corr";
            this.Central_corr.Size = new System.Drawing.Size(460, 20);
            this.Central_corr.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Корреспондентский счет:";
            // 
            // BIK
            // 
            this.BIK.Enabled = false;
            this.BIK.Location = new System.Drawing.Point(107, 101);
            this.BIK.Name = "BIK";
            this.BIK.Size = new System.Drawing.Size(508, 20);
            this.BIK.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "БИК:";
            // 
            // Bank_name
            // 
            this.Bank_name.Enabled = false;
            this.Bank_name.Location = new System.Drawing.Point(107, 76);
            this.Bank_name.Name = "Bank_name";
            this.Bank_name.Size = new System.Drawing.Size(508, 20);
            this.Bank_name.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Название банка:";
            // 
            // Acc_number
            // 
            this.Acc_number.Enabled = false;
            this.Acc_number.Location = new System.Drawing.Point(107, 50);
            this.Acc_number.Name = "Acc_number";
            this.Acc_number.Size = new System.Drawing.Size(508, 20);
            this.Acc_number.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Номер счета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // AccID
            // 
            this.AccID.Enabled = false;
            this.AccID.Location = new System.Drawing.Point(533, 15);
            this.AccID.Name = "AccID";
            this.AccID.Size = new System.Drawing.Size(82, 20);
            this.AccID.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "История";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Баланс:";
            // 
            // Balance
            // 
            this.Balance.Enabled = false;
            this.Balance.Location = new System.Drawing.Point(65, 187);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(245, 20);
            this.Balance.TabIndex = 33;
            // 
            // Currency_label
            // 
            this.Currency_label.AutoSize = true;
            this.Currency_label.Location = new System.Drawing.Point(319, 190);
            this.Currency_label.Name = "Currency_label";
            this.Currency_label.Size = new System.Drawing.Size(0, 13);
            this.Currency_label.TabIndex = 34;
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 249);
            this.Controls.Add(this.Currency_label);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AccID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Currency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Kind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Central_corr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BIK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bank_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Acc_number);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountView";
            this.Text = "Информация о счёте";
            this.Load += new System.EventHandler(this.AccountView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Currency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Kind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Central_corr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BIK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Bank_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Acc_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label Currency_label;
    }
}