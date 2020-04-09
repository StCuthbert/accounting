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
    public partial class NewPhysClient : Form
    {
        public NewPhysClient()
        {
            InitializeComponent();
        }

        private void PhysSaveButton_Click(object sender, EventArgs e)
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
            client.PhysSave();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
