using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bank_Accounting
{
    class AccKinds
    {
        public string Kind { get; set; }
        static public int KindId { get; set; }
        public DataTable AccKindFill()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM acckind";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;

        }

        public void KindSave()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO acckind(id, kind) values(null, @kind)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter kindParam = new MySqlParameter("@kind", Kind);
            cmd.Parameters.Add(kindParam);
            cmd.ExecuteReader();
            conn.Close();

        }

        public void KindDel()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM acckind WHERE id=@KindId";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter kindParam = new MySqlParameter("@KindId", KindId);
            cmd.Parameters.Add(kindParam);
            cmd.ExecuteReader();
            conn.Close();

        }

        public DataTable KindFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM acckind";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

    }
}
