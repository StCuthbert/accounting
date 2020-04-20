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
    public partial class TransferElement : Form
    {
        Transfer op;
        public TransferElement()
        {
            InitializeComponent();
            op = new Transfer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferElement_Load(object sender, EventArgs e)
        {
             
            op.typeOp = textBox1.Text;

            this.DateOfTrans.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            
            op.OpElementFill();
            ID.Text = op.HistoryID;
            ClientName.Text = Operations.ClientName;
            ClientID.Text = Operations.ClientID.ToString();
            AccName.Text = Operations.AccNumber;
            AccID.Text = Operations.AccountID.ToString();
            SumOfTrans.Text = op._sumoftransaction;
            Rate.Text = op._rate;
            Comission.Text = op._comission;
            Totalsum.Text = op._totalsum;
            DateOfTrans.Value = op.transdate;
            PaymentPurpose.Text = op.payment_kind;
            RecieverName.Text = Operations.RecieverName;
            RecieverID.Text = Operations.RecieverID.ToString();
            RecieverAcc.Text = Operations.RecieverAcc;
            RecieverAccID.Text = Operations.RecieverAccID.ToString();

        }
    }
}
