using System;

namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");
            int FINAL_POSITION = 100;

            int countDieRoll = 0;
            int player1Position = 0;
            Console.WriteLine("Player1 starting position :" + player1Position);

            Random random = new Random();
            while(player1Position < FINAL_POSITION)
            {
                int dieNo = random.Next(1, 7);
                countDieRoll++;
                Console.WriteLine("No on die :" + dieNo);

                int checkOption = random.Next(0, 3);
                switch (checkOption)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        player1Position = player1Position + dieNo;
                        if(player1Position > FINAL_POSITION)
                        {
                            player1Position = player1Position - dieNo;
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        player1Position = player1Position - dieNo;
                        if(player1Position < 0)
                        {
                            player1Position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }
                Console.WriteLine("Your current position is :" + player1Position);
            }
            Console.WriteLine("Die Roll Count :" + countDieRoll);
        }
    }
}
