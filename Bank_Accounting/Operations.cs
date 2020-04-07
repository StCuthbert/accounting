using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;

namespace Bank_Accounting
{
    class Operations
    {
        static public string ClientName;
        static public int ClientID;
        static public string AccNumber;
        static public int AccountID;
        static public int RateId;
        static public int PaymentId;
        static public string AccCurrency;
        static public string RecieverName;
        static public int RecieverID;
        static public string RecieverAcc;
        static public int RecieverAccID;
        static public int OpId;

        public string HistoryID;
        public DateTime transdate;
        public string _sumoftransaction;
        public string _rate;
        public string _comission;
        public string _totalsum;

        public decimal sumoftransaction;
        public decimal rate;
        public decimal comission;
        public decimal totalsum;
        public decimal newrate;
        public string payment_kind;
        public string typeOp;

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
            

            if(RecieverAccID == 0)
            {
                MySqlParameter acc2IdOpParam = new MySqlParameter("@acc2_id", DBNull.Value);
                cmd.Parameters.Add(acc2IdOpParam);
            }
            else
            {
                MySqlParameter acc2IdOpParam = new MySqlParameter("@acc2_id", RecieverAccID);
                cmd.Parameters.Add(acc2IdOpParam);
            }
            
            //Параметры
            
           
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
            cmd.ExecuteReader();
            conn.Close();
            OpId = 0;

        }
        public void OperationView()
        {
            comission = sumoftransaction / 100 * rate;
            totalsum = sumoftransaction - comission;
            
        }

        public void EnrollFill()
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

            conn.Close();
            OpId = 0;
        }

    }
}
