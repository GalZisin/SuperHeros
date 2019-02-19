using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170219
{
    class Superman: Human, IFly, ISuperHero
    {
        public int speed;

        public Superman(string name, int age, int speed): base(name, age)
        {
            this.speed = speed;
        }
        public void ActiveSuperPowers()
        {
            Console.WriteLine("Superman: Active Super Power\n");
        }
        public void Fly()
        {
            Console.WriteLine("Superman power: Fly\n");
        }
        public override string Name { get; set; }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            private set
            {
                this.speed = value;
            }
        }
        public override string ToString()
        {
            ActiveSuperPowers();
            Fly();
            return $"Speed: {this.speed} {base.ToString()} ";
        }
    }
}
