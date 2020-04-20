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
    class Transfer:Operations
    {

        public override void OpSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO history (id, type, sumoftransaction, rate, comission, totalsum, trans_date, acc1_id, acc2_id, kind)" +
                "VALUES(null, @type, @sumoftransaction, @rate, null, null, now(), @acc1_id, @acc2_id, @kind)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);


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

        public override void OpElementFill()
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
            

            conn.Close();
            OpId = 0;
        }
    }
}
