using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace Bank_Accounting
{
    class Account
    {
        static public string ClientName { get; set; }
        static public int ClientID { get; set; }
        static public int AccRow { get; set; }

        public string id { get; set; }
        //Номер счета 20 знаков
        public string acc_number { get; set; }
        //Наименование банка
        public string bank_name { get; set; }
        //БИК 
        public string BIK { get; set; }
        //Корреспондентский счет Центрального Банка РФ
        public string centralbank_corr { get; set; }
        //Вид счета
        public string kind { get; set; }
        //Валюта счета
        public string currency { get; set; }
        //Баланс счета
        public decimal balance { get; set; }



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

        public void AccFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM accounts WHERE id = @AccRow";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter AccRowParam = new MySqlParameter("@AccRow", AccRow);
            cmd.Parameters.Add(AccRowParam);


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        id = Convert.ToString(reader.GetValue(0));
                        acc_number = reader.GetString(1);
                        bank_name = reader.GetString(2);
                        BIK = reader.GetString(3);
                        centralbank_corr = reader.GetString(4);
                        kind = reader.GetString(5);
                        currency = reader.GetString(6);
                        balance = Convert.ToDecimal(reader.GetValue(7));






                    }


                }
            }

            conn.Close();
        }
        
        public void AccDelete()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "DELETE from accounts where id=@Accrow";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter accrowParam = new MySqlParameter("@AccRow", AccRow);
            

            cmd.Parameters.Add(accrowParam);
            
            cmd.ExecuteReader();
            conn.Close();
        }

        public DataTable AccountListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM accounts";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
    
}
