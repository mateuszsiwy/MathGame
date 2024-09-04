using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MathGame.Game;
namespace MathGame.Game
{
    internal class GameEngine
    {
        public static void StartGame(string option)
        {
            Console.Clear();

            Random random = new Random();

            switch (option)
            {
                case "V":
                    Console.WriteLine("Viewing History:");
                    foreach (string message in Helper.history)
                    {
                        Console.WriteLine($"{message}");
                    }
                    break;
                case "A":
                    Console.WriteLine("Addition Game");
                    AdditionGame(random);
                    break;
                case "S":
                    Console.WriteLine("Subtraction Game");
                    SubtractionGame(random);
                    break;
                case "M":
                    Console.WriteLine("Multiplication Game");
                    MultiplicationGame(random);
                    break;
                case "D":
                    Console.WriteLine("Division Game");
                    DivisionGame(random);
                    break;
                case "Q":
                    Console.WriteLine("Quiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please pick a valid option!\n");
                    break;

            }
        }
        static void GameTemplate(Random random, string oper)
        {
            int score = 0;
            string game = "";
            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 99);
                int num2 = random.Next(1, 99);

                if (oper == "/")
                {
                    while (num1 % num2 != 0)
                    {
                        num1 = random.Next(1, 10);
                        num2 = random.Next(1, 10);
                    }
                }

                Console.WriteLine($"{num1} {oper} {num2} = ");

                string resultString = Console.ReadLine();
                int result = 0;

                try
                {
                    result = int.Parse(resultString);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number");
                    i = i - 1;
                    continue;
                }


                switch (oper)
                {
                    case "+":
                        if (result == num1 + num2)
                        {
                            score++;
                        }
                        game = "Addition";
                        break;
                    case "-":
                        if (result == num1 - num2)
                        {
                            score++;
                        }
                        game = "Subtraction";
                        break;
                    case "*":
                        if (result == num1 * num2)
                        {
                            score++;
                        }
                        game = "Multiplication";
                        break;
                    case "/":
                        if (result == num1 / num2)
                        {
                            score++;
                        }
                        game = "Division";
                        break;
                }


            }
            Console.WriteLine($"Congrats you finished the game! Your final score is {score}");
            Helper.AddToHistory($"{DateTime.Now} - {game} result: {score}");
        }

        static void AdditionGame(Random random)
        {
            GameTemplate(random, "+");
        }
        static void SubtractionGame(Random random)
        {
            GameTemplate(random, "-");
        }
        static void MultiplicationGame(Random random)
        {
            GameTemplate(random, "*");
        }
        static void DivisionGame(Random random)
        {
            GameTemplate(random, "/");
        }
    }
}
