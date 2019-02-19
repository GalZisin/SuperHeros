using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170219
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash = new Flash("Flash", 20, 20_000);
            Spiderman spiderman = new Spiderman("Spiderman", 16, 10);
            Superman superman = new Superman("Superman", 30, 300_000);

            ISuperHero[] superHeros = new ISuperHero[]
            {
                new Flash("Flash", 20, 20_000),
                new Spiderman("Spiderman", 16, 10),
                new Superman("Superman", 30, 300_000)
            };
             
            foreach(ISuperHero hero in superHeros)
            {
                ActivateHero(hero);
                IdentifyHero(hero);
                GetMoreHeroData(hero);
            }
            Console.WriteLine();

                Console.WriteLine(flash);
                Console.WriteLine(spiderman);
                Console.WriteLine(superman);
           

            Console.ReadLine();
        }
        public static void ActivateHero(ISuperHero hero)
        {
            hero.ActiveSuperPowers();
        }
        public static void IdentifyHero(ISuperHero hero)
        {
            if(hero is Flash)
            {
                Console.WriteLine("Flash detected\n");
            }
            else if(hero is Superman)
            {
                Console.WriteLine("Superman detected\n");
            }
            else
            {
                if(hero is Spiderman)
                {
                    Console.WriteLine("Spiderman detected\n");
                }
            }
        }
        public static void GetMoreHeroData(ISuperHero hero)
        {
            if(hero is Flash)
            {
                Flash f = hero as Flash;
                Console.WriteLine("Flash voltage:{0}\n", f.Voltage);
            }
            else if(hero is Superman)
            {
                Superman s = hero as Superman;
                Console.WriteLine("Superman speed:{0}\n", s.Speed);
            }
            else
            {
                if(hero is Spiderman)
                {
                    Spiderman sp = hero as Spiderman;
                    Console.WriteLine("Spiderman web left:{0}\n", sp.WebLeft);
                }
            }
        }
        public static ISuperHero CreateHero(string heroName)
        {
            ISuperHero result = null;
            switch (heroName)
            {
                case "Spiderman":
                    Spiderman spiderman = new Spiderman("Spiderman", 16, 10);
                    result = spiderman;
                    break;
                case "Superman":
                    Superman superman = new Superman("Superman", 30, 300_000);
                    result = superman;
                    break;
                case "Flash":
                    Flash flash = new Flash("Flash", 20, 20_000);
                    result = flash;
                    break;
            }
                
            return result;
        } 
    }
}
