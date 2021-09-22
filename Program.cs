using System;

namespace Random_Number_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random Zahl = new Random();
            int antwort = Zahl.Next(1, 101);
            int versuche = 1;
            bool L = false;

            

            string titel = @"
 ██████╗███████╗██████╗ ████████╗██╗███████╗██╗███████╗██████╗      ██████╗  █████╗ ███╗   ███╗███████╗
██╔════╝██╔════╝██╔══██╗╚══██╔══╝██║██╔════╝██║██╔════╝██╔══██╗    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝
██║     █████╗  ██████╔╝   ██║   ██║█████╗  ██║█████╗  ██║  ██║    ██║  ███╗███████║██╔████╔██║█████╗  
██║     ██╔══╝  ██╔══██╗   ██║   ██║██╔══╝  ██║██╔══╝  ██║  ██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  
╚██████╗███████╗██║  ██║   ██║   ██║██║     ██║███████╗██████╔╝    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗
 ╚═════╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝╚═════╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                                                       
";

            Console.WriteLine(titel);
                Console.WriteLine("Errate die korrekte Zahl");

            do
            {


                try
                {
                    int userGues = System.Convert.ToInt32(Console.ReadLine());



                    while (antwort != userGues)
                    {
                        while (userGues < 1 || userGues > 100)
                        {
                            Console.WriteLine("Gebe eine Gültige Zahl ein");
                            Console.WriteLine("--------------------------");
                            userGues = System.Convert.ToInt32(Console.ReadLine());
                            versuche++;
                        }


                        if (userGues < antwort)
                        {
                            Console.WriteLine("Die Geratene Zahl muss höher sein!");
                            Console.WriteLine("----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Die Geratene Zahl muss kleiner sein");
                            Console.WriteLine("-----------------------------------");
                        }
                        userGues = System.Convert.ToInt32(Console.ReadLine());
                        // bis hier wird alles angegeben richtig oder falsch, fehlt noch mitzhähler 
                        versuche++;
                    }

                    if (userGues == antwort)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; 
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Die Geheimzahl wurde erraten");
                        Console.WriteLine("Du hast so viele male geraten: " + versuche);
                        L = false;



                    }
                }
                catch
                {
                   
                    Console.WriteLine("Ungültige Eingabe");
                    Console.WriteLine("Versuche es nochmal: ");
                    Console.WriteLine("-----------------------");
                    L = true;
                    
                }







            } while (L = true);
           
        }
    }
}
