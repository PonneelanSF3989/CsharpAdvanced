 using System;

namespace Exercise7;

public delegate void CheckEligibleDelegate(int percentage,string degree );
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Degree");
        string degree = Console.ReadLine().ToUpper();

        Console.WriteLine("Entet Percentage");
        int percentage = int.Parse(Console.ReadLine());

        CheckEligibleDelegate newDelegate= new CheckEligibleDelegate(CheckEligible);
        newDelegate(percentage,degree);
    }

    static void CheckEligible(int percentage, string degree)
    {
        if (degree == "BE")
        {
            if (percentage > 60)
            {
                Console.WriteLine("Elegible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        else if (degree == "MBBS")
        {
            if (percentage > 95)
            {
                Console.WriteLine("Elegible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        else if (degree == "BDS")
        {
            if (percentage > 90)
            {
                Console.WriteLine("Elegible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        else if (degree == "AGRI")
        {
            if (percentage > 80)
            {
                Console.WriteLine("Elegible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}