using System;
using System.IO;

namespace FilmBoom
{


    class Program
    {
        // Used (Delegates Array),(Try Catch),(Interface),(inheritance),(Recursion)
        public static int choice;
        static void Main(string[] args)
        {
            CallM();
        }

        static void CallM()
        {
            Console.Clear();
            string[] filmNames = new string[] { "Avengers", "Ace Ventura", "Rush time", "1+1" };
            Console.WriteLine("Select a movie:");

            for (int i = 0; i < filmNames.Length; i++)
                Console.WriteLine(i+1+". " + filmNames[i]);


            Movies movies = new Movies();
            int dlgLenght = movies.methods.Length;

            try{choice = int.Parse(Console.ReadLine())-1;}
            catch (Exception)
            {
                Console.Clear();
                CallM();
            }
            if (choice >= dlgLenght ||choice<0)
            {
                Console.Clear();
                CallM();
            }
          movies.choice = choice;
          Console.Clear();
          movies.DlgMeth();

            Console.WriteLine("Type b for going back");
            for (; ;)
            {
                if (Console.ReadKey().Key == ConsoleKey.B)
                    CallM();
                else
                    continue;
            }
           
        }

    }
}