class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dragon Treasure Game!");

        // Setting up the game with a maximum of 3 attempts for the Elf
        Game game = new Game(3);

        // Starting the game
        game.Play();
    }
}
