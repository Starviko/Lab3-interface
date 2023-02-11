using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog("Max","Brown",50.5,2);
            //dog.Name = "Max";
            //dog.Age = 2;
            //dog.Height = 50;
            //dog.Color = "Brown";
            Console.WriteLine(dog.ToString());
            dog.Eat();
            Console.WriteLine(dog.Cry());

            IAnimal cat = new Cat("Momo", "Black", 20, 3);
            Console.WriteLine(cat.ToString());
            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> animals = new List<IAnimal>();// create a aninals list to hold animals object.
            animals.Add(dog);
            animals.Add(cat);
            Console.WriteLine("The names of animals: "+dog.Name+" "+cat.Name);
        }
    }
}
