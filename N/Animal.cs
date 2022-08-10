using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    public abstract class Animal
    {
        public abstract string Name { get; set; } //свойство без реализации
        public Animal (string name) //конструктор
        {
            Name = name;
        }
        public abstract void GetSay();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetSay();
           
        }
    }
}
