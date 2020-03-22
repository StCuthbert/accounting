using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bank_Accounting
{
    class Account
    {
        static public string ClientName;
        static public int ClientID;

        public string id;
        //Номер счета 20 знаков
        public string acc_number;
        //Наименование банка
        public string bank_name;
        //БИК 
        public string BIK;
        //Корреспондентский счет Центрального Банка РФ
        public string centralbank_corr;
        //Вид счета
        public string kind;
        //Валюта счета
        public string currency;
        //Баланс счета
        public decimal balance;

      

        public void AccSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            
            string sql = "INSERT INTO accounts (id, acc_number, bank_name, BIK, centralbank_corr, kind, currency, client )" +
                "VALUES(null, @acc_number, @bank_name, @BIK, @centralbank_corr, @kind, @currency, @ClientID)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter accParam = new MySqlParameter("@acc_number", acc_number);
            MySqlParameter bankParam = new MySqlParameter("@bank_name", bank_name);
            MySqlParameter bikParam = new MySqlParameter("@BIK", BIK);
            MySqlParameter centralParam = new MySqlParameter("@centralbank_corr", centralbank_corr);
            MySqlParameter kindParam = new MySqlParameter("@kind", kind);
            MySqlParameter currencyParam = new MySqlParameter("@currency", currency);
            MySqlParameter clientIDParam = new MySqlParameter("@ClientID", ClientID);
          

            cmd.Parameters.Add(accParam);
            cmd.Parameters.Add(bankParam);
            cmd.Parameters.Add(bikParam);
            cmd.Parameters.Add(centralParam);
            cmd.Parameters.Add(kindParam);
            cmd.Parameters.Add(currencyParam);
            cmd.Parameters.Add(clientIDParam);

            cmd.ExecuteReader();
            conn.Close();
           
        }
    }
    
}
