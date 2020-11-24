using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t14

{

    /*

    * Внутри метода Main() реализуйте программу, которая:

    * 1) Считывает целое число N, введенное с клавиатуры.

    * 2) Считывает N раз целые числа, введенные с клавиатуры.

    * 3) Выводит на экран наименьшее из введенных чисел (число N не должно учитываться).

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            int b = 0;
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < b)
                {
                    b = a;
                }
                
            }
            Console.WriteLine(b);

        }

    }

}