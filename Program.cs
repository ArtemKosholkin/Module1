using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name=Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Greet(name, age);
            Console.ReadKey();
        }

        static void Greet (string name, string age)
        {
            Console.WriteLine("Здравствуйте, {0}!", name);
            Console.WriteLine("Мне сообщили, что Вам {0}", age);
        }

    }
}
