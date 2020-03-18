using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bank_Accounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsList a = new ClientsList();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountList a = new AccountList();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HistoryList a = new HistoryList();
            a.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
