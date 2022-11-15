using System;
namespace MuultiCastingEvent;

class program
{
    public static void Main(string[] args)
    {
        
        Event event1 = new Event("Quiz");
        Event event2 = new Event("Aptidute");
        Event event3 = new Event("Presentation");
        Event event4 = new Event("Games");
        Event event5 = new Event("Workshop");


        Event.eventLink += new EventManeger(event1.StartEvent);
        Event.eventLink += new EventManeger(event2.StartEvent);
        Event.eventLink += new EventManeger(event3.StartEvent);
        Event.eventLink += new EventManeger(event4.StartEvent);
        Event.eventLink += new EventManeger(event5.StartEvent);

        Event.EventHolder();


    }
}