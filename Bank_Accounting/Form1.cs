﻿using System;
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
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperationsList oplist = new OperationsList();
            oplist.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RatesHandbook ratehand = new RatesHandbook();
            ratehand.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PaymentPurposeList paylist = new PaymentPurposeList();
            paylist.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bank_Operations bankop = new Bank_Operations();
            bankop.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrencyHandbook handbook = new CurrencyHandbook();
            handbook.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AccKindsHandBooks handBooks = new AccKindsHandBooks();
            handBooks.ShowDialog();
        }
    }
}
