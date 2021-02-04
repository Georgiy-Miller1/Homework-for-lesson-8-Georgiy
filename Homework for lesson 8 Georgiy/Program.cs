using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_for_lesson_8_Georgiy
{
    class Program
    {
        static  void Method(ref int a,ref int b,ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
           
        }
        static void Main(string[] args)
        {
            /*
            Задание 
            Используя Visual Studio, создайте проект по шаблону Console Application.  
            Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных значения 
            и возвращает значение каждого аргумента деленного на 5.  
            */
            int a = 0;
            int b = 0;
            int c = 0;
            Console.WriteLine("Введите первое число...");
            a = Convert.ToInt32(Console.ReadLine());//вводим первое число

            Console.WriteLine("Введите второе число...");
            b = Convert.ToInt32(Console.ReadLine());//вводим второе число

            Console.WriteLine("Введите третье число...");
            c = Convert.ToInt32(Console.ReadLine());//вводим третее число

            Method(ref a,ref b,ref c);
            Console.WriteLine($"{a},{b},{c}");
            Console.ReadKey();
        }
    }
}
