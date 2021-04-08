using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l5t12
{
    /*
    * Реализуйте класс Human таким образом, чтобы он содержал 3 свойства:
    * 1) Имя.
    * 2) Профессия.
    * 3) Возраст.
    * Добавьте в класс Human конструктор, который принимает имя, а устанавливает и имя, и возраст, и профессию.
    * Сделайте так, чтобы профессию и возраст нельзя было изменить.
    * Переопределите метод ToString() для класса Human, так чтобы на экран выводилась информация об
    * экземпляре класса в следующем формате:
    * "Имя: ХХХ"
    * "Возраст: ХХХ"
    * "Профессия: ХХХ"
    * ХХХ - значения соответствующих полей экземпляров класса Human.
    */
    public class Human
    {
        /* Добавьте свой код ниже */
        public string name;
        private string profession;
        private int age;
        public string Profession { get; private set; }
        public int Age { get; private set; }
        public static void Main(string[] args)
        {
            Console.WriteLine(new Human("Петя"));
        }
        /* Добавьте свой код ниже */
        public Human(string name)
        {
            this.name = name;
            this.profession = Console.ReadLine();
            this.age = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Имя: {this.name} Возраст:{this.age} Профессия:{this.profession}";
        }
    }
}