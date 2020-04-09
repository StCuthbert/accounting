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

        public LegalPersonElement()
        {
            InitializeComponent();
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
    }
}
