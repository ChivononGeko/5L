using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace l5t2
{
    /*
    * Создайте новый публичный класс Bird в том же файле и том же namespace, что и класс Program.    * Объявите в классе Bird четыре переменные: name, age, breed, continent.
    * Переменная continent должна являться публичным перечислением, содержащим все существующие на текущий момент континенты.
    * Перечисление должно быть объявлено в том же файле и том же namespace, что и класс Program.
    * Тип и модификатор доступа остальных переменных определите самостоятельно.
    * Переопределите метод ToString() для класса Bird так, чтобы он выводил информацию об экземпляре класса в следующем формате:
    * "Привет!!! Я птичка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ, которая водится на континенте: ХХХ!".
    * ХХХ - значения соответствующих переменных класса Bird.
    * Внутри метода Main() создайте 2 экземпляра класса Bird используя статическую инициализацию и выведите в консоль информацию
    * по созданным экземплярам, каждый экземпляр с новой строки.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(new Bird(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine()));
        }
    }
    /* Добавьте свой код ниже */
    public class Bird
    {
        string name;
        int age;
        string breed;
        Continent continent;
        public Bird(string name,int age,string breed,string continent)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
            if (continent=="Eurasia")
            {
                this.continent = Continent.Eurasia;
            }
            else if (continent == "Africa")
            {
                this.continent = Continent.Africa;
            }
            else if (continent == "South America")
            {
                this.continent = Continent.SouthAmerica;
            }
            else if (continent == "North America")
            {
                this.continent = Continent.NorthAmerica;
            }
            else if (continent == "Antarctida")
            {
                this.continent = Continent.Antarctida;
            }
            else if (continent == "Australia")
            {
                this.continent = Continent.Australia;
            }
            else
            {
                Console.WriteLine("Idi study Gegrafiy");
                Console.WriteLine(new Bird(Console.ReadLine(),int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine()));
            }
        }
        public override string ToString()
        {
            return $"Привет!!! Я птичка и меня зовут {name}!!! Мне {age} лет и я отношусь к породе: {breed}, которая водится на континенте: {continent}!";
        }
    }

    public enum Continent
    {
        Eurasia = 1,
        Africa,
        SouthAmerica,
        NorthAmerica,
        Antarctida,
        Australia
    }
}