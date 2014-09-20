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
            
            



            if (count < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                Console.ResetColor(); 
                return;
            }
            
            
            
                int[] array = new int[count];
                Console.WriteLine("");
                for (int i = 0; i < count ; i++)
                {

                    Console.Write("Ange lön nummer {0}: ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());

                }

                

                int wagedistibution;
                wagedistibution = array.Max() - array.Min();




                



                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("Medianlön:");
                Console.WriteLine("Medellön: {0} ", array.Average());   
                Console.WriteLine("Lönespridning: {0}", wagedistibution); 
                Console.WriteLine("----------------------------------");

                Array.Sort(array);
                foreach (int i in array)
                {
                    Console.WriteLine(i);

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
