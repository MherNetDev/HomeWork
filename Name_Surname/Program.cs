using System.Xml.Linq;

namespace Name_Surname
{
    class Human
    {
        public static string name;
        public static string surname;


        static void Main(string[] args)
        {

            namecheck();
            surnamecheck();
        }

        public static void namecheck() {
           name = Console.ReadLine();
            if (name != null && name != "")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i])) { }
                    else if (int.TryParse(name[i].ToString(), out var num))
                    {
                        Console.WriteLine(errorenum.NumberDetected);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(errorenum.SymbolDetected);
                        return;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorenum.WriteName);
                namecheck();
            }
        }

        public static void surnamecheck()
        {
            surname = Console.ReadLine();
            if (surname != null && surname != "")
            {
                for (int i = 0; i < surname.Length; i++)
                {
                    if (char.IsLetter(surname[i])) { }
                    else if (int.TryParse(surname[i].ToString(), out var num))
                    {
                        Console.WriteLine(errorenum.NumberDetected);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(errorenum.SymbolDetected);
                        return;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorenum.WriteName);
                surnamecheck();
            }
        }




        enum errorenum
        {
            SymbolDetected = 0,
            NumberDetected = 1,
            WriteName = 2,
        }
    }
}