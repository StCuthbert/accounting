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
        
        private string client_name;
        private string client_id;
        Rates rates;
        Payments payment;
        Transfer op;
        private string acc_number;
        private string acc_id;
        private string curr_abbr;

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
            client_id = "";
            client_name = "";
            this.AccNumber.Text = "";
            this.AccID.Text = "";
            ClientForOperation clOp = new ClientForOperation(new ClientOpDelegate(Clientfunc));
            clOp.ShowDialog();
            this.ClientName.Text = client_name;
            this.ClientID.Text = client_id;
            this.button2.Enabled = true;
            button5.Enabled = false;
            this.RecieverAcc.Text = "";
            this.RecieverAccID.Text = "";
        }

        // функция для отправителя
        void Clientfunc(string name_param, string id_param)
        {
            client_name = name_param;
            client_id = id_param;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc_number = "";
            AccountsForOperation accop = new AccountsForOperation(new AccountOpDelegate(Accountfunc), new ClientIdToAccount(IdForAcc));
            accop.ShowDialog();

            this.AccNumber.Text = acc_number;
            this.AccID.Text = acc_id;
            this.currency_label.Text = curr_abbr;
          
        }
        void Accountfunc(string account, string currabbr, int accid)
        {

            acc_number = account;
            acc_id = accid.ToString();
            curr_abbr = currabbr;
        }

        string IdForAcc()
        {
            return client_id;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            client_id = "";
            client_name = "";
            this.RecieverAcc.Text = "";
            this.RecieverAccID.Text = "";
            ClientForOperation clOp = new ClientForOperation(new ClientOpDelegate(Clientfunc));
            clOp.ShowDialog();
            this.RecieverName.Text = client_name;
            this.RecieverID.Text = client_id;
            this.button5.Enabled = true;
            this.button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            acc_number = "";
            AccountsForOperation accop = new AccountsForOperation(new AccountOpDelegate(Accountfunc), new ClientIdToAccount(IdForAcc));
            accop.ShowDialog();

            this.RecieverAcc.Text = acc_number;
            this.RecieverAccID.Text = acc_id;

        
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
                op.AccountID = Convert.ToInt32(AccID.Text);
                op.RecieverAccID = Convert.ToInt32(RecieverAccID.Text);
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
