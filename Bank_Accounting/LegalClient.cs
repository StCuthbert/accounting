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
    class LegalClient:Client
    {
        public string fullname { get; set; }
        public string okved { get; set; }
        public string okpo { get; set; }
        public string ogrn { get; set; }
        public string okato { get; set; }
        public string oktmo { get; set; }
        public string catcode { get; set; }
        public string cenral_corr { get; set; }
        public string acc { get; set; }
        public string BIK { get; set; }
        public string bank_name { get; set; }
        public string bank_addr { get; set; }
        public string director { get; set; }
        public string post_addr { get; set; }


        public override void ClientUpdate()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "UPDATE clients, legalclients SET clients.name= @name, clients.INN= @INN, clients.KPP= @KPP, clients.phone_num= @phone_num, clients.email= @email, clients.addinform= @additional, clients.address= @address, legalclients.fullname= @fullname, legalclients.okved= @okved, legalclients.okpo= @okpo, legalclients.ogrn= @ogrn, legalclients.okato= @okato, legalclients.oktmo= @oktmo, legalclients.code= @catcode, legalclients.central_corr= @cenral_corr, legalclients.acc= @acc, legalclients.BIK= @BIK, legalclients.bank_name= @bank_name, legalclients.bank_addr= @bank_addr, legalclients.director= @director, legalclients.post_addr= @post_addr WHERE clients.id= @FormId AND legalclients.client_id= @FormId ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlParameter FormIdParam = new MySqlParameter("@FormId", FormId);
            MySqlParameter nameParam = new MySqlParameter("@name", name);
            MySqlParameter INNParam = new MySqlParameter("@INN", INN);
            MySqlParameter kppParam = new MySqlParameter("@KPP", KPP);
            MySqlParameter phoneParam = new MySqlParameter("@phone_num", phone_num);
            MySqlParameter emailParam = new MySqlParameter("@email", email);
            MySqlParameter additionalParam = new MySqlParameter("@additional", additional);
            MySqlParameter addressParam = new MySqlParameter("@address", address);

            MySqlParameter fullnameParam = new MySqlParameter("@fullname", fullname);
            MySqlParameter okvedParam = new MySqlParameter("@okved", okved);
            MySqlParameter okpoParam = new MySqlParameter("@okpo", okpo);
            MySqlParameter ogrnParam = new MySqlParameter("@ogrn", ogrn);
            MySqlParameter okatoParam = new MySqlParameter("@okato", okato);
            MySqlParameter oktmoParam = new MySqlParameter("@oktmo", oktmo);
            MySqlParameter catcodeParam = new MySqlParameter("@catcode", catcode);
            MySqlParameter cenral_corrParam = new MySqlParameter("@cenral_corr", cenral_corr);
            MySqlParameter accParam = new MySqlParameter("@acc", acc);
            MySqlParameter BIKParam = new MySqlParameter("@BIK", BIK);
            MySqlParameter bank_nameParam = new MySqlParameter("@bank_name", bank_name);
            MySqlParameter bank_addrParam = new MySqlParameter("@bank_addr", bank_addr);
            MySqlParameter directorParam = new MySqlParameter("@director", director);
            MySqlParameter post_addrParam = new MySqlParameter("@post_addr", post_addr);

            cmd.Parameters.Add(fullnameParam);
            cmd.Parameters.Add(okvedParam);
            cmd.Parameters.Add(okpoParam);
            cmd.Parameters.Add(ogrnParam);
            cmd.Parameters.Add(okatoParam);
            cmd.Parameters.Add(oktmoParam);
            cmd.Parameters.Add(catcodeParam);
            cmd.Parameters.Add(cenral_corrParam);
            cmd.Parameters.Add(accParam);
            cmd.Parameters.Add(BIKParam);
            cmd.Parameters.Add(bank_nameParam);
            cmd.Parameters.Add(bank_addrParam);
            cmd.Parameters.Add(directorParam);
            cmd.Parameters.Add(post_addrParam);




            cmd.Parameters.Add(FormIdParam);
            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(INNParam);
            cmd.Parameters.Add(kppParam);
            cmd.Parameters.Add(phoneParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(additionalParam);
            cmd.Parameters.Add(addressParam);


            cmd.ExecuteReader();
            conn.Close();
        }

        public override void ClientSave()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string typelegal = "юридическое";
            string sql = "INSERT INTO clients (id, Name, INN, KPP, phone_num, email, addinform, address, type )" +
                "VALUES(null, @name, @INN, @KPP, @phone_num, @email, @additional, @address, @typelegal)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //Параметры
            MySqlParameter nameParam = new MySqlParameter("@name", name);
            MySqlParameter INNParam = new MySqlParameter("@INN", INN);
            MySqlParameter kppParam = new MySqlParameter("@KPP", KPP);
            MySqlParameter phoneParam = new MySqlParameter("@phone_num", phone_num);
            MySqlParameter emailParam = new MySqlParameter("@email", email);
            MySqlParameter additionalParam = new MySqlParameter("@additional", additional);
            MySqlParameter addressParam = new MySqlParameter("@address", address);
            MySqlParameter typelegalParam = new MySqlParameter("@typelegal", typelegal);

            cmd.Parameters.Add(nameParam);
            cmd.Parameters.Add(INNParam);
            cmd.Parameters.Add(kppParam);
            cmd.Parameters.Add(phoneParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(additionalParam);
            cmd.Parameters.Add(addressParam);
            cmd.Parameters.Add(typelegalParam);

            //Закрываем ридер
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Close();


            string sqltxt = "SELECT LAST_INSERT_ID()";
            MySqlCommand comm = new MySqlCommand(sqltxt, conn);
            clientID = comm.ExecuteScalar().ToString();




            string sqltext = "INSERT INTO legalclients (id, fullname, okved, okpo, ogrn, okato, oktmo, code, central_corr, acc, BIK, bank_name, bank_addr, director, post_addr, client_id )" +
                 "VALUES(null, @fullname, @okved, @okpo, @ogrn, @okato, @oktmo, @catcode, @cenral_corr, @acc, @BIK, @bank_name, @bank_addr, @director, @post_addr, @clientID)";

            MySqlCommand comnd = new MySqlCommand(sqltext, conn);

            MySqlParameter fullnameParam = new MySqlParameter("@fullname", fullname);
            MySqlParameter okvedParam = new MySqlParameter("@okved", okved);
            MySqlParameter okpoParam = new MySqlParameter("@okpo", okpo);
            MySqlParameter ogrnParam = new MySqlParameter("@ogrn", ogrn);
            MySqlParameter okatoParam = new MySqlParameter("@okato", okato);
            MySqlParameter oktmoParam = new MySqlParameter("@oktmo", oktmo);
            MySqlParameter catcodeParam = new MySqlParameter("@catcode", catcode);
            MySqlParameter cenral_corrParam = new MySqlParameter("@cenral_corr", cenral_corr);
            MySqlParameter accParam = new MySqlParameter("@acc", acc);
            MySqlParameter BIKParam = new MySqlParameter("@BIK", BIK);
            MySqlParameter bank_nameParam = new MySqlParameter("@bank_name", bank_name);
            MySqlParameter bank_addrParam = new MySqlParameter("@bank_addr", bank_addr);
            MySqlParameter directorParam = new MySqlParameter("@director", director);
            MySqlParameter post_addrParam = new MySqlParameter("@post_addr", post_addr);
            MySqlParameter clientIDParam = new MySqlParameter("@clientID", clientID);
            comnd.Parameters.Add(fullnameParam);
            comnd.Parameters.Add(okvedParam);
            comnd.Parameters.Add(okpoParam);
            comnd.Parameters.Add(ogrnParam);
            comnd.Parameters.Add(okatoParam);
            comnd.Parameters.Add(oktmoParam);
            comnd.Parameters.Add(catcodeParam);
            comnd.Parameters.Add(cenral_corrParam);
            comnd.Parameters.Add(accParam);
            comnd.Parameters.Add(BIKParam);
            comnd.Parameters.Add(bank_nameParam);
            comnd.Parameters.Add(bank_addrParam);
            comnd.Parameters.Add(directorParam);
            comnd.Parameters.Add(post_addrParam);
            comnd.Parameters.Add(clientIDParam);
            comnd.ExecuteReader();

            conn.Close();
        }

        public override void ClientFill()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT * FROM clients JOIN legalclients WHERE clients.id = @RowID AND legalclients.client_id = @RowID";
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


                        fullname = reader.GetString(10);
                        okved = reader.GetString(11);
                        okpo = reader.GetString(12);
                        ogrn = reader.GetString(13);
                        okato = reader.GetString(14);
                        oktmo = reader.GetString(15);
                        catcode = reader.GetString(16);
                        cenral_corr = reader.GetString(17);
                        acc = reader.GetString(18);
                        BIK = reader.GetString(19);
                        bank_name = reader.GetString(20);
                        bank_addr = reader.GetString(21);
                        director = reader.GetString(22);
                        post_addr = reader.GetString(23);



                    }


                }
            }

            conn.Close();
            RowId = 0;
        }
    }
}
