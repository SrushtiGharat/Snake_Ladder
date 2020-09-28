using System;

namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");
            int FINAL_POSITION = 100;
            
            int player1Position = 0;
            Console.WriteLine("Player1 starting position :" + player1Position);

            Random random = new Random();
            int dieNo = random.Next(1, 7);
            Console.WriteLine("No on die :" + dieNo);
        }
    }
}
