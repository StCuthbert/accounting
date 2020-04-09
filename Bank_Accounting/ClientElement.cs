﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Accounting
{
    public partial class ClientElementPhys : Form
    {
        private DataTable data;
        private DataView view;

        public ClientElementPhys()
        {
            InitializeComponent();
            Initialize();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Account().AccountListFill();
                view = new DataView(data);
            }

            
            var idFilter = ClientID.Text;
            view.RowFilter = string.Format("client =" + idFilter);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Initialize()
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            Client client = new Client();

            client.PhysFill();

            ClientID.Text = client._userID;
            Physname.Text = client.name;
            PhysNation.Text = client.nationality;
            
            IdentityDoc.Text = client.document;
            SerialNum.Text = client.serial_num;
            BirthDate.Value = client.birth;
            IssueDate.Value = client.date_of_issue;
            Issuing.Text = client.issuing;
            PhoneNumber.Text = client.phone_num;
            Email.Text = client.email;
            INN.Text = client.INN;
            KPP.Text = client.KPP;
            RegAddr.Text = client.address;
            AdditionalInfo.Text = client.additional;

        }

        private void Rebuild()
        {
            data = new Account().AccountListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            var idFilter = ClientID.Text;
            view.RowFilter = string.Format("client =" + idFilter);
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientElementPhys_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            
            client.name = Physname.Text;
            client.INN = INN.Text;
            client.KPP = KPP.Text;
            client.phone_num = PhoneNumber.Text;
            client.email = Email.Text;
            client.additional = AdditionalInfo.Text;
            client.address = RegAddr.Text;
            client.nationality = PhysNation.Text;
            client.birth = BirthDate.Value;
            client.document = IdentityDoc.Text;
            client.serial_num = SerialNum.Text;
            client.date_of_issue = IssueDate.Value;
            client.issuing = Issuing.Text;
            
            
            
            
            
            
            if (ClientID.Text == "")
            {
                client.PhysSave();
            }
            else
            {
                Client.FormId = Convert.ToInt32(ClientID.Text);
                client.PhysUpdate();
               
            }

           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Account.ClientID = Convert.ToInt32(ClientID.Text);
            Account.ClientName = Physname.Text;
            AccountElement accel = new AccountElement();
            accel.ShowDialog();
            Rebuild();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Account.AccRow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           Account acnt = new Account();
           acnt.AccDelete();
           Rebuild();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Account.AccRow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AccountView accview = new AccountView();
            accview.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
