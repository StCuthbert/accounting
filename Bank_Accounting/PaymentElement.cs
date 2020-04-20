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
        Payments payment;
        public PaymentElement()
        {
            InitializeComponent();
            payment = new Payments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            payment.paymentkind = PaymentKind.Text;
            payment.PaymentSave();
            this.Close();
        }

        private void PaymentElement_Load(object sender, EventArgs e)
        {

        }
    }
}
