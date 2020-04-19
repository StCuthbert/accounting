using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bank_Accounting
{
    class AccCurrency
    {
        public string CurrencyName { get; set; }
        public string CurrAbbr { get; set; }

        public void CurrencySave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO currency (id, currency, curabbr) values( null, @currency, @curabbr)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter currencyParam = new MySqlParameter("@currency", CurrencyName);
            MySqlParameter abbrParam = new MySqlParameter("@curabbr", CurrAbbr);
            cmd.Parameters.Add(currencyParam);
            cmd.Parameters.Add(abbrParam);
            cmd.ExecuteReader();
            conn.Close();



        }
        public DataTable CurrencyFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM currency";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
}
