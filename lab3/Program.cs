using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Inmatning av antal löner som användare vill lägga in i arrayen.
            // Om talet som användaren matar in är mindre än 2 så kommer ett,
            // felmeddelande upp & användaren har chans att skriva in ett nytt värde eller välja trycka ESC för att avsluta programmet.
            // Om talet är korreket (större än 2) så går du till else-satsen som startar metoden ProcessSalaries & skickar med värdet 
            // på amountOfSalaries till count i den andra metoden.


            do
            {
                Console.Clear();
                int amountOfSalaries = ReadInt("Ange antal löner att mata in: ");


                if (amountOfSalaries < 2)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nTryck tangent för ny beräkning - ESC avslutar.");
                    Console.ResetColor();

                }

                else
                {
                    ProcessSalaries(amountOfSalaries); 
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }


        // AmountOfSalaries övergår till namnet count.
       // Värdet som användaren har matat in i arrayen kommer att repeteras så många gånger som användaren har angivit.
      // De nya värdena kommer att sparas i arryen, array.

        static void ProcessSalaries(int count)
        {

            int[] unsortarray = new int[count]; 
            int[] array = new int[count];
            Console.WriteLine("");
            for (int i = 0; i < count; i++)
            {

                array[i] = ReadInt("Ange lön nummer " + (i+1) +": ");

            }


            //  Nya variabler för att räkna ut data.
           //  Medianlönen räknas ut med hjälp av längden på arrayen / på 2.
          //   Om talet är ojämt kommer uträkningen att göra samma uträkning som ovan & ta värdet som ligger ett steg till vänster i arryen med hjälp av -1.
         //    Sen lägga ihop de båda värderna & / 2.

        //     Medellönen räknas ut med hjälp av kommandot average.

       //      Lönespridningen räknas ut genom att ta det högsta värdet i arrayen - det lägsta värdet i arrayen.

      //       Klonade den osorterade arrayen innan jag sorterade den.


            unsortarray = (int[])array.Clone();  
            Array.Sort(array); 
            int wagedistribution;
            int median;
            int median1;
            int median2; 
            wagedistribution = array.Max() - array.Min();

            if (count % 2 == 0)
            {
                median1 = array.Length / 2;
                median2 = median1 - 1;
                median = (array[median1] + array[median2]) / 2;
            }
            else
            {
                median = array[array.Length / 2];
            }
            

            // Presentation av data.

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Medianlön:      {0,10:c0}", median);  
            Console.WriteLine("Medellön:       {0,10:c0} ", array.Average());
            Console.WriteLine("Lönespridning:  {0,10:c0}", wagedistribution); 
            Console.WriteLine("----------------------------------");


            // Presentation av löner.
            // Lägger in den osorterade arryen av lönerna. Den loopas till värdet slutar. Med hjälp av modulus så görs en radbrytning vid 3 värden.
           


          
                for (int a = 0; a < count; a++)
                {
                    if(a % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write("{0,10}", unsortarray[a]);
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nTryck tangent för ny beräkning - ESC avslutar.");
                Console.ResetColor();    
        } 
        



        // Användaren får skriva in ett tal (try) om det inte är giltigt så anropas (catch) & processen loopas till användaren skriver in rätt tal.
       //  Hela ReadInt metoden anropas i Main metiden.
       // Prompt = Med texten som skrivs ut.
      //  String = Med vad användaren skriver ut.


        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string arrayInput;
                arrayInput = Console.ReadLine(); 

                try
                {
                    int amountOfSalaries = int.Parse(arrayInput);
                    return amountOfSalaries;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("'FEL! {0}' kan inte tolkas som ett heltal! Var vänligen att försök igen.", arrayInput);
                    Console.ResetColor();;
                } 
            }
        }

      
    }
}
