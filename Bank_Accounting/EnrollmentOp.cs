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
    public partial class EnrollmentOp : Form
    {
        private DataTable pay_data;
        private DataTable data;
        private DataView view;

        public EnrollmentOp()
        {
            InitializeComponent();
            Build();
            ComboBuild();
          

        }

        private void Build()
        {

            if (data == null)
            {
                data = new Operations().comboRateFill();
              
            }

            comboRate.DataSource = null;
            comboRate.DataSource = data;
            comboRate.DisplayMember = "rate";
           
        }

        private void ComboBuild()
        {
            if (pay_data == null)
            {
                pay_data = new Operations().PaymentListFill();
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
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Operations op = new Operations();
            op.sumoftransaction = Convert.ToDecimal(SumOfTrans.Text);
            op.rate = Convert.ToDecimal(comboRate.Text);
            op.payment_kind = ComboPay.Text;
            op.typeOp = "зачисление";
            Operations.AccountID = Convert.ToInt32(AccID.Text);
            
            op.OpSave();
            this.Close();
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountsForOperation accop = new AccountsForOperation();
            accop.ShowDialog();
            this.AccNumber.Text = Operations.AccNumber;
            this.AccID.Text = Operations.AccountID.ToString();

            switch (Operations.AccCurrency)
            {

                case "Российский рубль":
                    this.currency_label.Text = "руб";
                    break;

                case "Доллар США":
                    this.currency_label.Text = "USD";
                    break;

                case "Японская йена":
                    this.currency_label.Text = "JPY";
                    break;
            }
            
        }
        
        private void EnrollmentOp_Load(object sender, EventArgs e)
        {
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
    }
}
