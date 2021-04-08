using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l5t26

{

    /*

    * Для класса SpaceDog создайте следующие свойства:

    * 1) Name.

    * 2) Age.

    * 3) IsInSpace.

    * 4) IsGoingToSleep.

    * 5) IsAtHome.

    * Для класса SpaceDog создайте конструктор, который принимает: имя, возраст и статус бодрствования.

    * Свойства IsInSpace и IsAtHome реализуйте таким образом, чтобы они всегда имели противоположные

    * значения.

    * Переопределите метод ToString() для класса SpaceDog, чтобы он выводил информацию об экземпляре в следующем формате:

    * "Меня зовут ХХХ, я первый космонавт! Мне ХХХ лет, я нахожусь дома\в космосе. Я скоро пойду спать\Я недавно проснулся!"

    * Итоговая строка должна зависеть от значений соответствующих свойств экземпляра класса SpaceDog.

    */

    public class SpaceDog

    {

        /* Добавьте свой код ниже */

        private bool isInSpace;

        private bool isAtHome;

        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsGoingToSleep { get; set; }

        public bool IsInSpace { get { return isInSpace; } set { isInSpace = value; IsAtHome = !value; } }

        public bool IsAtHome { get { return isAtHome; } set { isAtHome = value; IsInSpace = !value; } }

        public SpaceDog(string name, int age, bool isGoingToSleep)

        {

            Name = name;

            Age = age;

            IsGoingToSleep = isGoingToSleep;

        }

        public static void Main(string[] args)

        {

            SpaceDog dog = new SpaceDog("dasdf", 41, false);

            SpaceDog dog2 = new SpaceDog("dasdf", 423, false);

            Console.WriteLine(dog);

            Console.WriteLine(dog2);

            dog.IsAtHome = true;

            dog.IsInSpace = true;

        }

        public override string ToString()

        {

            if (IsAtHome == true && IsGoingToSleep == true)

                return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь дома. Я скоро пойду спать!";

            else if (IsAtHome == false && IsGoingToSleep == true)

                return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь в космосе. Я скоро пойду спать!";

            else if (IsAtHome == true && IsGoingToSleep == false)

                return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь дома. Я недавно проснулся!";

            else

                return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь в космосе. Я скоро пойду спать!";

        }

        /* Добавьте свой код ниже */

    }

}