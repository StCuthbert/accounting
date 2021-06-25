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

        // Справочник видов валют логика

        public string CurrencyName { get; set; }
        static public string CurrAbbr { get; set; }
        static public int CurrId { get; set; }
        
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

        public void CurrencyDel()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM currency WHERE id=@CurrId";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter CurrIdParam = new MySqlParameter("@CurrId", CurrId);
            cmd.Parameters.Add(CurrIdParam);
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

        public DataTable comboCurrFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT currency FROM currency";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
}
