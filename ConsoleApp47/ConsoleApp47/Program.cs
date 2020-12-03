using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t5

{

    /*

    * Реализуйте класс Dog таким образом, чтобы он мог инициализироваться при помощи следующих конструкторов:

    * 1) Имя.

    * 2) Имя, вес и возраст.

    * 3) Имя и возраст.

    * 4) Вес, цвет.

    * 5) Вес, цвет и адрес.

    *  и

    * инициализируйте их произвольными значениями в каждом из созданных конструкторов.

    * Все элементы класса должны быть публичными.

    */

    public class Dog

    {

        /* Добавьте свой код ниже */
        string name;
        int weight;
        int age;
        string color;
        string address;
        public Dog(string name)
        { this.name = name;  }
        public Dog(string name, int weight,int age)
        { this.name = name; this.age = age; this.weight = weight; }
        public Dog(string name, int age)
        { this.name = name; this.age = age; }
        public Dog(int weight, string color)
        { this.weight = weight; this.color = color; }
        public Dog(int weight, string color, string address)
        { this.weight = weight; this.color = color; this.address = address; }
        public override string ToString()

        {

            return $"{this.name}:{this.age}:{this.weight}:{this.address}:{this.color}";

        }

        public static void Main(string[] args)

        {
            Dog dog1 = new Dog("Genri");
            Dog dog2 = new Dog("Bobi", 12, 43);
            Dog dog3 = new Dog("Teo", 11);
            Dog dog4 = new Dog(34,"Green");
            Dog dog5 = new Dog(52, "Black","221B");
            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);
            Console.WriteLine(dog4);
            Console.WriteLine(dog5);
        }

    }



}