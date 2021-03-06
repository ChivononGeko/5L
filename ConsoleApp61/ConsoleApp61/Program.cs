﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l5t30
{
    /*
    * Реализуйте класс Bird таким образом, чтобы:
    * 1) Он имел 3 автоматических свойства: Name, Age, Speed.
    * 2) Свойства Age и Speed имели стартовые значения равные 100.
    * Добавьте в класс Bird публичный метод ChangeObject(), который:
    * 1) Принимает строку-имя в качестве входящего параметра.
    * 2) Устанавливает значение Age равное 50, если полученная строка начинается с заглавной буквы.
    * 3) Устанавливает значение Speed 10, если полученная строка заканчивается заглавной буквой.
    * 4) Умножает значение Age на 2, если полученная строка заканчивается цифрой.
    */
    public class Bird
    {
        /* Добавьте свой код ниже */
        
        public string Name { get; set; }
        public int Age { get; set; } = 100;
        public int Speed { get; set; } = 100;        
        public void ChangeObject(string name)
        {
            Name = name;
            if (Name[0]==Name.ToUpper()[0])
            {
                Age = 50;
                Console.WriteLine(Age);
            }
            for (int i = 0; i < Name[i]; i++)
            {
                if (Name[i] ==Name.ToUpper()[i])
                {
                    Speed = 10;
                }
                int a;
                if (int.TryParse(Name[i], out a))
                {
                    Age *=2;
                }
               
            }
        }
        public static void Main(string[] args)
        {
            
            Bird bird = new Bird();
            bird.ChangeObject("ads");
            int age = bird.Age;
            int speed=bird.Speed;
            Console.WriteLine(age+speed);
        }
    }
}