using System;
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
    public partial class CurrencyHandbook : Form
    {
        DataTable data;
        DataView view;
        
        public CurrencyHandbook()
        {
            InitializeComponent();
            Build();
        }
       
        private void Build()
        {
            
            data = new AccCurrency().CurrencyFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Валюта";
            dataGridView1.Columns[2].HeaderText = "Сокращение";
        }

        private void CurrencyHandbook_Load(object sender, EventArgs e)
        {
     
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrencyElement element = new CurrencyElement();
            element.ShowDialog();
            Build();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Build();
        }
    }
}
