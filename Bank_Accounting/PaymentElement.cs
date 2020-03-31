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
    public partial class PaymentElement : Form
    {
        public PaymentElement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations oper = new Operations();
            oper.payment_kind = PaymentKind.Text;
            oper.PaymentSave();
            this.Close();
        }

        private void PaymentElement_Load(object sender, EventArgs e)
        {

        }
    }
}
