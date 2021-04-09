using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace l5t34
{
    /*
    * Создайте статический конструктор для класса Program, который должен выводить в консоль
    * число 8 в 10 степени, с использованием метода Pow() статического класса Math.
    */
    public class Program
    {
        /* Добавьте свой код ниже */
        static Program()
        {
            int a = Convert.ToInt32(Math.Pow(8, 10));
        }
        public static void Main(string[] args)
        {
        }
    }
}