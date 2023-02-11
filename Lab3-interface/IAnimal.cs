using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_interface
{
    internal interface IAnimal
    {
        string Name
        {
            get;set;
        }
        string Color
        {
            get; set;   
        }
        double Height
        {
            get; set;   
        }
        int Age
        {
            get; set;   
        }

        void Eat();
        string Cry();
        string ToString();// format the output
        //void Add(string message);
    }
}
