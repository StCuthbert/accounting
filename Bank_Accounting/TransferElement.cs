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
    public partial class TransferElement : Form
    {
        Transfer op;
        public TransferElement(int op_id)
        {
            InitializeComponent();
            op = new Transfer();
            op.OpId = op_id;
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
            ClientName.Text = op.ClientName;
            ClientID.Text = op.ClientID.ToString();
            AccName.Text = op.AccNumber;
            AccID.Text = op.AccountID.ToString();
            SumOfTrans.Text = op._sumoftransaction;
            Rate.Text = op._rate;
            Comission.Text = op._comission;
            Totalsum.Text = op._totalsum;
            DateOfTrans.Value = op.transdate;
            PaymentPurpose.Text = op.payment_kind;
            RecieverName.Text = op.RecieverName;
            RecieverID.Text = op.RecieverID.ToString();
            RecieverAcc.Text = op.RecieverAcc;
            RecieverAccID.Text = op.RecieverAccID.ToString();

        }
    }
}
