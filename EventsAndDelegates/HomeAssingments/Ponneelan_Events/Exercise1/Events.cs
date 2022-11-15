using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public delegate void StudentEvent();
    public class Events
    {
        public static event StudentEvent eventLink;
        public Events(){}
        public static void EventHolder()
        {
            eventLink();
        }
    }
}