using System;

namespace Snake_Ladder
{
    
    class Program
    {
        
        public const int FINAL_POSITION = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder game");

            int countDieRoll = 0;
            int chance = 0; //chance = 0, player1 turn     chance = 1,player2turn           
            int player1Position = 0;
            int player2Position = 0;
            Console.WriteLine("Player1 starting position :" + player1Position);
            Console.WriteLine("Player1 starting position :" + player2Position);

            Random random = new Random();
            
            while (player1Position < FINAL_POSITION && player2Position < FINAL_POSITION)
            {
                int dieNo = random.Next(1, 7);
                countDieRoll++;

               
                int checkOption = random.Next(0, 3);

                if (chance == 0)
                {
                    Console.WriteLine("Player1 Plays :");
                    Console.WriteLine("No on die :" + dieNo);
                    player1Position = GetPlayerPosition(player1Position,dieNo,checkOption);
                    Console.WriteLine("Player1 position :"+player1Position);
                    if(checkOption == 0 || checkOption == 2)
                      chance = 1;     
                }
                else
                {
                    Console.WriteLine("Player2 Plays :");
                    Console.WriteLine("No on die :" + dieNo);
                    player2Position = GetPlayerPosition(player2Position,dieNo,checkOption);
                    Console.WriteLine("Player2 position :" + player2Position);
                    if (checkOption == 0 || checkOption == 2)
                        chance = 0;
                }
            }
            Console.WriteLine("Total Die Roll :" + countDieRoll);
            if(player1Position == 10)
                Console.WriteLine("Player 1 WINS!!");
            else
                Console.WriteLine("Player 2 WINS!!");
        }

        static int GetPlayerPosition(int playerPosition,int dieNo,int checkOption)
        {
            switch (checkOption)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Ladder");
                    playerPosition = playerPosition + dieNo;
                    if (playerPosition > FINAL_POSITION)
                    {
                        playerPosition = playerPosition - dieNo;
                    }

                    break;
                case 2:
                    Console.WriteLine("Snake");
                    playerPosition = playerPosition - dieNo;
                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }
                    break;
                default:
                    Console.WriteLine("No such option");
                    break;
            }
            return playerPosition;

        }
    }
}
