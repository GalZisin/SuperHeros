using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170219
{
    abstract class Human
    {
        public string name;
        private int age;
        abstract public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            
        }
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Name: {this.name} Age: {this.age}\n\n";
        }
    }
}
