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
    public partial class OperationsList : Form
    {
        public OperationsList()
        {
            InitializeComponent();
        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            OperationChoice opchoice = new OperationChoice();
            opchoice.ShowDialog();
        }
    }
}
