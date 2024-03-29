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
    public partial class OperationsList : Form
    {

        private DataTable data;
        private DataView view;
        Operations op;
        public OperationsList()
        {
            InitializeComponent();
            op = new Operations();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Operations().OperationListFill();
                view = new DataView(data);
            }
         
            //populate data to DGV
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Тип операции";
            dataGridView1.Columns[2].HeaderText = "Сумма операции";
            dataGridView1.Columns[3].HeaderText = "Процентная ставка";
            dataGridView1.Columns[4].HeaderText = "Сумма комиссии";
            dataGridView1.Columns[5].HeaderText = "Итоговая сумма";
            dataGridView1.Columns[6].HeaderText = "Дата операции";
            dataGridView1.Columns[7].HeaderText = "Счёт-отправитель";
            dataGridView1.Columns[8].HeaderText = "Счёт-получатель";
            dataGridView1.Columns[9].HeaderText = "Назначение";
        }

        private void Rebuild()
        {
            data = new Operations().OperationListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Тип операции";
            dataGridView1.Columns[2].HeaderText = "Сумма операции";
            dataGridView1.Columns[3].HeaderText = "Процентная ставка";
            dataGridView1.Columns[4].HeaderText = "Сумма комиссии";
            dataGridView1.Columns[5].HeaderText = "Итоговая сумма";
            dataGridView1.Columns[6].HeaderText = "Дата операции";
            dataGridView1.Columns[7].HeaderText = "Счёт-отправитель";
            dataGridView1.Columns[8].HeaderText = "Счёт-получатель";
            dataGridView1.Columns[9].HeaderText = "Назначение";

        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            OperationChoice opchoice = new OperationChoice();
            opchoice.ShowDialog();
            Rebuild();
        }

        private void OperationsList_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rebuild();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op.OpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
            op.OpDel();
            Rebuild();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            switch (dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                case "зачисление":

                   
                    EnrollElement enrEl = new EnrollElement(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    enrEl.ShowDialog();

                    break;

                case "снятие":

                    
                    WithdrawElement withEl = new WithdrawElement(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    withEl.ShowDialog();

                    break;

                case "перевод":

                    
                    TransferElement transel = new TransferElement(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    transel.ShowDialog();

                    break;

            }
            
        }
    }
}
