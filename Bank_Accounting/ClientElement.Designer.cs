﻿namespace Bank_Accounting
{
    partial class ClientElementPhys
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
            this.components = new System.ComponentModel.Container();
            this.Physname = new System.Windows.Forms.TextBox();
            this.Patron = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentityDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Issuing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KPP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AdditionalInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PhysSaveButton = new System.Windows.Forms.Button();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RegAddr = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankbaseDataSetCLAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankbaseDataSetCLAcc = new Bank_Accounting.bankbaseDataSetCLAcc();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankbaseDataSet1 = new Bank_Accounting.bankbaseDataSet1();
            this.bankbaseDataSet = new Bank_Accounting.bankbaseDataSet();
            this.bankbaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Bank_Accounting.bankbaseDataSet1TableAdapters.clientsTableAdapter();
            this.bankbaseDataSet2 = new Bank_Accounting.bankbaseDataSet2();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new Bank_Accounting.bankbaseDataSet2TableAdapters.clientsTableAdapter();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Bank_Accounting.bankbaseDataSetCLAccTableAdapters.accountsTableAdapter();
            this.accountsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.PhysNation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetCLAccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetCLAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Physname
            // 
            this.Physname.Location = new System.Drawing.Point(153, 40);
            this.Physname.Name = "Physname";
            this.Physname.Size = new System.Drawing.Size(635, 20);
            this.Physname.TabIndex = 1;
            // 
            // Patron
            // 
            this.Patron.AutoSize = true;
            this.Patron.Location = new System.Drawing.Point(13, 40);
            this.Patron.Name = "Patron";
            this.Patron.Size = new System.Drawing.Size(134, 13);
            this.Patron.TabIndex = 3;
            this.Patron.Text = "Фамилия Имя Отчество:";
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(106, 82);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(158, 20);
            this.BirthDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата рождения:";
            // 
            // IdentityDoc
            // 
            this.IdentityDoc.Location = new System.Drawing.Point(403, 82);
            this.IdentityDoc.Name = "IdentityDoc";
            this.IdentityDoc.Size = new System.Drawing.Size(385, 20);
            this.IdentityDoc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Документ:";
            // 
            // SerialNum
            // 
            this.SerialNum.Location = new System.Drawing.Point(403, 122);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(385, 20);
            this.SerialNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Серия и номер:";
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(106, 122);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(158, 20);
            this.IssueDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата выдачи:";
            // 
            // Issuing
            // 
            this.Issuing.Location = new System.Drawing.Point(114, 170);
            this.Issuing.Name = "Issuing";
            this.Issuing.Size = new System.Drawing.Size(674, 20);
            this.Issuing.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Орган выдавший:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Телефон:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(74, 211);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(331, 20);
            this.PhoneNumber.TabIndex = 15;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(468, 210);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(320, 20);
            this.Email.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email:";
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(74, 261);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(331, 20);
            this.INN.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ИНН:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "КПП:";
            // 
            // KPP
            // 
            this.KPP.Location = new System.Drawing.Point(468, 261);
            this.KPP.Name = "KPP";
            this.KPP.Size = new System.Drawing.Size(320, 20);
            this.KPP.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Дополнительная информация:";
            // 
            // AdditionalInfo
            // 
            this.AdditionalInfo.Location = new System.Drawing.Point(14, 410);
            this.AdditionalInfo.Multiline = true;
            this.AdditionalInfo.Name = "AdditionalInfo";
            this.AdditionalInfo.Size = new System.Drawing.Size(773, 55);
            this.AdditionalInfo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Счета:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhysSaveButton
            // 
            this.PhysSaveButton.Location = new System.Drawing.Point(632, 593);
            this.PhysSaveButton.Name = "PhysSaveButton";
            this.PhysSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PhysSaveButton.TabIndex = 27;
            this.PhysSaveButton.Text = "Сохранить";
            this.PhysSaveButton.UseVisualStyleBackColor = true;
            this.PhysSaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientID
            // 
            this.ClientID.Location = new System.Drawing.Point(697, 12);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(90, 20);
            this.ClientID.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(670, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Адрес регистрации:";
            // 
            // RegAddr
            // 
            this.RegAddr.Location = new System.Drawing.Point(127, 308);
            this.RegAddr.Name = "RegAddr";
            this.RegAddr.Size = new System.Drawing.Size(661, 20);
            this.RegAddr.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.clientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(772, 103);
            this.dataGridView1.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "acc_number";
            this.dataGridViewTextBoxColumn2.HeaderText = "acc_number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bank_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "bank_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BIK";
            this.dataGridViewTextBoxColumn4.HeaderText = "BIK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "centralbank_corr";
            this.dataGridViewTextBoxColumn5.HeaderText = "centralbank_corr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kind";
            this.dataGridViewTextBoxColumn6.HeaderText = "kind";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "currency";
            this.dataGridViewTextBoxColumn7.HeaderText = "currency";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "balance";
            this.dataGridViewTextBoxColumn8.HeaderText = "balance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountsBindingSource2
            // 
            this.accountsBindingSource2.DataMember = "accounts";
            this.accountsBindingSource2.DataSource = this.bankbaseDataSetCLAccBindingSource;
            // 
            // bankbaseDataSetCLAccBindingSource
            // 
            this.bankbaseDataSetCLAccBindingSource.DataSource = this.bankbaseDataSetCLAcc;
            this.bankbaseDataSetCLAccBindingSource.Position = 0;
            // 
            // bankbaseDataSetCLAcc
            // 
            this.bankbaseDataSetCLAcc.DataSetName = "bankbaseDataSetCLAcc";
            this.bankbaseDataSetCLAcc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.bankbaseDataSet1;
            // 
            // bankbaseDataSet1
            // 
            this.bankbaseDataSet1.DataSetName = "bankbaseDataSet1";
            this.bankbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankbaseDataSet
            // 
            this.bankbaseDataSet.DataSetName = "bankbaseDataSet";
            this.bankbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankbaseDataSetBindingSource
            // 
            this.bankbaseDataSetBindingSource.DataSource = this.bankbaseDataSet;
            this.bankbaseDataSetBindingSource.Position = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // bankbaseDataSet2
            // 
            this.bankbaseDataSet2.DataSetName = "bankbaseDataSet2";
            this.bankbaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "clients";
            this.clientsBindingSource1.DataSource = this.bankbaseDataSet2;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataMember = "accounts";
            this.accountsBindingSource1.DataSource = this.bankbaseDataSetCLAcc;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // accountsBindingSource3
            // 
            this.accountsBindingSource3.DataMember = "accounts";
            this.accountsBindingSource3.DataSource = this.bankbaseDataSetCLAccBindingSource;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "accounts";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Гражданство (ОКСМ):";
            // 
            // PhysNation
            // 
            this.PhysNation.Location = new System.Drawing.Point(135, 349);
            this.PhysNation.Name = "PhysNation";
            this.PhysNation.Size = new System.Drawing.Size(190, 20);
            this.PhysNation.TabIndex = 35;
            // 
            // ClientElementPhys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 628);
            this.Controls.Add(this.PhysNation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RegAddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ClientID);
            this.Controls.Add(this.PhysSaveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
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
            this.Name = "ClientElementPhys";
            this.Text = "Карточка клиента";
            this.Load += new System.EventHandler(this.ClientElementPhys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetCLAccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetCLAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Physname;
        private System.Windows.Forms.Label Patron;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentityDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SerialNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Issuing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KPP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AdditionalInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PhysSaveButton;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RegAddr;
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.BindingSource accountsBindingSource;
 
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centralbankcorrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bankbaseDataSetBindingSource;
        private bankbaseDataSet bankbaseDataSet;
        private bankbaseDataSet1 bankbaseDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private bankbaseDataSet1TableAdapters.clientsTableAdapter clientsTableAdapter;
        private bankbaseDataSet2 bankbaseDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private bankbaseDataSet2TableAdapters.clientsTableAdapter clientsTableAdapter1;
        private bankbaseDataSetCLAcc bankbaseDataSetCLAcc;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private bankbaseDataSetCLAccTableAdapters.accountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource bankbaseDataSetCLAccBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountsBindingSource3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PhysNation;
    }
}