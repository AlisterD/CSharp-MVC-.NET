using System;
using Casino;
using Casino.TwentyOne;

namespace Sample_TwentyOne
{ 

    class Program
    {
        static void Main(string[] args)
        {
            
            const string casinoName = "Grand Hotel and Casino";

            

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name:", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("and how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals ");
            }

           
            Console.WriteLine("Hello,{0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "sure" || answer == "ya")
              {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
            
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance >0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("An error ocurred. Please contact your System Admin.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
              }

            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();


        }



   
    }

}
