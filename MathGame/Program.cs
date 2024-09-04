

using MathGame.Game;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Please select a game");
            Console.WriteLine("V - View Previous Games");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - Quit the program");
            Console.WriteLine("-------------------------------");
            string option = Console.ReadLine();
            if (option != null)
            {
                GameEngine.StartGame(option);
                
            }
        }
    }
}