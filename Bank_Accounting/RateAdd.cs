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
    public partial class RateAdd : Form
    {
        public RateAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rates op = new Rates();
            op.newrate = Convert.ToDecimal(textBox1.Text);
            op.RateSave();
            this.Close();
        }

        private void RateAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
