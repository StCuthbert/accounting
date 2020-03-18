using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounting
{
    class Calculations
    {
        //Счет, с которого производится перевод
        decimal balance1;
        //Счет, на который переводятся средства
        decimal balance2;
        //Сумма перевода
        decimal _sumoftransaction;
        //Сумма комиссии от суммы перевода
        decimal _commission;
        //Процентная ставка комиссии
        decimal rate;
        //Расчетный счет банка, куда будут поступать средства
        decimal bank_own;
        decimal totalsum;
        
        public void Transaction()
        {
           
            //Рассчитываем сумму комиссии
            _commission = _sumoftransaction / 100 * rate;
            //Снимаем со счета сумму перевода и комиссии
            balance1 = balance1 - _sumoftransaction - _commission;
            //Зачисляем сумму перевода на счет
            balance2 = balance2 + _sumoftransaction;
            //Зачисляем сумму комиссии на расчетный счет банка
            bank_own = bank_own + _commission;
            totalsum = _commission + _sumoftransaction;

            
            
          
        
        }
    }
}
