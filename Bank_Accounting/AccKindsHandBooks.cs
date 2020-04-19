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
    public partial class AccKindsHandBooks : Form
    {
        DataTable data;
        AccKinds acc_kind;
        public AccKindsHandBooks()
        {
            InitializeComponent();
            acc_kind = new AccKinds();
            Build();
        }

        private void Build()
        {
            data = acc_kind.AccKindFill();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Вид";
          
        }
        private void AccKindsHandBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccKindElement element = new AccKindElement();
            element.ShowDialog();
            Build();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccKinds.KindId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            acc_kind.KindDel();
            Build();
        }
    }
}
