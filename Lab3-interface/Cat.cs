using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_interface
{
    internal class Cat:IAnimal
    {
        //StreamWriter streamWriter;

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
        public Cat(string name, string color, double height, int age)
        {
            Name = name;
            Color = color;
            Height = height;
            Age = age;
            //this.streamWriter = new StreamWriter(fileName);
        }
        public override string ToString()
        {
            return Name + " is a Cat, her color is "
                + Color + ", her height is " + Height + "cm and her age is " + Age + " years old.";

        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public string Cry()
        {
            return "Meow!";
        }
        //public void Add(string message)
        //{
        //    this.streamWriter.WriteLine(message);
        //    this.streamWriter.Flush();
        //}
    }
}
