using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounting
{
    interface IClient
    {
         string _userID { get; set; }
         string name { get; set; }
         string INN { get; set; }
         string KPP { get; set; }
         string phone_num { get; set; }
         string email { get; set; }
         string additional { get; set; }
         string address { get; set; }


        //Общие управляющие переменные

         int RowId { get; set; }
         int FormId { get; set; }

         
         string clientID { get; set; }


         
      

        // Обновление информации клиента
         void ClientUpdate();
        


        //Добавление информации клиента в БД
        void ClientSave();
       

        //Заполнение карточки клиента из БД

         void ClientFill();



        //Удаление записей
        void ClientDel();
        
           


    }
}
