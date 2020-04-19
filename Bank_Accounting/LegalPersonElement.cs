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
        private DataTable data;
        private DataView view;
        Client client;
        public LegalPersonElement()
        {
            InitializeComponent();
            client = new Client();
            Initialize();
            Build();
        }

        private void Build()
        {

            if (data == null)
            {
                data = new Account().AccountListFill();
                view = new DataView(data);
            }
            var idFilter = LegalID.Text;
            view.RowFilter = string.Format("client =" + idFilter);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Rebuild()
        {
            data = new Account().AccountListFill();
            view = new DataView(data);
            var idFilter = LegalID.Text;
            view.RowFilter = string.Format("client =" + idFilter);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = view;
        }

        private void Initialize()
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;




            client.LegalFill();

            LegalID.Text = client._userID;
            LegalName.Text = client.name;
            INN.Text = client.INN;
            KPP.Text = client.KPP;
            Phone.Text = client.phone_num;
            Email.Text = client.email;
            Additional.Text = client.additional;
            Address.Text = client.address;
            FullName.Text = client.fullname;
            OKVED.Text = client.okved;
            OKPO.Text = client.okpo;
            OGRN.Text = client.ogrn;
            OKATO.Text = client.okato;
            OKTMO.Text = client.oktmo;
            Catcode.Text = client.catcode;
            CB_corr.Text = client.cenral_corr;
            Acc.Text = client.acc;
            BIK.Text = client.BIK;
            BankName.Text = client.bank_name;
            BankAddr.Text = client.bank_addr;
            Director.Text = client.director;
            PostAddr.Text = client.post_addr;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            client.name = LegalName.Text;
            client.INN = INN.Text;
            client.KPP = KPP.Text;
            client.phone_num = Phone.Text;
            client.email = Email.Text;
            client.additional = Additional.Text;
            client.address = Address.Text;
            client.fullname = FullName.Text;
            client.okved = OKVED.Text;
            client.okpo = OKPO.Text;
            client.ogrn = OGRN.Text;
            client.okato = OKATO.Text;
            client.oktmo = OKTMO.Text;
            client.catcode = Catcode.Text;
            client.cenral_corr = CB_corr.Text;
            client.acc = Acc.Text;
            client.BIK = BIK.Text;
            client.bank_name = BankName.Text;
            client.bank_addr = BankAddr.Text;
            client.director = Director.Text;
            client.post_addr = PostAddr.Text;
            Client.FormId = Convert.ToInt32(LegalID.Text);
            client.LegalUpdate();
            this.Close();
                  
            
        }

        private void LegalPersonElement_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Номер счёта";
            dataGridView1.Columns[2].HeaderText = "Наименование банка";
            dataGridView1.Columns[3].HeaderText = "БИК";
            dataGridView1.Columns[4].HeaderText = "Корреспондентский счёт";
            dataGridView1.Columns[5].HeaderText = "Вид счёта";
            dataGridView1.Columns[6].HeaderText = "Валюта";
            dataGridView1.Columns[7].HeaderText = "Баланс";
            dataGridView1.Columns[8].HeaderText = "Клиент";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account.ClientID = Convert.ToInt32(LegalID.Text);
            Account.ClientName = LegalName.Text;
            AccountElement accel = new AccountElement();
            accel.ShowDialog();
            Rebuild();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Account.AccRow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Account acnt = new Account();
            acnt.AccDelete();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccDelete();
            Rebuild();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Account.AccRow = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AccountView accview = new AccountView();
            accview.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            LegalName.Enabled = true;
            INN.Enabled = true;
            KPP.Enabled = true;
            Phone.Enabled = true;
            Email.Enabled = true;
            Additional.Enabled = true;
            Address.Enabled = true;
            FullName.Enabled = true;
            OKVED.Enabled = true;
            OKPO.Enabled = true;
            OGRN.Enabled = true;
            OKATO.Enabled = true;
            OKTMO.Enabled = true;
            Catcode.Enabled = true;
            CB_corr.Enabled = true;
            Acc.Enabled = true;
            BIK.Enabled = true;
            BankName.Enabled = true;
            BankAddr.Enabled = true;
            Director.Enabled = true;
            PostAddr.Enabled = true;
        }
    }
}
