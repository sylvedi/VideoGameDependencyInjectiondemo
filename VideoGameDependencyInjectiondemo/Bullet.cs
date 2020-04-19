namespace VideoGameDependencyInjectiondemo
{
    public class Bullet
    {
        public string Name { get; set; }
        public int GamesOfPowder { get; set; }

        public Bullet(string name, int gamesOfPowder)
        {
            Name = name;
            GamesOfPowder = gamesOfPowder;
        }
    }
}