namespace AbstractionAndInterfaces
{
    internal class Program:Class1
    {
        static void Main(string[] args)
        {


            Class1 class1= new Class1();

            class1.Age = Convert.ToInt32(Console.ReadLine());
            class1.ExpYears = Convert.ToInt32(Console.ReadLine());




            Class2 class2 = new Class2();
            class2.HowMuch();


        }
    }
}