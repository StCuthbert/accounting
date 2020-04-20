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
    public partial class TransferOp : Form
    {

        private DataTable pay_data;
        private DataTable data;
        private DataView view;
        Rates rates;
        Payments payment;
        Transfer op;

        public TransferOp()
        {
            InitializeComponent();
            rates = new Rates();
            payment = new Payments();
            op = new Transfer();
            Build();
            ComboBuild();
        }

        private void Build()
        {

            if (data == null)
            {
                data = rates.comboRateFill();

            }

            comboRate.DataSource = null;
            comboRate.DataSource = data;
            comboRate.DisplayMember = "rate";

        }

        private void ComboBuild()
        {
            if (pay_data == null)
            {
                pay_data = payment.PaymentListFill();
            }

            ComboPay.DataSource = null;
            ComboPay.DataSource = pay_data;
            ComboPay.DisplayMember = "kind";
        }

        private void OperView()
        {
            Operations oper = new Operations();



            try
            {
                oper.sumoftransaction = Convert.ToDecimal(SumOfTrans.Text);

            }
            catch
            {
                MessageBox.Show("Введите сумму корректно!");
                SumOfTrans.Text = "0,00";
            }

            oper.rate = Convert.ToDecimal(comboRate.Text);
            oper.OperationView();


            decimal a = (decimal)Math.Round(oper.comission, 2);
            string b = a.ToString();
            Comission.Text = b;
            decimal c = (decimal)Math.Round(oper.totalsum, 2);
            string d = c.ToString();
            Totalsum.Text = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AccNumber.Text = "";
            this.AccID.Text = "";
            ClientForOperation clOp = new ClientForOperation();
            clOp.ShowDialog();
            this.ClientName.Text = Operations.ClientName;
            this.ClientID.Text = Operations.ClientID.ToString();
            this.button2.Enabled = true;
            button5.Enabled = false;
            this.RecieverAcc.Text = "";
            this.RecieverAccID.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountsForOperation accop = new AccountsForOperation();
            accop.ShowDialog();
            this.AccNumber.Text = Operations.AccNumber;
            this.AccID.Text = Operations.AccountID.ToString();
            this.currency_label.Text = AccCurrency.CurrAbbr;
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.RecieverAcc.Text = "";
            this.RecieverAccID.Text = "";
            ClientForOperation clOp = new ClientForOperation();
            clOp.ShowDialog();
            this.RecieverName.Text = Operations.ClientName;
            this.RecieverID.Text = Operations.ClientID.ToString();
            this.button5.Enabled = true;
            this.button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountsForOperation accop = new AccountsForOperation();
            accop.ShowDialog();
            this.RecieverAcc.Text = Operations.AccNumber;
            this.RecieverAccID.Text = Operations.AccountID.ToString();

      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SumOfTrans_TextChanged(object sender, EventArgs e)
        {
            OperView();
        }

        private void comboRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OperView();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            op.sumoftransaction = Convert.ToDecimal(SumOfTrans.Text);
            op.rate = Convert.ToDecimal(comboRate.Text);
            op.payment_kind = ComboPay.Text;
            op.typeOp = "перевод";
            try
            {
                Operations.AccountID = Convert.ToInt32(AccID.Text);
                Operations.RecieverAccID = Convert.ToInt32(RecieverAccID.Text);
            }
            catch
            {
                MessageBox.Show("Заполните карточку операции правильно!");
                return;
            }
            op.OpSave();
            this.Close();
        }

        private void TransferOp_Load(object sender, EventArgs e)
        {

        }
    }
}
