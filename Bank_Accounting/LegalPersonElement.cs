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
    public partial class LegalPersonElement : Form
    {
        public LegalPersonElement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client clsv = new Client();
            

            clsv.name = LegalName.Text;
            clsv.INN = INN.Text;
            clsv.KPP = KPP.Text;
            clsv.phone_num = Phone.Text;
            clsv.email = Email.Text;
            clsv.additional = Additional.Text;
            clsv.address = Address.Text;
            clsv.fullname = FullName.Text;
            clsv.okved = OKVED.Text;
            clsv.okpo = OKPO.Text;
            clsv.ogrn = OGRN.Text;
            clsv.okato = OKATO.Text;
            clsv.oktmo = OKTMO.Text;
            clsv.catcode = Catcode.Text;
            clsv.cenral_corr = CB_corr.Text;
            clsv.acc = Acc.Text;
            clsv.BIK = BIK.Text;
            clsv.bank_name = BankName.Text;
            clsv.bank_addr = BankAddr.Text;
            clsv.director = Director.Text;
            clsv.post_addr = PostAddr.Text;


            if (LegalID.Text == "")

            {
                clsv.LegalSave();
            }

            else

            {

                Client.FormId = Convert.ToInt32(LegalID.Text);
                clsv.LegalUpdate();
                  
            }
        }

        private void LegalPersonElement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "basereforgedDataSet4.accounts". При необходимости она может быть перемещена или удалена.
            this.accountsTableAdapter.Fill(this.basereforgedDataSet4.accounts);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

           

            Client clsv = new Client();
            clsv.LegalFill();

            LegalID.Text = clsv._userID;
            LegalName.Text = clsv.name;
            INN.Text = clsv.INN;
            KPP.Text = clsv.KPP;
            Phone.Text = clsv.phone_num;
            Email.Text = clsv.email;
            Additional.Text = clsv.additional;
            Address.Text = clsv.address;
            FullName.Text = clsv.fullname;
            OKVED.Text = clsv.okved;
            OKPO.Text = clsv.okpo;
            OGRN.Text = clsv.ogrn;
            OKATO.Text = clsv.okato;
            OKTMO.Text = clsv.oktmo;
            Catcode.Text = clsv.catcode;
            CB_corr.Text = clsv.cenral_corr;
            Acc.Text = clsv.acc;
            BIK.Text = clsv.BIK;
            BankName.Text = clsv.bank_name;
            BankAddr.Text = clsv.bank_addr;
            Director.Text = clsv.director;
            PostAddr.Text = clsv.post_addr;

            this.accountsBindingSource.Filter = "client=" + clsv._userID;
            this.accountsTableAdapter.Fill(dataTable: this.basereforgedDataSet4.accounts);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account.ClientID = Convert.ToInt32(LegalID.Text);
            Account.ClientName = LegalName.Text;
            AccountElement accel = new AccountElement();
            accel.ShowDialog();
        }
    }
}
