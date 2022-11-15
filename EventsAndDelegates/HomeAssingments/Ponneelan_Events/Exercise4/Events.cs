using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4
{
    public delegate void EventCalculator();
    public static partial class Operation
    {
        public static event EventCalculator eventLink;
        public static event EventCalculator getValues,addition, subration, multiplicaton,division;
        public static  void Subscribe()
        {
            eventLink += new EventCalculator(Operation.MainMenu);
            getValues = new EventCalculator(Operation.GetNumber);
            addition = new EventCalculator(Operation.Add);
            subration = new EventCalculator(Operation.Sub);
            multiplicaton = new EventCalculator(Operation.Mul);
            division = new EventCalculator(Operation.Div);

        }
        public static void EventHolder()
        {
            Subscribe();
            eventLink();
        }
    }
}