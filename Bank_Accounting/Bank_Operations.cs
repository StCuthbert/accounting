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
    public partial class Bank_Operations : Form
    {

        private DataTable data;
        private DataView view;
        BankOperations bankop;
        public Bank_Operations()
        {
            InitializeComponent();
            bankop = new BankOperations();
            Build();
        }

        private void Rebuild()
        {

            data = bankop.BankopListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;

        }
        private void Build()
        {

            if (data == null)
            {
                data = bankop.BankopListFill();
                view = new DataView(data);
            }
                        
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Bank_Operations_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Тип";
            dataGridView1.Columns[2].HeaderText = "Итоговая сумма";
            dataGridView1.Columns[3].HeaderText = "Дата операции";
            dataGridView1.Columns[4].HeaderText = "Вид";
            dataGridView1.Columns[5].HeaderText = "Счёт-отправитель";
            dataGridView1.Columns[6].HeaderText = "Счёт-получатель";
            dataGridView1.Columns[7].HeaderText = "История";
        }
    }
}
