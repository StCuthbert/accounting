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
    public partial class ClientChoice : Form
    {
        public ClientChoice()
        {
            InitializeComponent();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(physclient.Checked == true)
            {
                ClientElementPhys clphys = new ClientElementPhys();
                clphys.ShowDialog();
                this.Close();
            }
            else if(legalpers.Checked == true)
            {
                LegalPersonElement cllegal = new LegalPersonElement();
                cllegal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите тип!");
            }

            
        }

        private void ClientChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
