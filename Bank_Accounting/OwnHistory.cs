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
    public partial class OwnHistory : Form
    {
        private DataTable data;
        private DataView view;

        public OwnHistory()
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

            var idFilter = Account.AccRow.ToString();

            List<string> list = new List<string>(2);
            list.Add("[acc1_id] = '" + idFilter + "'");
            list.Add("[acc2_id] = '" + idFilter + "'");
            view.RowFilter = string.Join("OR", list.ToArray());
            
            
           
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

        private void OwnHistory_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Тип операции";
            dataGridView1.Columns[2].HeaderText = "Сумма операции";
            dataGridView1.Columns[3].HeaderText = "Процентная ставка";
            dataGridView1.Columns[4].HeaderText = "Сумма комиссии";
            dataGridView1.Columns[5].HeaderText = "Итоговая сумма";
            dataGridView1.Columns[6].HeaderText = "Дата операции";
            dataGridView1.Columns[7].HeaderText = "Счёт-отправитель";
            dataGridView1.Columns[8].HeaderText = "Счёт-получатель";
            dataGridView1.Columns[9].HeaderText = "Назначение";
        }
    }
}
