using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170219
{
    class Flash: Human, ISuperHero, IFlash
    {
        public int volt;

        public Flash(string name, int age, int volt) : base(name, age)
        {
            this.volt = volt;
        }
        public void ActiveSuperPowers()
        {
            Console.WriteLine("Flash: Active Super Power\n");
        }
        public void FireLightnings()
        {
            Console.WriteLine("Flash power: Fire Lightnings\n");
        }
        public int Voltage {
            get
            {
                return this.volt;
            }
            private set
            {
                this.volt = value;
            }  
        }
        public override string Name { get; set; }

        public override string ToString()
        {
            ActiveSuperPowers();
            FireLightnings();
            return $"Volts: {this.volt} {base.ToString()} ";
        }
    }
}
