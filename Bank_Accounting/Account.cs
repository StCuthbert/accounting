using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounting
{
    class Account
    {


        int id;
        //Номер счета 20 знаков
        string acc_number;
        //Наименование банка
        string bank_name;
        //БИК 
        string BIK;
        //Корреспондентский счет Центрального Банка РФ
        string centralbank_corr;
        //Вид счета
        string kind;
        //Валюта счета
        string currency;
        //Баланс счета
        decimal balance;
    }
    
}
