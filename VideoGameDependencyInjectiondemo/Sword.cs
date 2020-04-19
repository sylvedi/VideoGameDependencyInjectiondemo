namespace VideoGameDependencyInjectiondemo
{
    internal class Sword : IWeapon
    {
        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public string SwordName { get; set; }

        public void AttackWithMe()
        {
            System.Console.WriteLine(SwordName + "Slices through the air, devastating all enemies");
        }
    }
}