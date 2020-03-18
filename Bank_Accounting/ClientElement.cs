using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_Accounting
{
    public partial class ClientElementPhys : Form
    {
        public ClientElementPhys()
        {
            InitializeComponent();
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientElementPhys_Load(object sender, EventArgs e)
        {

            Client client = new Client();
            



            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;


                                 
                  

                client.PhysFill();

                ClientID.Text = client._userID;
                Physname.Text = client.name;
                PhysNation.Text = client.nationality;
                BirthDate.Value = client.birth;
                IdentityDoc.Text = client.document;
                SerialNum.Text = client.serial_num;
                IssueDate.Value = client.date_of_issue;
                Issuing.Text = client.issuing;
                PhoneNumber.Text = client.phone_num;
                Email.Text = client.email;
                INN.Text = client.INN;
                KPP.Text = client.KPP;
                RegAddr.Text = client.address;
                AdditionalInfo.Text = client.additional;

              /*  this.accountsBindingSource2.Filter = "client=" + client._userID;
                this.accountsTableAdapter.Fill(dataTable: this.bankbaseDataSetCLAcc.accounts);

          
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            
            client.name = Physname.Text;
            client.INN = INN.Text;
            client.KPP = KPP.Text;
            client.phone_num = PhoneNumber.Text;
            client.email = Email.Text;
            client.additional = AdditionalInfo.Text;
            client.address = RegAddr.Text;
            client.nationality = PhysNation.Text;
            client.birth = BirthDate.Value;
            client.document = IdentityDoc.Text;
            client.serial_num = SerialNum.Text;
            client.date_of_issue = IssueDate.Value;
            client.issuing = Issuing.Text;
            
            
            
            
            
            
            if (ClientID.Text == "")
            {
                client.PhysSave();
            }
            else
            {
              /*  Client.FormId = Convert.ToInt32(ClientID.Text);
                client.PhyUpdate();
                */
            }
        }
    }
}
