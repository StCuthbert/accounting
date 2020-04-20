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
    class PhysClient:Client
    {
        public string nationality { get; set; }
        public DateTime birth { get; set; }
        public string document { get; set; }
        public string serial_num { get; set; }
        public DateTime date_of_issue { get; set; }
        public string issuing { get; set; }

        public override void ClientUpdate()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "UPDATE clients, physclients SET clients.name= @name, clients.INN= @INN, clients.KPP= @KPP, clients.phone_num= @phone_num, clients.email= @email, clients.addinform= @additional, clients.address= @address, physclients.nationality= @nationality, physclients.birth= @birth, physclients.document= @document, physclients.serial_num= @serial_num, physclients.date_of_issue= @date_of_issue, physclients.issuing= @issuing WHERE clients.id= @FormId AND physclients.client_id= @FormId ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlParameter FormIdParam = new MySqlParameter("@FormId", FormId);
            MySqlParameter nameParam = new MySqlParameter("@name", name);
            MySqlParameter INNParam = new MySqlParameter("@INN", INN);
            MySqlParameter kppParam = new MySqlParameter("@KPP", KPP);
            MySqlParameter phoneParam = new MySqlParameter("@phone_num", phone_num);
            MySqlParameter emailParam = new MySqlParameter("@email", email);
            MySqlParameter additionalParam = new MySqlParameter("@additional", additional);
            MySqlParameter addressParam = new MySqlParameter("@address", address);

            MySqlParameter nationParam = new MySqlParameter("@nationality", nationality);
            MySqlParameter birthParam = new MySqlParameter("@birth", birth);
            MySqlParameter docParam = new MySqlParameter("@document", document);
            MySqlParameter serialParam = new MySqlParameter("@serial_num", serial_num);
            MySqlParameter dateissueParam = new MySqlParameter("@date_of_issue", date_of_issue);
            MySqlParameter issuingParam = new MySqlParameter("@issuing", issuing);

            cmd.Parameters.Add(FormIdParam);
            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(INNParam);
            cmd.Parameters.Add(kppParam);
            cmd.Parameters.Add(phoneParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(additionalParam);
            cmd.Parameters.Add(addressParam);

            cmd.Parameters.Add(nationParam);
            cmd.Parameters.Add(birthParam);
            cmd.Parameters.Add(docParam);
            cmd.Parameters.Add(serialParam);
            cmd.Parameters.Add(dateissueParam);
            cmd.Parameters.Add(issuingParam);
            cmd.ExecuteReader();
            conn.Close();
        }

        public override void ClientSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string typephys = "физическое";
            string sql = "INSERT INTO clients (id, Name, INN, KPP, phone_num, email, addinform, address, type )" +
                "VALUES(null, @name, @INN, @KPP, @phone_num, @email, @additional, @address, @typephys)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter nameParam = new MySqlParameter("@name", name);
            MySqlParameter INNParam = new MySqlParameter("@INN", INN);
            MySqlParameter kppParam = new MySqlParameter("@KPP", KPP);
            MySqlParameter phoneParam = new MySqlParameter("@phone_num", phone_num);
            MySqlParameter emailParam = new MySqlParameter("@email", email);
            MySqlParameter additionalParam = new MySqlParameter("@additional", additional);
            MySqlParameter addressParam = new MySqlParameter("@address", address);
            MySqlParameter typephysParam = new MySqlParameter("@typephys", typephys);

            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(INNParam);
            cmd.Parameters.Add(kppParam);
            cmd.Parameters.Add(phoneParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(additionalParam);
            cmd.Parameters.Add(addressParam);
            cmd.Parameters.Add(typephysParam);



            //Закрываем ридер
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Close();


            string sqltxt = "SELECT LAST_INSERT_ID()";
            MySqlCommand comm = new MySqlCommand(sqltxt, conn);
            clientID = comm.ExecuteScalar().ToString();



            string sqltext = "INSERT INTO physclients (id, nationality, birth, document, serial_num, date_of_issue, issuing, client_id )" +
                 "VALUES(null, @nationality, @birth, @document, @serial_num, @date_of_issue, @issuing, @clientID)";

            MySqlCommand comnd = new MySqlCommand(sqltext, conn);

            MySqlParameter nationParam = new MySqlParameter("@nationality", nationality);
            MySqlParameter birthParam = new MySqlParameter("@birth", birth);
            MySqlParameter docParam = new MySqlParameter("@document", document);
            MySqlParameter serialParam = new MySqlParameter("@serial_num", serial_num);
            MySqlParameter dateissueParam = new MySqlParameter("@date_of_issue", date_of_issue);
            MySqlParameter issuingParam = new MySqlParameter("@issuing", issuing);
            MySqlParameter clientIDParam = new MySqlParameter("@clientID", clientID);
            comnd.Parameters.Add(nationParam);
            comnd.Parameters.Add(birthParam);
            comnd.Parameters.Add(docParam);
            comnd.Parameters.Add(serialParam);
            comnd.Parameters.Add(dateissueParam);
            comnd.Parameters.Add(issuingParam);
            comnd.Parameters.Add(clientIDParam);
            comnd.ExecuteReader();

            conn.Close();
        }

        public override void ClientFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM clients JOIN physclients WHERE clients.id = @RowID AND physclients.client_id = @RowID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlParameter rowidParam = new MySqlParameter("@RowID", RowId);
            cmd.Parameters.Add(rowidParam);


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        _userID = Convert.ToString(reader.GetValue(0));
                        name = reader.GetString(1);
                        INN = reader.GetString(2);
                        KPP = reader.GetString(3);
                        phone_num = reader.GetString(4);
                        email = reader.GetString(5);
                        additional = reader.GetString(6);
                        address = reader.GetString(7);
                        nationality = reader.GetString(10);
                        birth = reader.GetDateTime(11);
                        document = reader.GetString(12);
                        serial_num = reader.GetString(13);
                        date_of_issue = reader.GetDateTime(14);
                        issuing = reader.GetString(15);

                    }


                }
            }

            conn.Close();
            RowId = 0;
        }
    }
}
