using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuultiCastingEvent
{
    public delegate void EventManeger();
    public class Event
    {
        private string  _eventName;
        public static event EventManeger eventLink;
        public Event(string eventName)
        {
            _eventName = eventName;
        }
        static int i;
        public  void StartEvent ()
        {
            ++i;
            Console.WriteLine($"Event no {i} is {_eventName} is started");
        }

        public static void EventHolder()
        {
            i = 0;
            eventLink();
        }

        
    }
}