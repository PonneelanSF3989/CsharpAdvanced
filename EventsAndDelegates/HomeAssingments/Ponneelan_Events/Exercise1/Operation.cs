using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public static class Operation
    {
        public static void CallEvent()
        {
            Events event1 = new Events();
            StudentDetails student = new StudentDetails("Vasanth","Ramanathna",100,100,90);

            Events.eventLink += new StudentEvent(student.DisplayDetails);
            Events.eventLink += new StudentEvent(student.Caluclate);
            Events.eventLink += new StudentEvent(student.MarkDetails);
            Events.EventHolder();
        }

    }
}