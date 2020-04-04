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
        public AccountElement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            
            account.acc_number = Acc_number.Text;
            account.bank_name = Bank_name.Text;
            account.BIK = BIK.Text;
            account.centralbank_corr = Central_corr.Text;
            account.kind = Kind.Text;
            account.currency = Currency.Text;
            account.AccSave();
            this.Close();

        }

        private void AccountElement_Load(object sender, EventArgs e)
        {

        }
    }
}
