using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise5
{
    public delegate void FileEvents();
    public static partial class Operation
    {
        public static FileEvents eventLink,mainMenu,readFile,writeFile;

        public static void Subscribe()
        {
            eventLink += new FileEvents(CreateFiles);
            eventLink += new FileEvents(MaiMenu);
            readFile = new FileEvents(ReadFiles);
            writeFile = new FileEvents(WriteFiles);

        }

        public static void EventHolder()
        {
            Subscribe();
            eventLink();
        }
        
    }
}