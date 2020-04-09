namespace Bank_Accounting
{
    partial class AccountElement
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
            this.label2 = new System.Windows.Forms.Label();
            this.Acc_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bank_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BIK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Central_corr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Kind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер счета:";
            // 
            // Acc_number
            // 
            this.Acc_number.Location = new System.Drawing.Point(98, 50);
            this.Acc_number.Name = "Acc_number";
            this.Acc_number.Size = new System.Drawing.Size(508, 20);
            this.Acc_number.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название банка:";
            // 
            // Bank_name
            // 
            this.Bank_name.Location = new System.Drawing.Point(98, 76);
            this.Bank_name.Name = "Bank_name";
            this.Bank_name.Size = new System.Drawing.Size(508, 20);
            this.Bank_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "БИК:";
            // 
            // BIK
            // 
            this.BIK.Location = new System.Drawing.Point(98, 101);
            this.BIK.Name = "BIK";
            this.BIK.Size = new System.Drawing.Size(508, 20);
            this.BIK.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Корреспондентский счет:";
            // 
            // Central_corr
            // 
            this.Central_corr.Location = new System.Drawing.Point(146, 127);
            this.Central_corr.Name = "Central_corr";
            this.Central_corr.Size = new System.Drawing.Size(460, 20);
            this.Central_corr.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вид:";
            // 
            // Kind
            // 
            this.Kind.Location = new System.Drawing.Point(38, 153);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(245, 20);
            this.Kind.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Валюта:";
            // 
            // Currency
            // 
            this.Currency.Location = new System.Drawing.Point(361, 153);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(245, 20);
            this.Currency.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 248);
            this.Controls.Add(this.button2);
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
            this.Name = "AccountElement";
            this.Text = "Добавление счета";
            this.Load += new System.EventHandler(this.AccountElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Acc_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bank_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BIK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Central_corr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Kind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Currency;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}