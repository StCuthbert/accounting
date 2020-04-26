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
    public partial class AccountView : Form
    {

        Account acc;
        public AccountView(int accrow)
        {
            InitializeComponent();
            acc = new Account();
            acc.AccRow = accrow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            
            acc.AccFill();
            AccID.Text = acc.id;
            Acc_number.Text = acc.acc_number;
            Bank_name.Text = acc.bank_name;
            BIK.Text = acc.BIK;
            Central_corr.Text = acc.centralbank_corr;
            Kind.Text = acc.kind;
            Currency.Text = acc.currency;
            Balance.Text = acc.balance.ToString();

            switch(acc.currency)
            {
                case "Российский рубль":

                    Currency_label.Text = "руб";
                    break;

                case "Доллар США":

                    Currency_label.Text = "USD";
                    break;

                case "Японская йена":
                    Currency_label.Text = "JPY";
                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OwnHistory ownhist = new OwnHistory(Convert.ToInt32(AccID.Text));
            ownhist.ShowDialog();
        }
    }
}
