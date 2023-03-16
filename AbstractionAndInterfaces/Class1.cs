using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterfaces
{
    public class Class1 : Interface
    {
        public int Age {get;set; }
        public string NameOf { get;set;}
        public string SurNameOf { get;set;}
        public int ExpYears { get;set;}
        public string profession { get; set; }
    }


    public class Class2 : Class1 { 
    
    public void HowMuch()
        {
            Class1 class1 = new Class1();
            Console.WriteLine("HowMuch = "+class1.Age/class1.ExpYears);

        }

    }


}
