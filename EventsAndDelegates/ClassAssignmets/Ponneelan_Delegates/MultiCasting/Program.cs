using System;
namespace MultiCasting;


public delegate int Calculator (int method1);
class Program
{
    
    static int value  = 10;
    public static int Add(int number)
    {
        value += number;
        return value;
    }
    public static int Multiply(int number)
    {
        value *= number;
        return value;
    }

    public static int GetNumber()
    {
        return value;
    }
    public static void Main(string[] args)
    {
        

        Calculator cal1 = new Calculator(Add);
        cal1 += new Calculator(Multiply);

        cal1(5);
        
        Console.WriteLine("\ncall of GetNum    " + GetNumber()+"\n");
    }
}