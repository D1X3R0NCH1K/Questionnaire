using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вас зовут {name} и ваш возраст {age}");

            Console.Write("Введите вашу дату рождения: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine($"Ваша дата рождения: {birthDate}");
            Console.ReadKey();
        }
    }
}
