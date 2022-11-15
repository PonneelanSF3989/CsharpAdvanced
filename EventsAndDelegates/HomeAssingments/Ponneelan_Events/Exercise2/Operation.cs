using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public static class Operation
    {
       
        public static Calculator newCalculator = new Calculator();
        public static void GetNumbers()
        {
            Console.WriteLine("\nEnter the NUmber one");
            newCalculator.Number1= int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the NUmber two");
            newCalculator.Number2= int.Parse(Console.ReadLine());
            
        }
        public static  void CallEvent()
        {
            Events.eventLink += new EventHandler(GetNumbers);
            Events.eventLink += new EventHandler(newCalculator.Addition);
            Events.eventLink += new EventHandler(newCalculator.Subraction);
            Events.eventLink += new EventHandler(newCalculator.Multiplication);
            Events.eventLink += new EventHandler(newCalculator.Division);
            Events.EventHolder();

        }
    }
}