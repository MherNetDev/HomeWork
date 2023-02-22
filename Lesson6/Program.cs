namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 0, tax = 0, clB = 0, stampDuty = 0, socialFee = 0;

            Taxes(out salary, out tax);
            Socialfee(in salary, ref  socialFee);
            Stampduty(ref salary, ref stampDuty);
            CleanBalance(ref salary,ref socialFee,ref stampDuty,ref clB,ref tax);

            Console.WriteLine("Taxes          " + (int)tax);
            Console.WriteLine("Social Fee     " + (int)socialFee);
            Console.WriteLine("Stamp Duty     " + (int)stampDuty);
            Console.WriteLine("Wage Balance   " + (int)salary);
            Console.WriteLine("Clean Balance  " + (int)clB);

        }

        public static double CleanBalance(ref double salary, ref double socialFee, ref double stampDuty, ref double clB, ref double tax)
        {
            clB = salary - socialFee - stampDuty - tax;

            return clB;
        }

        public static double Stampduty(ref double salary, ref double stampDuty)
        {
            if (salary <= 100000)
                stampDuty = 1500;
            else if (salary > 100000 && salary <= 200000)
                stampDuty = 3000;
            else if (salary > 200000 && salary <= 500000)
                stampDuty = 5500;
            else if (salary > 500000 && salary <= 1000000)
                stampDuty = 8500;
            else if (salary > 1000000 )
                stampDuty = 15000;

            return stampDuty;
        }

        public static double Socialfee(in double salary,ref double socialFee)
        {
            if (salary <= 500000)
                socialFee = salary/100*5;
            else if (salary > 500000 && salary <= 1125000)
                socialFee = (salary / 100 * 10)-25000;
            else if (salary > 1125000 )
                socialFee = 87500;
        
            return socialFee;
        }

        public static double Taxes(out double salary, out double tax)
        {
            if (double.TryParse(Console.ReadLine(), out salary)  ) {
                if (salary < 2000)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR:Number must be greater/equal to 2000");
                    Taxes(out salary, out tax);

                }
                Console.Clear();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR:Not a number");
                Taxes(out salary, out tax);
            }

            tax = salary / 100 * 20;
            return tax;
        }


    }
}