namespace DataStructureSorting
{
    internal class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("List Sort\n\n");
            program.ListSort();
            Console.WriteLine("Array Sort\n\n");
            program.ArraySort();
            Console.WriteLine("Stack Sort\n\n");
            program.StackSort();
            Console.WriteLine("Queue Sort\n\n");
            program.QueueSort();
            Console.WriteLine("IList Sort\n\n");
            program.IListSort();

        }

        public void ListSort()
        {
            List<int> ListS = new List<int>();
            for (int i = 0; i < 10; i++)
                ListS.Add(random.Next(0, 100));

            ListS.Sort();
            Console.WriteLine(string.Join(",", ListS));
            Console.WriteLine("\n");

        }
        public void ArraySort()
        {
            int[] intArrSort = new int[10];
            for (int i = 0; i < 10; i++)
                intArrSort[i] = (random.Next(0, 100));

            Array.Sort(intArrSort);
            Console.WriteLine(string.Join(",", intArrSort));
            Console.WriteLine("\n");
        }

        public void StackSort()
        {
            Stack<int> StackSort = new Stack<int>();

            for (int i = 0; i < 10; i++)
                StackSort.Push(random.Next(0, 100));

            int[] myArray = StackSort.ToArray();
            Array.Sort(myArray);
            Array.Reverse(myArray);
            StackSort.Clear();
            foreach (int value in myArray)
                StackSort.Push(value);
            Console.WriteLine(string.Join(",", StackSort));
            Console.WriteLine("\n");
        }

        public void QueueSort()
        {
            Queue<int> QueueSort = new Queue<int>();

            for (int i = 0; i < 10; i++)
                QueueSort.Enqueue(random.Next(0, 100));

            int[] myArray = QueueSort.ToArray();
            Array.Sort(myArray);
            QueueSort.Clear();
            foreach (int value in myArray)
                QueueSort.Enqueue(value);
            Console.WriteLine(string.Join(",", QueueSort));
            Console.WriteLine("\n");
            IList<int> listed = new List<int>();

        }


        public void IListSort()
        {
            IList<int> IListSort = new List<int>();

            for (int i = 0; i < 10; i++)
                IListSort.Add(random.Next(0, 100));
            ((List<int>)IListSort).Sort();
            Console.WriteLine(string.Join(",", IListSort));
        }

        


    }
}