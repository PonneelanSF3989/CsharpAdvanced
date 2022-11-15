using System;
namespace Exercise4;
class Program
{
    public static void Main(string[] args)
    {
         static double Mark (Func<int,int,int,int,int,double> function, int mark1,int mark2, int mark3, int mark4,int mark5)
        {
            return function(mark1,mark2,mark3,mark4,mark5);
        }

        double Percentage(int mark1,int mark2, int mark3, int mark4,int mark5)
        {
            double percentage;
            percentage = ((double)(mark1+ mark2+ mark3+mark4+mark5)/500) * 100;
            return percentage;
        }

        double Average(int mark1,int mark2, int mark3, int mark4,int mark5)
        {
            double average;
            average = ((double)(mark1+ mark2+ mark3+mark4+mark5)/5);
            return average;
        }


        Console.WriteLine("Percentage : "+ Mark(Percentage,80,90,90,90,90));
        Console.WriteLine("Average : "+ Mark(Average,80,90,90,90,80));
    }
}