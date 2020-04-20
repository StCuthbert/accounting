using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bank_Accounting
{
    class Rates
    {

        public decimal newrate { get; set; }
        static public int RateId { get; set; }

        //Получаем DataTable для заполнения комбобокса с процентами
        public DataTable comboRateFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT rate FROM rates";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        // Получаем DataTable для заполнения DGV с процентными ставками в справочнике ставок
        public DataTable RatesListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM rates";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        // Метод для сохранения новой записи о процентной ставке в таблицу процентных ставок в БД
        public void RateSave()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO rates (id, rate)" +
                "VALUES(null, @newrate)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            
            MySqlParameter newrateParam = new MySqlParameter("@newrate", newrate);


            cmd.Parameters.Add(newrateParam);
            cmd.ExecuteReader();
            conn.Close();

        }

        // Метод для удаления записи о процентной ставке из таблицы в БД
        public void RateDel()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM rates WHERE id= @RateID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter rateidParam = new MySqlParameter("@RateID", RateId);
            cmd.Parameters.Add(rateidParam);
            cmd.ExecuteReader();
            conn.Close();
            RateId = 0;
        }
    }
}
