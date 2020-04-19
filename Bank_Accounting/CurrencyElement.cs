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
    
    public partial class CurrencyElement : Form
    {
        AccCurrency acccurr;
        public CurrencyElement()
        {
            InitializeComponent();
            acccurr = new AccCurrency();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acccurr.CurrencyName = CurrName.Text;
            acccurr.CurrAbbr =  CurrAbbr.Text;
            acccurr.CurrencySave();
            this.Close(); 
        }

        private void CurrencyElement_Load(object sender, EventArgs e)
        {

        }
    }
}
