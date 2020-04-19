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
    public partial class AccountElement: Form
    {
        DataTable data;
        DataTable kind_data;

        Account account;
        public AccountElement()
        {
            InitializeComponent();
            account = new Account();
            ComboCurrBuild();
            ComboKindBuild();
        }

        private void ComboCurrBuild()
        {
            if (data == null)
            {
                data = new AccCurrency().comboCurrFill();
            }

            comboCurr.DataSource = null;
            comboCurr.DataSource = data;
            comboCurr.DisplayMember = "currency";
        }

        private void ComboKindBuild()
        {
            if (kind_data == null)
            {
                kind_data = new AccKinds().AccKindFill();            }

            comboKind.DataSource = null;
            comboKind.DataSource = kind_data;
            comboKind.DisplayMember = "kind";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            account.acc_number = Acc_number.Text;
            account.bank_name = Bank_name.Text;
            account.BIK = BIK.Text;
            account.centralbank_corr = Central_corr.Text;
            account.kind = comboKind.Text;
            account.currency = comboCurr.Text;
            account.AccSave();
            this.Close();

        }

        private void AccountElement_Load(object sender, EventArgs e)
        {

        }
    }
}
