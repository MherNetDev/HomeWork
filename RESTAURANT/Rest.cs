using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT
{
    public class Rest
    {

        public void MakeSushi(ref int s) {

            Console.WriteLine(s+"-Sushi");
        }
        public void MakeHotDog(ref int h)
        {
            Console.WriteLine(h+"-HotDog");

        }
        public void MakeBurger(ref int b)
        {
            Console.WriteLine(b+"-Burger");
        }

        //Default pack overload
        public void MakeSushi(int v)
        {

            Console.WriteLine(v + "-Sushi");
        }
        public void MakeHotDog(int v)
        {
            Console.WriteLine(v + "-HotDog");

        }
        public void MakeBurger(int v)
        {
            Console.WriteLine(v + "-Burger");
        }


        public Rest()
        {

            MakeSushi(8);
            MakeHotDog(4);
            MakeBurger(2);
        }

        //Class overload - Constructor
        public Rest(ref int s,out int h,out int b)
        {
            Console.WriteLine("How many Hot-Dog");
            h= int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("How many Burger");
            b = int.Parse(Console.ReadLine());
            Console.Clear();

            MakeSushi(ref s);
            MakeHotDog(ref h);
            MakeBurger(ref b);
        }




    }
}
