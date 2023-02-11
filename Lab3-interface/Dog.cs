using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_interface
{
    internal class Dog:IAnimal
    {
        public string Name
        {
            get; set;
        }
        public string Color
        {
            get; set;
        }
        public double Height
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public Dog(string name, string color, double height, int age)
        {
            Name = name;
            Color = color;
            Height = height;
            Age = age;
        }
        public override string ToString()
        {
            return Name+" is a dog, his color is " 
                + Color + ", his height is " + Height + "cm and his age is " + Age+" years old.";

        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat beef.");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
}
