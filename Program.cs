using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            int IApoints = 0;
            int PlayerPoints = 0;


            Console.WriteLine("Press Enter key to roll the dice");
            Console.ReadKey();

            for (int i = 1; i < 10; i++)
            {

                Random dice = new Random();
                int PlayerRoll = dice.Next(1, 21);
                int IARoll = dice.Next(1, 21);

                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Round " + i);
                Console.WriteLine("Your roll is " + PlayerRoll);
                Console.WriteLine("IA is " + IARoll);

                if (PlayerRoll > IARoll)
                {
                    PlayerPoints++;
                    Console.WriteLine("Player wins a point");

                }
                if (PlayerRoll < IARoll)
                {
                    IApoints++;
                    Console.WriteLine("IA wins a point");

                }
                if (PlayerRoll == IARoll)
                {
                    IApoints++;
                    PlayerPoints++;
                    Console.WriteLine("Player and IA wins a point");
                }

                Console.WriteLine("Score\nPlayer: " + PlayerPoints + "\nIA:" + IApoints);

                if (i == 9)      {
                    Console.WriteLine("-------------------------------\n");
                    Console.WriteLine("FINAL SCORE \nPlayer: " + PlayerPoints + "\nIA:" + IApoints);


                    if (PlayerPoints > IApoints)
                    {
                        Console.WriteLine("\nPlayer Wins");
                    }
                    if (PlayerPoints < IApoints)
                    {
                        Console.WriteLine("\nIA Wins");
                    }
                    if (PlayerPoints == IApoints)
                    {
                        Console.WriteLine("\nDRAW");
                    }


                }
                Console.ReadKey();

            }
        }
    }
}