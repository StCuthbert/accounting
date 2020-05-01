using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Bank_Accounting
{
    class Operations
    {
        public string ClientName { get; set; }
        public int ClientID { get; set; }
        public string AccNumber { get; set; }
        public int AccountID { get; set; }
   
       
      //  public string AccCurrency { get; set; }
        public string RecieverName { get; set; }
        public int RecieverID { get; set; }
        public string RecieverAcc { get; set; }
        public int RecieverAccID { get; set; }
        public int OpId { get; set; }

        

        public string HistoryID { get; set; }
        public DateTime transdate { get; set; }
        public string _sumoftransaction { get; set; }
        public string _rate { get; set; }
        public string _comission { get; set; }
        public string _totalsum { get; set; }

        public decimal sumoftransaction { get; set; }
        public decimal rate { get; set; }
        public decimal comission { get; set; }
        public decimal totalsum { get; set; }
      
        public string payment_kind { get; set; }
        public string typeOp { get; set; }

        public DataTable OperationListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM history";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public virtual void OpSave()
        {
            
        }

        public void OpDel()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM history WHERE id= @OpId";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter OpidParam = new MySqlParameter("@OpID", OpId);
            cmd.Parameters.Add(OpidParam);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Close();

            string mysql = "DELETE FROM bank_history WHERE history_id= @OpId";
            MySqlCommand com = new MySqlCommand(mysql, conn);
            com.Parameters.Add(OpidParam);
            com.ExecuteReader();

            conn.Close();
            OpId = 0;

        }
       
        public void OperationView()
        {
            comission = sumoftransaction / 100 * rate;
            totalsum = sumoftransaction - comission;
        }

        public virtual void OpElementFill()
        {
            
        }

    }
}
