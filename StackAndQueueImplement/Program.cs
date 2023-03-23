using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackAndQueueImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack= new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            Random random= new Random();

            for (int i = 0; i < 9; i++)
                intStack.Push(random.Next(0,50));
            for (int i = 0; i < 9; i++)
                intQueue.Enqueue(random.Next(0, 50));


            Console.WriteLine("Stack = " + String.Join(",", intStack));
            Console.WriteLine("Queue = "+String.Join(",", intQueue));
            Console.ReadKey();
        }
    }
}