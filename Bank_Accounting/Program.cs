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
    public delegate void ClientOpDelegate(string ClientName, string ClientID);
    public delegate void AccountOpDelegate(string Account, string CurrAbbr, int AccID);
    public delegate string ClientIdToAccount();
       static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           


               

               




           


        }

      
    }
}
