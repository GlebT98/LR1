using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LR1Console
{
    class Program
    {
       
         static void Main(string[] args)
         {
            while (true)
            {
                float var1 = InputFloat("Число 1");
                float var2 = InputFloat("Число 2");
                float var3 = InputFloat("Число 3");
                Console.WriteLine("Задача: Вычислить дискриминант и найти квадратичные корни");

                Console.WriteLine("Уравнение, введённое вами:" + var1 + "*(x^2) + " + var2 + "*x + " + var3);

                var var4 = var2 * var2 - 4 * var1 * var3;

                Console.WriteLine("А дискриминант у нас равен: " + var4);

                if (var4 < 0)
                {
                    Console.WriteLine("Нет корней... Ведь дискриминант меньше '0'.");
                }
                if (var4 == 0)
                {
                    Console.WriteLine("Дискриминант равен нулю...Значит");
                }

                var x1 = (-var2 - Math.Sqrt(var4)) / (2 * var1);
                var x2 = (-var2 + Math.Sqrt(var4)) / (2 * var1);

                Console.WriteLine("Ответ: х1 = " + x1 + "; x2 = " + x2 + ".");
                

                /*bool var1_error = true;

                while (var1_error == true)
                {
                    Console.Write("Введите число 1  и нажмите Enter: ");
                    String var1 = Console.ReadLine();

                    float var1_float;
                    if (float.TryParse(var1, out var1_float) == true)
                    {
                        Console.WriteLine("Да, это число");
                        Console.WriteLine("Вы ввели значение: " + var1_float.ToString());
                        var1_error = false;
                    }
                    else
                    {
                        Console.WriteLine("Это не число.");
                    }
                }*/


                //Console.WriteLine("Привет, " + name + "!");


                Console.WriteLine("Хотите продолжить? Да - 1, нет - 0.");
                String result = Console.ReadLine();

                if (result == null || result != "1")
                {
                    break;
                }
                else
                {
                    //Console.Clear(); // по желанию можно очистить текст предыдущих вычислений
                }
            }
            
            // Нужна, чтобы консоль не закрылась после выполнения алгоритма. По Enter она закроется.
         }

        static float InputFloat(String name)
        {
            float result = 0;

            bool var1_error = true;

            while (var1_error == true)
            {
                Console.Write("Введите " + name + " и нажмите Enter: ");
                String var1 = Console.ReadLine();
                
                if (float.TryParse(var1, out result) == true)
                {
                    Console.WriteLine("Да, это число");
                    //Console.WriteLine("Вы ввели значение: " + result.ToString());
                    var1_error = false;
                }
                else
                {
                    Console.WriteLine("Это не число.");
                }
            }

           

            return result;
            
        }
    }
}
