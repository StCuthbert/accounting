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
        static public string ClientName { get; set; }
        static public int ClientID { get; set; }
        static public string AccNumber { get; set; }
        static public int AccountID { get; set; }
        static public int RateId { get; set; }
        static public int PaymentId { get; set; }
        static public string AccCurrency { get; set; }
        static public string RecieverName { get; set; }
        static public int RecieverID { get; set; }
        static public string RecieverAcc { get; set; }
        static public int RecieverAccID { get; set; }
        static public int OpId { get; set; }

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
        public decimal newrate { get; set; }
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

        public DataTable BankopListFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM bank_history";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            var dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            return dt;
        }

        public void PaymentSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO payment_purpose (id, kind)" +
                "VALUES(null, @kind)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter paymentParam = new MySqlParameter("@kind", payment_kind);


            cmd.Parameters.Add(paymentParam);
            cmd.ExecuteReader();
            conn.Close();
        }

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

        public void RateSave()
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO rates (id, rate)" +
                "VALUES(null, @newrate)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter newrateParam = new MySqlParameter("@newrate", newrate);
           

            cmd.Parameters.Add(newrateParam);
            cmd.ExecuteReader();
            conn.Close();

        }

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

        public void OpSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO history (id, type, sumoftransaction, rate, comission, totalsum, trans_date, acc1_id, acc2_id, kind)" +
                "VALUES(null, @type, @sumoftransaction, @rate, null, null, now(), @acc1_id, @acc2_id, @kind)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            /*
            if(RecieverAccID == 0)
            {
                MySqlParameter acc2IdOpParam = new MySqlParameter("@acc2_id", 0);
                cmd.Parameters.Add(acc2IdOpParam);
            }
            else
            {
                MySqlParameter acc2IdOpParam = new MySqlParameter("@acc2_id", RecieverAccID);
                cmd.Parameters.Add(acc2IdOpParam);
            }
            */
            //Параметры

            MySqlParameter acc2IdOpParam = new MySqlParameter("@acc2_id", RecieverAccID);
            MySqlParameter typeOpParam = new MySqlParameter("@type", typeOp);
            MySqlParameter sumtransParam = new MySqlParameter("@sumoftransaction", sumoftransaction);
            MySqlParameter rateOpParam = new MySqlParameter("@rate", rate);
            MySqlParameter accIdOpParam = new MySqlParameter("@acc1_id", AccountID);
            
            MySqlParameter kindOpParam = new MySqlParameter("@kind", payment_kind);


            cmd.Parameters.Add(typeOpParam);
            cmd.Parameters.Add(sumtransParam);
            cmd.Parameters.Add(rateOpParam);
            cmd.Parameters.Add(accIdOpParam);
            cmd.Parameters.Add(kindOpParam);
            cmd.Parameters.Add(acc2IdOpParam);
            cmd.ExecuteReader();
            conn.Close();
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

        public void OpElementFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM history JOIN accounts ON(accounts.id = history.acc1_id) JOIN clients ON(clients.id = accounts.client) WHERE history.id = @OpID ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter OpidParam = new MySqlParameter("@OpID", OpId);
            cmd.Parameters.Add(OpidParam);


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        HistoryID = Convert.ToString(reader.GetValue(0));
                        _sumoftransaction = Convert.ToString(reader.GetValue(2));
                        _rate = Convert.ToString(reader.GetValue(3));
                        _comission = Convert.ToString(reader.GetValue(4));
                        _totalsum = Convert.ToString(reader.GetValue(5));
                        transdate = reader.GetDateTime(6);
                        AccountID = Convert.ToInt32(reader.GetValue(7));
                        payment_kind = reader.GetString(9);
                        AccNumber = reader.GetString(11);
                        ClientID = Convert.ToInt32(reader.GetValue(19));
                        ClientName = reader.GetString(20);


                        
                    }
                   

                }
            }

            if (typeOp == "перевод")
            {
                string mysql = "SELECT * FROM history JOIN accounts ON(accounts.id = history.acc2_id) JOIN clients ON(clients.id = accounts.client) WHERE history.id = @OpID ";
                MySqlCommand com = new MySqlCommand(mysql, conn);
                com.Parameters.Add(OpidParam);

                using (DbDataReader reader = com.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {


                            RecieverAccID = Convert.ToInt32(reader.GetValue(7));
                            RecieverAcc = reader.GetString(11);
                            RecieverID = Convert.ToInt32(reader.GetValue(19));
                            RecieverName = reader.GetString(20);



                        }


                    }
                }
            }

            conn.Close();
            OpId = 0;
        }

    }
}
