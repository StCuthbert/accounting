﻿using System;
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
     
    public partial class WithdrawOp : Form
    {
        Withdraw op;
        private DataTable pay_data;
        private DataTable data;
        private DataView view;
        Rates rates;

        public WithdrawOp()
        {
            InitializeComponent();
            rates = new Rates();
            op = new Withdraw();
            Build();
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

        private void WithdrawOp_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
            op.sumoftransaction = Convert.ToDecimal(SumOfTrans.Text);
            op.rate = Convert.ToDecimal(comboRate.Text);
            op.typeOp = "снятие";
            op.payment_kind = " ";
            op.RecieverAccID = 0;
            try
            {
                op.AccountID = Convert.ToInt32(AccID.Text);
            }
            catch
            {
                MessageBox.Show("Заполните карточку операции правильно!");
                return;
            }
            op.OpSave();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AccNumber.Text = "";
            this.AccID.Text = "";
            ClientForOperation clOp = new ClientForOperation(new ClientOpDelegate(Clientfunc));
            clOp.ShowDialog();
         
            this.button2.Enabled = true;
        }
        void Clientfunc(string name_param, string id_param)
        {
            this.ClientName.Text = name_param;
            this.ClientID.Text = id_param.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountsForOperation accop = new AccountsForOperation(new AccountOpDelegate(Accountfunc), new ClientIdToAccount(IdForAcc));
            
            accop.ShowDialog();
            
         
            
        }
        void Accountfunc(string account, string currabbr, int accid)
        {

            this.AccNumber.Text = account;
            this.AccID.Text = accid.ToString();
            this.currency_label.Text = currabbr;
        }

        string IdForAcc()
        {
            return this.ClientID.Text;
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
