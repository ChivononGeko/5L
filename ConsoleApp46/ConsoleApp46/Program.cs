using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t4

{

    /*

    * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program.

    * В классе Cat создайте 4 переменные, которые будут отвечать за: имя(name), возраст(age), пол(gender) и владельца кота(owner).

    * Имена, типы переменных и модификатор доступа переменных и классов определите самостоятельно.

    * Создайте конструкторы класса Cat, которые принимают в себя:

    * 1) Имя.

    * 2) Имя и возраст.

    * 3) Имя и возраст и пол.

    * Созданные конструкторы должны инициализировать значениями все переменные класса.

    * Значения для инициализации по умолчанию: возраст - 1; пол - true, владелец - новый экземпляр класса Human.

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            Cat cat1 = new Cat("Barsik");
            Cat cat2 = new Cat("Bobik", 1);
            Cat cat3 = new Cat("Viva", 1, true);
            Console.WriteLine(Cat.count);

            Console.WriteLine(cat1);

            Console.WriteLine(cat2);

            Console.WriteLine(cat3);

        }

    }
    public class Cat
    {
        public string name;
        public int age;
        public bool gender;
        public static int count = 0;
        public Cat(string name)
        {
            this.name = name;
            count++ ;

        }
        public Cat(string name, int age)
        {
            count++;
            this.name = name;
            this.age = age;
            count++;
        }
        public Cat(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            count++;
        }
        public override string ToString()

        {
            Human human = new Human();
            return $"{this.name}:{this.age}:{this.gender}:{human.owner}";

        }
    }
    public class Human
    {
       public string owner = "Ron";
    }

}