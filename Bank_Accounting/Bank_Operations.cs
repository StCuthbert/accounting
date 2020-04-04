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
    public partial class Bank_Operations : Form
    {

        private DataTable data;
        private DataView view;

        public Bank_Operations()
        {
            InitializeComponent();
            Build();
        }

        private void Rebuild()
        {

            data = new Operations().BankopListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;

        }
        private void Build()
        {

            if (data == null)
            {
                data = new Operations().BankopListFill();
                view = new DataView(data);
            }

            /*build row filter
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

        private void Bank_Operations_Load(object sender, EventArgs e)
        {

        }
    }
}
