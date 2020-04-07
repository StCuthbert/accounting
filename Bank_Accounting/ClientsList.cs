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
        public ClientsList()
        {
            InitializeComponent();
            Build();
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClientsList_Load(object sender, EventArgs e)
        { 

           


            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderText = "ID";





        }

        private void Rebuild()
        {

            data = new Client().ClientListFill();
            view = new DataView(data);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;

        }

        private void Build()
        {
            
            if (data == null)
            {
                data = new Client().ClientListFill();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Client.ClientType = dataGridView1.CurrentRow.Cells[8].Value.ToString();


            if (Client.ClientType == "физическое")
            {   
                
                ClientElementPhys client = new ClientElementPhys();
                client.ShowDialog();

            }

            else

            {
                LegalPersonElement legalcl = new LegalPersonElement();
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
            Client.RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Client client = new Client();
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
