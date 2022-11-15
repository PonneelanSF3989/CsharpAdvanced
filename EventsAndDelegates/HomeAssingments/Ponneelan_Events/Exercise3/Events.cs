

namespace Exercise3
{
   public delegate void EventHandler();
    public static class Events
    {
        public static event EventHandler eventLink;

        public static void EventHolder()
        {
            eventLink();
        }
    }
}