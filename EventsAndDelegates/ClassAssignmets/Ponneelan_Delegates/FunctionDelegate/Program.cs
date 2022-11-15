using System;
namespace FunctionDelegate;

class Program
{
    static  double Sum(int num1,int num2)
    {
        return num1+num2;
    }

    static double Subract(int num1,int num2)
    {
        return num1 - num2;
    }

    static double Calculate (Func<int,int,double> operation1,int x,int y) 
    {
        return operation1(x,y);
    }

    public static void Main(string[] args)
    {
        
        // Func<int,int,double> operation = Sum;

        // //operation += Subract;

        // Console.WriteLine("sum      "+ operation(5,5));


        Console.WriteLine("Sum  "+ Calculate(Sum,10,10));
        Console.WriteLine("Sum  "+ Calculate(Subract,20,10));


    }
}