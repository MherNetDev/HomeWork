using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT
{
    internal class Program
    {
        public static List<string> MainMethodArgs = new List<string>();
        static void Main(string[] args)
        {
            int s = 0;
            int h = 0;
            int b = 0;
            Console.WriteLine("Press 1 for Default pack");
            Console.WriteLine("Press 2 for Unique pack");
            if (int.TryParse(Console.ReadLine(),out int choose))
            {
                Console.Clear();
                if (choose == 1)
                {
                    Rest rest = new Rest();
                }
                else if (choose == 2)
                {
                    Console.WriteLine("How many Sushi");
                    s = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Rest rest = new Rest(ref s, out h, out b);


                }
            }
            else
            {
                Console.Clear();

                Console.WriteLine(errorEnum.Not_a_Number);
                Console.WriteLine("Press any button to try again");
                Console.ReadLine();

                Console.Clear();
                Main(MainMethodArgs.ToArray());
            }
       



        }
    }
    enum errorEnum
    {
        Not_a_Number = 0,
    }


}