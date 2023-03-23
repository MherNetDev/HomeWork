using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackAndQueueImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");

            Stack<int> intStack= new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            Random random= new Random();

     
            Console.WriteLine("Print 1 to 10\n");
            for (int i =1; i <= 10; i++)
                intStack.Push(i);
            for (int i = 1; i <= 10; i++)
                intQueue.Enqueue(i);
            Console.WriteLine("Stack = " + String.Join(",", intStack));
            Console.WriteLine("Queue = " + String.Join(",", intQueue));
            Console.WriteLine("\n---------------------------------------");


            intStack.Clear();
            intQueue.Clear();
            Console.WriteLine("\n\nPrint Random numbers (0,50) range\n");


            for (int i = 0; i < 10; i++)
                intStack.Push(random.Next(0, 50));
            for (int i = 0; i < 10; i++)
                intQueue.Enqueue(random.Next(0, 50));
            Console.WriteLine("Stack = " + String.Join(",", intStack));
            Console.WriteLine("Queue = "+String.Join(",", intQueue));
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}