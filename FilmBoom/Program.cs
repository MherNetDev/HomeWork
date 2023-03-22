using System;
using System.IO.Pipes;

namespace FilmBoom
{
     class Program
    {
        static void Main(string[] args)
        {
         

            string[] filmNames = new string[] { "Avengers", "Ace Ventura" , "Rush time", "1+1" };

            Console.WriteLine("Select a movie:");
            Console.WriteLine("1. Avengers");
            Console.WriteLine("2. Ace Ventura");
            Console.WriteLine("3. Rush time");
            Console.WriteLine("4. 1+1");


            int choice = int.Parse(Console.ReadLine())-1;
            Movies movies = new Movies();
            movies.choice= choice;
            Console.Clear();
            movies.DlgMeth();
            Console.ReadKey();

        }
      
    }
}