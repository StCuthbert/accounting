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
    public partial class OperationChoice : Form
    {
        public OperationChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                EnrollmentOp enrop = new EnrollmentOp();
                enrop.ShowDialog();
                this.Close();

            }
            else if(radioButton2.Checked == true)
            {
                WithdrawOp withdrawop = new WithdrawOp();
                withdrawop.ShowDialog();
                this.Close();
            }
            else
            {
                TransferOp transop = new TransferOp();
                transop.ShowDialog();
                this.Close();
            }


        }

        private void OperationChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
