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
    public partial class OperationsList : Form
    {

        private DataTable data;
        private DataView view;
        public OperationsList()
        {
            InitializeComponent();
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
        }

        private void Rebuild()
        {
            data = new Operations().OperationListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;

        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            OperationChoice opchoice = new OperationChoice();
            opchoice.ShowDialog();
            Rebuild();
        }

        private void OperationsList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rebuild();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operations.OpId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Operations op = new Operations();
            op.OpDel();
            Rebuild();
        }
    }
}
