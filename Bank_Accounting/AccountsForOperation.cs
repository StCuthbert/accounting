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
    public partial class AccountsForOperation : Form
    {
        private DataTable data;
        private DataView view;

        public AccountsForOperation()
        {
            InitializeComponent();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Account().AccountListFill();
                view = new DataView(data);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

       

        private void AccountsForOperation_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations.AccountID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Operations.AccNumber = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Operations.AccCurrency = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.Close();
        }
    }
}
