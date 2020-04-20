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
    public partial class EnrollElement : Form
    {
        Enrollment op;
        public EnrollElement()
        {
            InitializeComponent();
            op = new Enrollment();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnrollElement_Load(object sender, EventArgs e)
        {
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
            
        }
    }
}
