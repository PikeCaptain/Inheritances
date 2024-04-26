namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "Racing", "Forza Horizon 5");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG-13", "Sci-Fi/Action", "Godzilla King of the Monsters");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}