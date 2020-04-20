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
    public partial class PaymentPurposeList : Form
    {
        private DataTable data;
        private DataView view;
        Payments payment;

        public PaymentPurposeList()
        {
            InitializeComponent();
            payment = new Payments();
            Build();
        }

        private void Rebuild()
        {

            data = payment.PaymentListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Вид";
        }
        private void Build()
        {

            if (data == null)
            {
                data = payment.PaymentListFill();
                view = new DataView(data);
            }

            
            //populate data to DGV
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Вид";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentElement payelement = new PaymentElement();
            payelement.ShowDialog();
            Rebuild();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payments.PaymentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            
            payment.PaymentDel();
            Rebuild();
        }

        private void PaymentPurposeList_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
