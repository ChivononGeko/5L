using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l5t21
{
    /*
    * Для класса Human, создайте конструктор, который бы принимал имя, возраст и профессию человека и инициализировал полученными значениями соответствующие поля класса.
    * Переопределите метод ToString для класса Human, таким образом, чтобы:
    * 1) Он выводил строку "Привет, меня зовут ХХХ, мне ХХХ лет и по профессии я: ХХХ!".
    * 2) Если значение возраста меньше либо равно нулю, то выводил строку "Привет, меня зовут ХХХ, я скрываю свой возраст, потому что по профессии я: ХХХ!".
    * 3) Если значение имени null или пустая строка, то выводил строку "Привет, я скрываю своё имя, но мне ХХХ лет и я работаю по профессии: ХХХ!".
    * 4) Если значение профессии null или пустая строка, то выводил строку "Привет, меня зовут ХХХ, мне ХХХ лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!".
    * 5) Если значения возраста и профессии пустые или некорректные, то выводил строку "Меня зовут ХХХ!"
    * 6) Если значения имени и возраста пустые или некорректные, то выводил строку "Моя профессия ХХХ!".
    * 7) Если значения имени и профессии пустые, то выводил строку "Мне ХХХ лет!".
    * 8) Если все значения пустые или некорректные, то выводил строку "Я аноним!".
    * Шаблон задачи изменять нельзя.
    */
    public class Human
    {
        private string name;
        private int age;
        private string profession;
        /* Добавьте свой код ниже */
        public static void Main(string[] args)
        {
            Console.WriteLine(new Human(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine()));
        }
        /* Добавьте свой код ниже */
        public Human(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }
        public override string ToString()
        {
            if (this.name == null)
            {
                if (this.age > 0)
                {
                    if (this.profession == null)
                    {
                        return $"Мне {this.age} лет!";
                    }
                    else
                    {
                        return $"Привет, я скрываю своё имя, но мне {this.age} лет и я работаю по профессии: {this.profession}!";
                    }
                }
                else
                {
                    if (this.profession == null)
                    {
                        return $"Я аноним!";
                    }
                    else
                    { 
                        return $"Моя профессия {this.profession}!";
                    }
                }
            }
            else
            {
                if (this.age > 0)
                {
                    if (this.profession == null)
                    {
                        return $"Привет, меня зовут {this.name}, мне {this.age} лет, у меня пока нет профессии, но скоро я стану .Net программистом!!!";
                    }
                    else
                    {
                        return $"Привет, меня зовут {this.name}, мне {this.age} лет и по профессии я: {this.profession}!";
                    }
                }
                else
                {
                    if (this.profession == null)
                    {
                        return $"Меня зовут {this.name}!";
                    }
                    else
                    {
                        return $"Привет, меня зовут {this.name}, я скрываю свой возраст, потому что по профессии я: {this.profession}!";
                    }
                }
               
            }
        }
    }
    
}