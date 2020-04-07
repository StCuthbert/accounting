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

        public RatesHandbook()
        {
            InitializeComponent();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Operations().RatesListFill();
                view = new DataView(data);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Rebuild()
        {
            data = new Operations().RatesListFill();
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
            Operations.RateId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Operations op = new Operations();
            op.RateDel();
            Rebuild();
        }
    }
}
