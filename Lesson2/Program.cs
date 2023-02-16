namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes

            //byte 0 -- 255
            //sbyte -128 -- 128
            //short -32768 -- 32767
            //ushort 0 -- 65535
            //int -2147483648 -- 2147483647
            //uint 0 -- 4294967295
            //long -9223372036854775808 -- 9223372036854775807
            //ulong 0 -- 18446744073709551615

            byte by = 1;
            sbyte sby = 2;
            short sh = 3;
            ushort ush = 4;
            int i = 5;
            uint ui = 6;
            long l = 7;
            ulong ul = 8;

            //Console.WriteLine(ul - l); ??????  Ошибка CS0034  Оператор "-" для операнда типа "ulong" и "long" является неоднозначным


            Console.WriteLine(
                "by = " + by + "\n" +
                "sbyte =" + sby + "\n" +
                "short  = " + sh + "\n" +
                "ushort  = " + ush + "\n" +
                "int  = " + i + "\n" +
                "uint  = " + ui + "\n" +
                "long  = " + l + "\n" +
                "ulong  = " + ul + "\n");

            Console.WriteLine(l + "/" + sby + "+" + ush + "+" + i + "-" + ui + "=" + (l / sby + ush + i - ui));




            //Double Float Decimal
            //float  4 bytes
            //double 8 bytes
            //decimal 16 bytes
            //Single 32 bytes

            double d = 4.5;
            float f = 8.5f; //Առանց վերջում f գրելու չի լինի?
            decimal dc = 16.5m; //Console.WriteLine(dc-d); Decimal-ից Float,Double չի լինում հանել չնայած որ decimal-ը ավելի մեծ Range ունի

            Console.WriteLine((f + f).GetType()); //float + float = Single? 
            Console.WriteLine((f * d).GetType());





            //if else box

            Console.WriteLine("\n\n" + "Type Number");
            double strNum = Convert.ToDouble(Console.ReadLine());


            if (strNum % 2 == 0)
                Console.WriteLine("Even");
            else if (strNum < 1)
                Console.WriteLine("Number must be greater than 1");
            else
                Console.WriteLine("Odd");

            Console.WriteLine("\n" + "How Old Are You?");
            byte old = Convert.ToByte(Console.ReadLine());
            if (old > 0 && old <= 13)
                Console.WriteLine("You are a child");
            else if (old > 13 && old <= 21)
                Console.WriteLine("You are a teenager");
            else if (old > 21 && old <= 49)
                Console.WriteLine("You are a young man");
            else if (old >= 50)
                Console.WriteLine("You are a old man");





            //Switch case  box
            Console.WriteLine("Your Experiance in Programming from 1 to 4");
            byte expYears = Convert.ToByte(Console.ReadLine());
            switch (expYears)
            {
                case 1:
                    Console.WriteLine("-_-");
                    break;
                case 2:
                    Console.WriteLine("Middle Developer");
                    Console.WriteLine("Junior ");
                    break;
                case 3:
                    Console.WriteLine("Middle Developer");
                    break;
                case 4:
                    Console.WriteLine("Senior Developer");
                    break;

                default:
                    Console.WriteLine("Out of Range");
                    break;
            }

            var ternary = i < d ? false : true;
            Console.WriteLine("\n\n" + ternary);




        }
    }
}