using System;
using Casino;
using Casino.TwentyOne;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Sample_TwentyOne;



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
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error ocurred. Please contact your System Admin.");
                        UpdateDbWithException(ex);
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
        private static void updatedbwithexception(exception ex)
        {
            string connectionstring = @"data source = (localdb)\projectsv13; initial catalog = twentyonegame; 
            integrated security = true; connect timeout = 30; encrypt = false; trustservercertificate = false; 
            applicationintent = readwrite; multisubnetfailover = false";
            string querystring = @"insert into exceptions (exceptiontype, exceptionmessage, timestamp) values
                                   (@exceptiontype, @exceptionmessage, @timestamp)";

            using (sqlconnection connection = new sqlconnection(connectionstring))
            {
                sqlcommand command = new sqlcommand(querystring, connection);
                command.parameters.add("@exceptiontype", sqldbtype.varchar);
                command.parameters.add("@exceptionmessage", sqldbtype.varchar);
                command.parameters.add("@timestamp", sqldbtype.datetime);

                command.parameters["@exceptiontype"].value = ex.gettype().tostring();
                command.parameters["@exceptionmessage"].value = ex.message;
                command.parameters["@timestamp"].value = datetime.now;

                connection.open();
                command.executenonquery();
                connection.close();

            }
        }


    
   
    }

}
