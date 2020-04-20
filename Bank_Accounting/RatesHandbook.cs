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
    public partial class RatesHandbook : Form
    {
        private DataTable data;
        private DataView view;
        Rates rates;

        public RatesHandbook()
        {
            InitializeComponent();
            rates = new Rates();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = rates.RatesListFill();
                view = new DataView(data);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Rebuild()
        {
            data = rates.RatesListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RatesHandbook_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Процентная ставка";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RateAdd radd = new RateAdd();
            radd.ShowDialog();
            Rebuild();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rates.RateId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            rates.RateDel();
            Rebuild();
        }
    }
}
