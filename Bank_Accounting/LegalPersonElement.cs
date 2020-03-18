﻿using System;
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
    public partial class LegalPersonElement : Form
    {
        public LegalPersonElement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client clsv = new Client();
            

            clsv.name = LegalName.Text;
            clsv.INN = INN.Text;
            clsv.KPP = KPP.Text;
            clsv.phone_num = Phone.Text;
            clsv.email = Email.Text;
            clsv.additional = Additional.Text;
            clsv.address = Address.Text;
            clsv.fullname = FullName.Text;
            clsv.okved = OKVED.Text;
            clsv.okpo = OKPO.Text;
            clsv.ogrn = OGRN.Text;
            clsv.okato = OKATO.Text;
            clsv.oktmo = OKTMO.Text;
            clsv.catcode = Catcode.Text;
            clsv.cenral_corr = CB_corr.Text;
            clsv.acc = Acc.Text;
            clsv.BIK = BIK.Text;
            clsv.bank_name = BankName.Text;
            clsv.bank_addr = BankAddr.Text;
            clsv.director = Director.Text;
            clsv.post_addr = PostAddr.Text;

            if (LegalID.Text == "")
            {
                clsv.LegalSave();
            }
            else
            {
                /*  Client.FormId = Convert.ToInt32(ClientID.Text);
                  client.PhyUpdate();
                  */
            }
        }

        private void LegalPersonElement_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            client.LegalFill();
        }
    }
}