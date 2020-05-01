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
    public partial class ClientsList : Form
    {
        private DataTable data;
        private DataView view;
        Client client;
        public ClientsList()
        {
            InitializeComponent();
            client = new Client();
            Build();
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClientsList_Load(object sender, EventArgs e)
        { 

           


          
        }

        private void Rebuild()
        {

            data = client.ClientListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "ИНН";
            dataGridView1.Columns[3].HeaderText = "КПП";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Дополнительно";
            dataGridView1.Columns[7].HeaderText = "Адрес";
            dataGridView1.Columns[8].HeaderText = "Тип";

        }

        private void Build()
        {
            
            if (data == null)
            {
                data = client.ClientListFill();
                view = new DataView(data);
            }

            //build row filter
            var nameFilter = CLNameFilter.Text;
            if (string.IsNullOrEmpty(nameFilter))
                view.RowFilter = "";
            else
                view.RowFilter = string.Format("Name LIKE '%{0}%'", nameFilter);

            //populate data to DGV
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Наименование";
            dataGridView1.Columns[2].HeaderText = "ИНН";
            dataGridView1.Columns[3].HeaderText = "КПП";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Дополнительно";
            dataGridView1.Columns[7].HeaderText = "Адрес";
            dataGridView1.Columns[8].HeaderText = "Тип";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            string ClientType = dataGridView1.CurrentRow.Cells[8].Value.ToString();


            if (ClientType == "физическое")
            {   
                
                ClientElementPhys cl = new ClientElementPhys(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                cl.ShowDialog();

            }

            else

            {
                LegalPersonElement legalcl = new LegalPersonElement(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                legalcl.ShowDialog();
            }

            


        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

      

        private void button1_Click(object sender, EventArgs e)
        {
            ClientChoice choice = new ClientChoice();
            choice.ShowDialog();
            Rebuild();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            client.ClientDel();
            Rebuild();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void CLNameFilter_TextChanged(object sender, EventArgs e)
        {
            Build();
        }
    }
}
