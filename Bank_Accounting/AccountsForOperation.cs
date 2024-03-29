﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Accounting
{
    public partial class AccountsForOperation : Form
    {
        private DataTable data;
        private DataView view;
        AccountOpDelegate accdelegate;
        AccountForOp accop;
        string idFilter;
        ClientIdToAccount client_id;
        public AccountsForOperation(AccountOpDelegate sender, ClientIdToAccount clid)
        {
            InitializeComponent();
            accdelegate = sender;
            client_id = clid;
            accop = new AccountForOp();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = accop.AccountForOpFill();
                view = new DataView(data);
            }

            idFilter = client_id();
            view.RowFilter = string.Format("client =" + idFilter);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
           
        }

       

        private void AccountsForOperation_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Номер счёта";
            dataGridView1.Columns[2].HeaderText = "Наименование банка";
            dataGridView1.Columns[3].HeaderText = "БИК";
            dataGridView1.Columns[4].HeaderText = "Корреспондентский счёт";
            dataGridView1.Columns[5].HeaderText = "Вид счёта";
            dataGridView1.Columns[6].HeaderText = "Валюта";
            dataGridView1.Columns[7].HeaderText = "Баланс";
            dataGridView1.Columns[8].HeaderText = "Клиент";
            dataGridView1.Columns[9].HeaderText = "ID";
            dataGridView1.Columns[10].HeaderText = "Валюта по справочнику";
            dataGridView1.Columns[11].HeaderText = "Сокращение";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                accdelegate(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Отсутствуют счета для выбора!");
            }
                

        }
    }
}
