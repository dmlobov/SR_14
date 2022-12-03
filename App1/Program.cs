using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            Console.WriteLine(cat.Name);
            cat.Say();
            Dog dog = new Dog("Шарик");
            Console.WriteLine(dog.Name);
            dog.Say();
            Console.ReadKey();

        }
    }
}
