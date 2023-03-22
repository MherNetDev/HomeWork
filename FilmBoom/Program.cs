using System;
using System.IO;

namespace FilmBoom
{
     class Program
    {
        public static int choice; 

        static void Main(string[] args)
        {

        
            /*int choice = int.Parse(Console.ReadLine()) - 1;
            if (true)
            {

            }
            Movies movies = new Movies();
            movies.choice= choice;
            Console.Clear();
            movies.DlgMeth();
             Console.ReadKey();*/

            CallM();

        }

        static void CallM()
        {
            string[] filmNames = new string[] { "Avengers", "Ace Ventura", "Rush time", "1+1" };

            Console.WriteLine("Select a movie:");

            // Console.WriteLine("1. Avengers");
            // Console.WriteLine("2. Ace Ventura");
            // Console.WriteLine("3. Rush time");
            //  Console.WriteLine("4. 1+1");
            int num  = 0;
            Console.WriteLine("{0} {0} {0} {0}", num++);
            Console.WriteLine( "{0}", string.Join(", ", filmNames));
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
          Console.ReadKey();

        }

    }
}