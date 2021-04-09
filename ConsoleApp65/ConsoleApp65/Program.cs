using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace l5t8
{
    /*
    * Реализуйте перечисление MyFavoritePets, которое должно содержать как минимум 4 элемента,
    * каждый из которых должен олицетворять названия ваших любимых домашних животных.
    * Реализуйте класс Animal, который должен содержать:
    * 1) Четыре поля класса: возраст, вес, скорость и тип.
    * 2) 1 конструктор, который принимает только тип животного.
    * Конструктор класса, должен инициализировать все недостающие поля класса, на основе переданного типа.
    * Все инициализированные в конструкторе поля класса должны иметь значения, отличные от значений по умолчанию.
    * Все элементы класса должны быть публичными.
    */
    public class Animal
    {
        /* Добавьте свой код ниже */
        public int age;
        public int weight;
        public int speed;
        public MyFavoritePets type;
        public Animal(MyFavoritePets type)
        {
             
            if (type == MyFavoritePets.Koshka)
            {
                this.age = 7;
                this.weight = 12;
                this.speed = 5;
            }
            else if (type == MyFavoritePets.Sobaka)
            {
                this.age = 9;
                this.weight = 24;
                this.speed = 15;
            }
            else if (type == MyFavoritePets.PopugGAY)
            {
                this.age = 2;
                this.weight = 1;
                this.speed = 10;
            }
            else if (type == MyFavoritePets.Homyak)
            {
                this.age = 1;
                this.weight = 2;
                this.speed = 2;
            }
        }
        public override string ToString()
        {
            return $"Age={this.age}  speed={this.speed}  Weight={this.weight} ";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(new Animal(MyFavoritePets.Koshka));
            Console.WriteLine(new Animal(MyFavoritePets.Sobaka));
            Console.WriteLine(new Animal(MyFavoritePets.PopugGAY));
            Console.WriteLine(new Animal(MyFavoritePets.Homyak));
        }
    }
    public enum MyFavoritePets:int
    {
        /* Добавьте свой код ниже */
        Koshka,
        Sobaka,
        PopugGAY,
        Homyak
    }

}