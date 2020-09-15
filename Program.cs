using System;
using System.Diagnostics.CodeAnalysis;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)

        {
            try { Calculate(); }
            catch (Exception)
            {

                Console.WriteLine("Невозможно выполнить операцию");
                Calculate();
            }
            

            void Calculate()
            {

                Console.WriteLine("Введите число,оператор,число и мы подсчитаем");
                double first = Convert.ToDouble(Console.ReadLine());
                string operato = (Console.ReadLine());
                double second = Convert.ToDouble(Console.ReadLine());

                if (operato == "+")
                {
                    Console.WriteLine("Сумма:" + first + second);
                }
                else if (operato == "-")
                {
                    Console.WriteLine("Разность:" + (first - second));
                }
                else if (operato == "*")
                {
                    Console.WriteLine("Произведение:" + (first * second));
                }

                else if (operato == "/")
                {
                    Console.WriteLine("Частное:" + (first / second));
                }
                else
                {
                    Console.WriteLine("Введите верный оператор!");

                }



                Calculate();
                
                
                 
                

            }




        }
    }
}



//После запуска программы меня приветсвовала программа, затем спросии число 1 и число 2
//введите число, оператор, число и мы подсчитаем)
//
//+, -, * , / - математические операторы
//
//
//
//try{ код}catch(Исключение или ключевое слово Exception){Код после исключения}
//
//
//
//
//
//
//