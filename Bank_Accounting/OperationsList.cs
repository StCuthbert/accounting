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
            /*
            //build row filter
            var nameFilter = CLNameFilter.Text;
            if (string.IsNullOrEmpty(nameFilter))
                view.RowFilter = "";
            else
                view.RowFilter = string.Format("Name LIKE '%{0}%'", nameFilter);
                */
            //populate data to DGV
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            OperationChoice opchoice = new OperationChoice();
            opchoice.ShowDialog();
        }

        private void OperationsList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }
    }
}
