using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static decimal amountOne1;

        static void Main(string[] args)
        {
            /*
            Задание 2 
            Используя Visual Studio, создайте проект по шаблону Console Application.  
            Представьте, что вы реализуете программу для банка, которая помогает определить, 
            погасил ли клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. 
            Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн. закрыть весь долг.          
            Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка. 
            Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).  
            */
                           

            Console.WriteLine("Введите общую сумму долга...");          
            decimal amountDebt = Convert.ToDecimal(Console.ReadLine());//сумма общей суммы кредита          

            decimal mounthlyPayment = MonthlPyayment(amountDebt);//метод расчета минимальной ежемесячной выплаты

            Console.WriteLine($"Внесите ежемесячный платеж...,сумма должна быть не меньше {mounthlyPayment}");//здесь идет проверка на прием ежемесячной выплаты
            decimal amountContribution = GetAmountContribution(mounthlyPayment);      
            //

            //

            //

            decimal returnCredit = ReturnCredit(mounthlyPayment);//вызываем метод проверки погашения и остатка кредита
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// метод определения минимальной разовой выплаты
        /// </summary>
        /// <param name="amountDebt">общая сумма долга</param>
        /// <returns>месячный платеж</returns>
        static decimal MonthlPyayment(decimal amountDebt)
        {
            return Convert.ToDecimal(amountDebt / 10);//разбиваем общий кредит на сумму минимальной единоразовой выплаты из соотношения 1/10        
        }

        /// <summary>
        /// GetAmountContribution - метод проверки одноразовой выплаты
        /// </summary>
        /// <param name="mounthlyPayment">сумма ежемесячной выплаты</param> 
        /// <returns></returns>
        static decimal GetAmountContribution(decimal mounthlyPayment)
        {
            Console.WriteLine($"Сумма ежемесячной выплаты должна быть не меньше {mounthlyPayment}");
            decimal amountContribution = Convert.ToDecimal(Console.ReadLine());
            while (amountContribution < mounthlyPayment)
            {
                Console.WriteLine($"Сумма не достаточная для ежемесячной выплаты,внесите {mounthlyPayment}р или больше");
                amountContribution = Convert.ToDecimal(Console.ReadLine());
            }
            return amountContribution;
        }    

        static decimal ReturnCredit(decimal mountlyPayment)
        {
            return;
        }
    }
}
