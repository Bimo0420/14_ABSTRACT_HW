using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    internal class Cat : Animal   //для быстрой реализации абстрактных элементов - нажать на лампочку
    {
        private string say = "Мяу";
        private string name;
        public override string Name
        {
            get => name;    //лямбда-выражение
            set => name = value;
        }
        public Cat(string name)
            :base(name)
        {
            this.say = say;
        }

        public override void GetSay()
        {
            Console.WriteLine("Мяу"); ;
        }
    }
}
