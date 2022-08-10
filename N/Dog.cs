using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N
{
    internal class Dog:Animal
    {
        private string say;
        private string name;
        public override string Name
        {
            get => name;    //лямбда-выражение
            set => name = value;
        }
        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void GetSay()
        {
            Console.WriteLine(say); ;
        }
    }

}
