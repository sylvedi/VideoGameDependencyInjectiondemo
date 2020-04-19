using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDependencyInjectiondemo
{
    class HeroTahtOnlyUsesSwords : IHero
    {
        public HeroTahtOnlyUsesSwords(string name)
        {
            Name = name;
        }

        public string Name { get; set; }


        public void Attack()
        {
            Sword sword = new Sword("Excalibur");
            Console.WriteLine(Name + " Prepares himself for the battle.");
            sword.AttackWithMe();
        }
    }
}
