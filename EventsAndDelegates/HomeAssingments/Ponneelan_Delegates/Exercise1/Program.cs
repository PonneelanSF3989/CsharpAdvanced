using System;
namespace Exercise1;

public delegate void Welcome();
class Program
{
    static int i = 0;
    static void Method1( )
    {
       i++;
        Console.WriteLine($"\nWelcome {i}");
    }
    static string Method2()
    {
        return "WelcomeAgain";
    }
    static void Method3(string name)
    {
       Console.WriteLine($"Welcom    {name}");
    }


    static string GiveWelcome(Func<string> function)
    {
        return function();
    }

    static void ActionDelegate(Action<string>action ,string  name)
    {
        action(name);
        
    }
    public static void Main(string[] args)
    {
        Welcome newDelegate = new Welcome(Method1);// Single Delegate
        newDelegate();

        Welcome newDelegate1 = new Welcome(Method1);// Multi Delegate
        newDelegate1 += new Welcome(Method1);
        newDelegate1();

        //Function Delegate
        Console.WriteLine(GiveWelcome(Method2));

        //Action Delegate
        ActionDelegate(Method3,"vasanth");
    }
}