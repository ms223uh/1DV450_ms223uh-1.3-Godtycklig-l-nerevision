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
            int amountOfSalaries = ReadInt("Ange antal löner att mata in: ");
           
            
            ProcessSalaries(amountOfSalaries);

        } 

        static void ProcessSalaries(int count)
        {
            
            int[] array = new int[count];



            if (count < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                Console.ResetColor(); 
                return;
            }

            
            {
                Console.WriteLine("");
                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write("Ange lön nummer {0}: ", i + 1);


                    int amountOfSalaries = int.Parse(Console.ReadLine());

                }
                
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("Medianlön:");
                Console.WriteLine("Medellön:");
                Console.WriteLine("Lönespridning:");
                Console.WriteLine("----------------------------------");
            }
        }


        static int ReadInt(string prompt)
        {
            Console.Write("Ange antal löner att mata in: ");
            int amountOfSalaries = int.Parse(Console.ReadLine());
            return amountOfSalaries;

        }
    }
}
