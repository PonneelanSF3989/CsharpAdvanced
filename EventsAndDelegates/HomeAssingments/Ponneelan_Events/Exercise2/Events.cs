using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public delegate void EventHandler();
    public static class Events
    {
       
        public static event  EventHandler eventLink;
        public  static void EventHolder()
        {
            eventLink();
        }

    }
}