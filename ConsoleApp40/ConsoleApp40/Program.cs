using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t1

{

    /*

    * Создайте новый публичный класс Dog в том же файле и том же namespace, что и класс Program.

    * Объявите в классе Dog три переменные: name,age,breed, тип и модификатор доступа переменных определите самостоятельно.

    * Переопределите метод ToString() для класса Dog так, чтобы он выводил информацию об экземпляре класса в следующем формате:

    * "Привет!!! Я собачка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ!".

    * ХХХ - значения соответствующих переменных класса Dog.

    * Внутри метода Main() создайте 4 экземпляра класса Dog используя статическую инициализацию и выведите в консоль информацию

    * по созданным экземплярам, каждый экземпляр с новой строки.

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Dog dog4 = new Dog();
            
            Dog dogod = dog1;
            Dog dogdv = dog2;
            Dog dogtr = dog3;
            Dog dogch = dog4;

            Console.WriteLine(dogod);
            Console.WriteLine(dogdv);
            Console.WriteLine(dogtr);
            Console.WriteLine(dogch);

        }

    }
    public class Dog
    {
        int age;
        string name;
        string breed;
        public override string ToString()

        {

            return $"Привет!!! Я собачка и меня зовут {this.name}!!! Мне {this.age} лет и я отношусь к породе {this.breed}";

        }

    }

    /* Добавьте свой код ниже */

}