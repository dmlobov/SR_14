using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}
