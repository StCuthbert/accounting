using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bank_Accounting
{
    class Payments
    {

        static public int PaymentId { get; set; }
        public string paymentkind { get; set; }

        //Заполнение DGV в справочнике видов платежей из БД
        public DataTable PaymentListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM payment_purpose";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        //Метод для сохранения элемента в справочнике видов платежей
        public void PaymentSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO payment_purpose (id, kind)" +
                "VALUES(null, @kind)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter paymentParam = new MySqlParameter("@kind", paymentkind);


            cmd.Parameters.Add(paymentParam);
            cmd.ExecuteReader();
            conn.Close();
        }

        //Метод для удаления элемента из справочника видов платежей
        public void PaymentDel()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM payment_purpose WHERE id= @PaymentId";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter payidParam = new MySqlParameter("@PaymentID", PaymentId);
            cmd.Parameters.Add(payidParam);
            cmd.ExecuteReader();
            conn.Close();
            PaymentId = 0;
        }
    }
}
