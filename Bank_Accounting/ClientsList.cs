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
        public ClientsList()
        {
            InitializeComponent();
           // this.listClient.DataSource
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClientsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basereforgedDataSet2.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter4.Fill(this.basereforgedDataSet2.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basereforgedDataSet1.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter3.Fill(this.basereforgedDataSet1.clients);


            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            
           
            

            

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
           
        }
    }
}
