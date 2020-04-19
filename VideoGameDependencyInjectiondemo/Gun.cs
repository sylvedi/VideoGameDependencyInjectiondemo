using System.Collections.Generic;

namespace VideoGameDependencyInjectiondemo
{
    internal class Gun : IWeapon
    {
        public string Name;
        public List<Bullet> Bullets { get; set; }


        public Gun(string name, List<Bullet> bullets)
        {
            this.Name = name;
            this.Bullets = bullets;
        }

        public void AttackWithMe()
        {
            if (Bullets.Count > 0)
            {
                System.Console.WriteLine(Name + " fires a round called " + Bullets[0 ].Name + "The victim now has a deadly hole in him");
                Bullets.RemoveAt(0);
            }
            else
            {
                System.Console.WriteLine("The gun has no bullets. Nothing happens");
                
            }
           
        }
    }
}