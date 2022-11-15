using System;
namespace Exercise2;

public delegate int MyCalculator(int num1, int num2 );
class Program
{
    
    
    public static void Main(string[] args)
    {
        // Single Delegate
        MyCalculator calculator1  = new MyCalculator(Addition);
        Console.WriteLine(calculator1(10,10));
        MyCalculator calculator2  = new MyCalculator(Subraction);
        Console.WriteLine(calculator2(10,10));
        MyCalculator calculator3  = new MyCalculator(Multiplication);
        Console.WriteLine(calculator3(10,10));
        MyCalculator calculator4  = new MyCalculator(Division);
        Console.WriteLine(calculator4(10,10));


        //Multi delegates
        MyCalculator newCalculator = new MyCalculator(Addition);
        newCalculator += new MyCalculator(Subraction);
        newCalculator += new MyCalculator(Multiplication);
        newCalculator += new MyCalculator(Division);

        Console.WriteLine();
        Console.WriteLine(newCalculator(10,10));// return output 1 because return the last method output (division)
    }

    public  static int Addition(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    public static int Subraction(int number1, int number2)
    {
        int result = number1 - number2;
        return result;
    }
    public static int Multiplication(int number1, int number2)
    {
        int result = number1 * number2;
        return result;
    }
    public static int Division(int number1, int number2)
    {
        int result = number1 / number2;
        return result;

    }
}