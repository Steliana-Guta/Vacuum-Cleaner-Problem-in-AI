using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace VacuumCleaner
{
    class Program
    {

        public static Random random = new Random(); //create random 
        public static int[] A = { 0, 1 }, B = { 0, 1 }, vacuumLocation = { 0, 1 }; //array for room states

        static void Main(string[] args)
        {
            int numIndexA = random.Next(0, 2); //choose random state for room A on start
            int numIndexB = random.Next(0, 2); //choose random state for room B on start
            int numIndexLocation = random.Next(0, 2); //choose random location for vacuum on start
            int a = A[numIndexA]; //set state 
            int b = B[numIndexB]; //set state
            int location = vacuumLocation[numIndexLocation]; //set state
            Console.WriteLine("0 = Clean  ---  1 = Dirty"); //display legend
            Console.WriteLine("Room A: " + a + "  ---  Room B: " + b); //display room statuses

            int score = 0; //score starts at 0

            if (location == 0)
            {
                Console.WriteLine("Vacuum is randomly placed at Location A."); //display vacuum location

                if (a == 1)
                {
                    Console.WriteLine("Location A is dirty."); //state room status
                    a = 0; //set to clean
                    score = score + 1; //+1 for cleaning
                    Console.WriteLine("Location A has been Cleaned."); //display action taken
                    Console.WriteLine("Moving to Location B."); //move to next
                    score = score - 1; //-1 for moving

                    if (b == 1)
                    {
                        Console.WriteLine("Location B is Dirty."); //state room status
                        b = 0; //set to clean
                        score = score + 1; //+1 for cleaning
                        Console.WriteLine("Location B has been Cleaned."); //display action taken
                    }
                }
                else
                {
                    Console.WriteLine("Room A is already clean."); //state room status
                    score = score - 1;  //-1 for moving
                    Console.WriteLine("Moving to Location B ..."); //display action taken

                    if (b == 1)
                    {
                        Console.WriteLine("Location B is Dirty"); //state room status
                        b = 0; //set to clean
                        score = score + 1; //+1 for cleaning 
                        Console.WriteLine("Location B has been Cleaned."); //display action taken
                    }

                }

            }

            if (location == 1)
            {
                Console.WriteLine("Vacuum randomly placed at Location B."); //display vacuum location

                if (b == 1)
                {
                    Console.WriteLine("Location B is Dirty."); //state room status
                    b = 0; //set to clean
                    score = score + 1; //+1 for cleaning
                    Console.WriteLine("Location B has been Cleaned."); //display action taken
                    score = score - 1; //-1 for moving 
                    Console.WriteLine("Moving to Location A ..."); //display action taken

                    if (a == 1)
                    {
                        Console.WriteLine("Location A is Dirty."); //state room status
                        a = 0; //set to clean
                        score = score + 1; //+1 for cleaning
                        Console.WriteLine("Location A had been Cleaned."); //display action taken
                    }

                }
                else
                {
                    Console.WriteLine("Room B is already clean."); //state room status
                    Console.WriteLine("Moving to Location A."); //display action taken
                    score = score - 1; //-1 for moving

                    if (a == 1)
                    {
                        Console.WriteLine("Location A is Dirty."); //state room status
                        a = 0; //set tot clean
                        score = score + 1; //+1 for cleaning
                        Console.WriteLine("Location A has been Cleaned."); //display action taken
                    }

                }

            }

            Console.WriteLine("Room A: " + a + "  ---  Room B: " + b); //display status
            Console.WriteLine("Performance Measurement: " + score); //display score
            Console.ReadKey();
        }

    }

}


