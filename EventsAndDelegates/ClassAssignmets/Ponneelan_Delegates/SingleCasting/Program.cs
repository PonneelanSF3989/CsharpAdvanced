using System;
namespace SingleCasting;

public delegate int Calculator(int value);

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
        Calculator cal2 = new Calculator(Multiply);

        //using cal1 object
        Console.WriteLine("cal1 value " + cal1(20));

        //cal multipy usig cla2 obj
        Console.WriteLine("Cal2 value "+ cal2(10));

        //Calculator cal3 = new Calculator(GetNumber);  ////No overload for 'GetNumber' matches delegate 'Calculator'

        //calling directly
        Console.WriteLine("Direct call of Add" + Add(10));
        Console.WriteLine("Direct call of Multilpy" + Multiply(10));
        Console.WriteLine("Direct call of GetNum" + GetNumber());


    }
}