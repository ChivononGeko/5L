using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t15

{

    /*

    * Внутри метода Main() создайте программу, которая считывает 5 чисел с клавиатуры

    * и выводит в консоль наименьшее из них.

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            int b = 0;
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a<b)
                {
                    b = a;
                }
            }
            Console.WriteLine(b);

        }

    }

}