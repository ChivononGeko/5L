using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace l5t13
{
    /*
    * Реализуйте класс Student таким образом, чтобы он содержал 3 свойства:
    * 1) Имя.
    * 2) Возраст.
    * 3) Кафедра (Cathedra).
    * Добавьте в класс Student конструктор, который принимает имя и возраст, а кафедру укажите любую.
    * Сделайте так, чтобы в случае если переданный возраст объекта был меньше 17 или больше 70, то
    * ему бы присваивалось значение 20, а в остальных случаях - переданное значение.
    */
    public class Student
    {
        /* Добавьте свой код ниже */
        public string name;
        private int age;
        public string cathedra;

       
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.cathedra = "Философия";
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(new Student("Петя", 73));
        }

        public override string ToString()
        {
            return $"Name:{this.name} Age:{age} Lafedra:{this.cathedra}";
        }
    }
}