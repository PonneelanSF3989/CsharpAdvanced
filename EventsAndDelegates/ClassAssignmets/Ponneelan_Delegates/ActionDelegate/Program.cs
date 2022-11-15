using System;
namespace ActionDelegate;

class Program
{

    static void Add(int x,int y)
    {
        Console.WriteLine("Addiction    "+ (x+y));
    }
     static void Subract(int x,int y)
    {
        Console.WriteLine("Subraction    "+ (x-y));
    }

    static void Calculator (Action<int,int> acton, int x,int y)
    {
        
        acton (x,y);
    }
    public static void Main(string[] args)
    {
        // Action<int,int> action = Add;
        // action +=Subract;
        // action(20,10);
        Calculator(Add,10,20);
    }
}