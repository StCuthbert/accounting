using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bank_Accounting
{
    class Client
    {
        //Общие переменные
        public string _userID { get; set; }
        public string name { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string phone_num { get; set; }
        public string email { get; set; }
        public string additional { get; set; }
        public string address { get; set; }
         

        //Общие управляющие переменные

        static  public int RowId { get; set; }
        static public int FormId { get; set; }

        static public string ClientType { get; set; }
        public string clientID { get; set; }

        
        // Заполнение списка клиентов информацией из БД
        public DataTable ClientListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM clients";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        // Обновление информации клиента
        public virtual void ClientUpdate()
        {
           
        }
        

        //Добавление информации клиента в БД
        public virtual void ClientSave()
        {
                        
        }
                
        //Заполнение карточки клиента из БД
        
        public virtual void ClientFill()
        {
            
           
        }


        //Удаление записей
        public void ClientDel()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM clients WHERE id= @RowID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter rowidParam = new MySqlParameter("@RowID", RowId);
            cmd.Parameters.Add(rowidParam);
            cmd.ExecuteReader();
            conn.Close();
            RowId = 0;
        }
        
        
    }
        
}