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
    public partial class WithdrawElement : Form
    {
        Withdraw op;
        public WithdrawElement(int op_id)
        {
            InitializeComponent();
            op = new Withdraw();
            op.OpId = op_id;
        }

        private void WithdrawElement_Load(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
