﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bank_Accounting
{
    class Client
    {
        //Общие переменные
        public string _userID;
        public string name;
        public string INN;
        public string KPP;
        public string phone_num;
        public string email;
        public string additional;
        public string address;

        //Переменные фмз лиц

        public string nationality;
        public DateTime birth;
        public string document;
        public string serial_num;
        public DateTime date_of_issue;
        public string issuing;

        //Переменные юр. лиц

        public string fullname;
        public string okved;
        public string okpo;
        public string ogrn;
        public string okato;
        public string oktmo;
        public string catcode;
        public string cenral_corr;
        public string acc;
        public string BIK;
        public string bank_name;
        public string bank_addr;
        public string director;
        public string post_addr;

        //Общие управляющие переменные

        static public int RowId;
        static public int FormId;
        static public string ClientType;
        string clientID;
   

        
        // Обновление информации физ. лица
        /*
        public void PhyUpdate()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "UPDATE clients set surname= @surname, name_patronymic= @name_patronymic, birth= @birth, document= @document, serial_num= @serial_num, date_of_issue= @date_of_issue, issuing= @issuing, phone_num= @phone_num, email= @email, INN= @INN, KPP= @KPP, additional= @additional, address= @address WHERE id= @FormID ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlParameter formidParam = new MySqlParameter("FormId", FormId);
            MySqlParameter surnameParam = new MySqlParameter("@surname", surname);
            MySqlParameter patronymicParam = new MySqlParameter("@name_patronymic", name_patronymic);
            MySqlParameter birthParam = new MySqlParameter("@birth", birth);
            MySqlParameter docParam = new MySqlParameter("@document", document);
            MySqlParameter serialParam = new MySqlParameter("@serial_num", serial_num);
            MySqlParameter dateissueParam = new MySqlParameter("@date_of_issue", date_of_issue);
            MySqlParameter issuingParam = new MySqlParameter("@issuing", issuing);
            MySqlParameter phoneParam = new MySqlParameter("@phone_num", phone_num);
            MySqlParameter emailParam = new MySqlParameter("@email", email);
            MySqlParameter INNParam = new MySqlParameter("@INN", INN);
            MySqlParameter kppParam = new MySqlParameter("@KPP", KPP);
            MySqlParameter additionalParam = new MySqlParameter("@additional", additional);
            MySqlParameter addressParam = new MySqlParameter("@address", address);
            cmd.Parameters.Add(formidParam);
            cmd.Parameters.Add(surnameParam);
            cmd.Parameters.Add(patronymicParam);
            cmd.Parameters.Add(birthParam);
            cmd.Parameters.Add(docParam);
            cmd.Parameters.Add(serialParam);
            cmd.Parameters.Add(dateissueParam);
            cmd.Parameters.Add(issuingParam);
            cmd.Parameters.Add(phoneParam);
            cmd.Parameters.Add(emailParam);
            cmd.Parameters.Add(INNParam);
            cmd.Parameters.Add(kppParam);
            cmd.Parameters.Add(additionalParam);
            cmd.Parameters.Add(addressParam);
            cmd.ExecuteReader();
            conn.Close();
        }
                        */
        //Добавление информации физ. лица
        public void PhysSave()
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
            MySqlDataReader reader =  cmd.ExecuteReader();
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
                
        //Заполнение карточки физ. лица из БД
        
        public void PhysFill()
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
        




        // Обновление информации юр. лица
        public void LegalUpdate()
        {

        }

        ////Добавление информации юр. лица
        public void LegalSave()
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

        //Заполнение карточки юр. лица из БД
        public void LegalFill()
        {

        }


    }
}