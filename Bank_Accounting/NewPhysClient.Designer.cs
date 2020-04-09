namespace Bank_Accounting
{
    partial class NewPhysClient
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
            this.PhysNation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RegAddr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.PhysSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdditionalInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.KPP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Issuing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SerialNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdentityDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Patron = new System.Windows.Forms.Label();
            this.Physname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PhysNation
            // 
            this.PhysNation.Location = new System.Drawing.Point(134, 351);
            this.PhysNation.Name = "PhysNation";
            this.PhysNation.Size = new System.Drawing.Size(190, 20);
            this.PhysNation.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 70;
            this.label14.Text = "Гражданство (ОКСМ):";
            // 
            // RegAddr
            // 
            this.RegAddr.Location = new System.Drawing.Point(126, 310);
            this.RegAddr.Name = "RegAddr";
            this.RegAddr.Size = new System.Drawing.Size(661, 20);
            this.RegAddr.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Адрес регистрации:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(669, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "ID:";
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(696, 14);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(90, 20);
            this.ClientID.TabIndex = 64;
            // 
            // PhysSaveButton
            // 
            this.PhysSaveButton.Location = new System.Drawing.Point(631, 462);
            this.PhysSaveButton.Name = "PhysSaveButton";
            this.PhysSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PhysSaveButton.TabIndex = 63;
            this.PhysSaveButton.Text = "Сохранить";
            this.PhysSaveButton.UseVisualStyleBackColor = true;
            this.PhysSaveButton.Click += new System.EventHandler(this.PhysSaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdditionalInfo
            // 
            this.AdditionalInfo.Location = new System.Drawing.Point(14, 396);
            this.AdditionalInfo.Multiline = true;
            this.AdditionalInfo.Name = "AdditionalInfo";
            this.AdditionalInfo.Size = new System.Drawing.Size(773, 46);
            this.AdditionalInfo.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Дополнительная информация:";
            // 
            // KPP
            // 
            this.KPP.Location = new System.Drawing.Point(467, 263);
            this.KPP.Name = "KPP";
            this.KPP.Size = new System.Drawing.Size(320, 20);
            this.KPP.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "КПП:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "ИНН:";
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(73, 263);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(331, 20);
            this.INN.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(467, 212);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(320, 20);
            this.Email.TabIndex = 53;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(73, 213);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(331, 20);
            this.PhoneNumber.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Орган выдавший:";
            // 
            // Issuing
            // 
            this.Issuing.Location = new System.Drawing.Point(113, 172);
            this.Issuing.Name = "Issuing";
            this.Issuing.Size = new System.Drawing.Size(674, 20);
            this.Issuing.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Дата выдачи:";
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(105, 124);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(158, 20);
            this.IssueDate.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Серия и номер:";
            // 
            // SerialNum
            // 
            this.SerialNum.Location = new System.Drawing.Point(402, 124);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(385, 20);
            this.SerialNum.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Документ:";
            // 
            // IdentityDoc
            // 
            this.IdentityDoc.Location = new System.Drawing.Point(402, 84);
            this.IdentityDoc.Name = "IdentityDoc";
            this.IdentityDoc.Size = new System.Drawing.Size(385, 20);
            this.IdentityDoc.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Дата рождения:";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(105, 84);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(158, 20);
            this.BirthDate.TabIndex = 41;
            // 
            // Patron
            // 
            this.Patron.AutoSize = true;
            this.Patron.Location = new System.Drawing.Point(12, 42);
            this.Patron.Name = "Patron";
            this.Patron.Size = new System.Drawing.Size(134, 13);
            this.Patron.TabIndex = 40;
            this.Patron.Text = "Фамилия Имя Отчество:";
            // 
            // Physname
            // 
            this.Physname.Location = new System.Drawing.Point(152, 42);
            this.Physname.Name = "Physname";
            this.Physname.Size = new System.Drawing.Size(635, 20);
            this.Physname.TabIndex = 39;
            // 
            // NewPhysClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.PhysNation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RegAddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.PhysSaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdditionalInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.KPP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Issuing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SerialNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdentityDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Patron);
            this.Controls.Add(this.Physname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPhysClient";
            this.Text = "Добавление нового клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhysNation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox RegAddr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Button PhysSaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdditionalInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox KPP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Issuing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SerialNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdentityDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label Patron;
        private System.Windows.Forms.TextBox Physname;
    }
}