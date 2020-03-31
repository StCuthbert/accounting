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
    public partial class ClientForOperation : Form
    {
        private DataTable data;
        private DataView view;
        

        public ClientForOperation()
        {
            InitializeComponent();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Client().ClientListFill();
                view = new DataView(data);
            }

            //build row filter
            var nameFilter = CLNameFilter.Text;
            if (string.IsNullOrEmpty(nameFilter))
                view.RowFilter = "";
            else
                view.RowFilter = string.Format("Name LIKE '%{0}%'", nameFilter);

            //populate data to DGV
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void ClientForOperation_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operations.ClientID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Operations.ClientName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}