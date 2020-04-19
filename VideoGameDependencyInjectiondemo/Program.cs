using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace VideoGameDependencyInjectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // a container is a list of iteams that can be used as parameters in my hero class
            UnityContainer container = new UnityContainer();


            container.RegisterType<IWeapon, Grenade>(new InjectionConstructor("Fire Ball"));
            container.RegisterType<IHero, HeroThatCanUseAnyWeapon>(new InjectionConstructor("Bomber", typeof(IWeapon)));

            var hero5 = container.Resolve<IHero>();

            hero5.Attack();

            Console.WriteLine();

            HeroTahtOnlyUsesSwords hero1 = new HeroTahtOnlyUsesSwords("Ultraman");
            hero1.Attack();
            Console.WriteLine();


            HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon("SuperGreatman", new Grenade("Pineaple"));
            hero2.Attack();
            Console.WriteLine();


            HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon("Sword Swinger", new Sword("Brissinger"));
            hero3.Attack();
            Console.WriteLine();


            HeroThatCanUseAnyWeapon hero4 = new HeroThatCanUseAnyWeapon("GI Joe", new Gun("AK 42", new List<Bullet> { new Bullet("silver", 10), new Bullet("lead", 20), new Bullet("dead aim", 3), new Bullet("Hollow Point", 5) }));
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();

            Console.ReadLine();
        }
    }
}
