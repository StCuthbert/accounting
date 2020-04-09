namespace Bank_Accounting
{
    partial class TransferElement
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
            this.PaymentPurpose = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DateOfTrans = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Totalsum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Comission = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SumOfTrans = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccName = new System.Windows.Forms.TextBox();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RecieverAccID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RecieverAcc = new System.Windows.Forms.TextBox();
            this.RecieverID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RecieverName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentPurpose
            // 
            this.PaymentPurpose.Enabled = false;
            this.PaymentPurpose.Location = new System.Drawing.Point(138, 360);
            this.PaymentPurpose.Name = "PaymentPurpose";
            this.PaymentPurpose.Size = new System.Drawing.Size(555, 20);
            this.PaymentPurpose.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Назначение платежа:";
            // 
            // DateOfTrans
            // 
            this.DateOfTrans.Enabled = false;
            this.DateOfTrans.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfTrans.Location = new System.Drawing.Point(493, 212);
            this.DateOfTrans.Name = "DateOfTrans";
            this.DateOfTrans.Size = new System.Drawing.Size(200, 20);
            this.DateOfTrans.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Дата операции:";
            // 
            // Totalsum
            // 
            this.Totalsum.Enabled = false;
            this.Totalsum.Location = new System.Drawing.Point(138, 314);
            this.Totalsum.Name = "Totalsum";
            this.Totalsum.Size = new System.Drawing.Size(182, 20);
            this.Totalsum.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Итоговая сумма:";
            // 
            // Comission
            // 
            this.Comission.Enabled = false;
            this.Comission.Location = new System.Drawing.Point(138, 279);
            this.Comission.Name = "Comission";
            this.Comission.Size = new System.Drawing.Size(182, 20);
            this.Comission.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Сумма комиссии:";
            // 
            // Rate
            // 
            this.Rate.Enabled = false;
            this.Rate.Location = new System.Drawing.Point(138, 244);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(182, 20);
            this.Rate.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Процентная ставка:";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(565, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "ID:";
            // 
            // SumOfTrans
            // 
            this.SumOfTrans.Enabled = false;
            this.SumOfTrans.Location = new System.Drawing.Point(138, 212);
            this.SumOfTrans.Name = "SumOfTrans";
            this.SumOfTrans.Size = new System.Drawing.Size(182, 20);
            this.SumOfTrans.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Внесённая сумма:";
            // 
            // AccID
            // 
            this.AccID.Enabled = false;
            this.AccID.Location = new System.Drawing.Point(593, 105);
            this.AccID.Name = "AccID";
            this.AccID.Size = new System.Drawing.Size(100, 20);
            this.AccID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Счёт:";
            // 
            // AccName
            // 
            this.AccName.Enabled = false;
            this.AccName.Location = new System.Drawing.Point(131, 105);
            this.AccName.Name = "AccName";
            this.AccName.Size = new System.Drawing.Size(425, 20);
            this.AccName.TabIndex = 31;
            // 
            // ClientID
            // 
            this.ClientID.Enabled = false;
            this.ClientID.Location = new System.Drawing.Point(593, 71);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(100, 20);
            this.ClientID.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Клиент-отправитель:";
            // 
            // ClientName
            // 
            this.ClientName.Enabled = false;
            this.ClientName.Location = new System.Drawing.Point(131, 71);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(425, 20);
            this.ClientName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Тип операции:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(102, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "перевод";
            // 
            // RecieverAccID
            // 
            this.RecieverAccID.Enabled = false;
            this.RecieverAccID.Location = new System.Drawing.Point(593, 161);
            this.RecieverAccID.Name = "RecieverAccID";
            this.RecieverAccID.Size = new System.Drawing.Size(100, 20);
            this.RecieverAccID.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Счёт:";
            // 
            // RecieverAcc
            // 
            this.RecieverAcc.Enabled = false;
            this.RecieverAcc.Location = new System.Drawing.Point(131, 161);
            this.RecieverAcc.Name = "RecieverAcc";
            this.RecieverAcc.Size = new System.Drawing.Size(425, 20);
            this.RecieverAcc.TabIndex = 54;
            // 
            // RecieverID
            // 
            this.RecieverID.Enabled = false;
            this.RecieverID.Location = new System.Drawing.Point(593, 131);
            this.RecieverID.Name = "RecieverID";
            this.RecieverID.Size = new System.Drawing.Size(100, 20);
            this.RecieverID.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(562, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Клиент-получатель:";
            // 
            // RecieverName
            // 
            this.RecieverName.Enabled = false;
            this.RecieverName.Location = new System.Drawing.Point(131, 131);
            this.RecieverName.Name = "RecieverName";
            this.RecieverName.Size = new System.Drawing.Size(425, 20);
            this.RecieverName.TabIndex = 50;
            // 
            // TransferElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.RecieverAccID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RecieverAcc);
            this.Controls.Add(this.RecieverID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.RecieverName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PaymentPurpose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DateOfTrans);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Totalsum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Comission);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SumOfTrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccName);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferElement";
            this.Text = "Карточка операции";
            this.Load += new System.EventHandler(this.TransferElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PaymentPurpose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DateOfTrans;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Totalsum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Comission;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SumOfTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AccName;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox RecieverAccID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RecieverAcc;
        private System.Windows.Forms.TextBox RecieverID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RecieverName;
    }
}