using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170219
{
    class Spiderman: Human, IClimb, ISuperHero
    {
        public int webLeft;

        public Spiderman(string name, int age, int webLeft):base(name, age)
        {
            this.webLeft = webLeft;
        }

        public void ActiveSuperPowers()
        {
            Console.WriteLine("Spiderman: Active Super Power\n");
        }
        public void Climb()
        {
            Console.WriteLine("Spiderman power: Climb\n");
        }
        public override string Name { get; set; }

        public int WebLeft {
            get
            {
                return this.webLeft;
            }
            private set
            {
                this.webLeft = value;
            }
        }

        public override string ToString()
        {
            ActiveSuperPowers();
            Climb();
            return $"Web left: {this.webLeft} {base.ToString()} ";
        }
    }
}
