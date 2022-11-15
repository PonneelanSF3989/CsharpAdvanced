using System;
namespace Exercise6;

public delegate bool MyCheckEligibilityFilter (int percentage);
class Program
{
    public static void Main(string[] args)
    {
        int percentage = 70;
        Checkeligibility(IsEligible,percentage);
    }

    static void Checkeligibility( MyCheckEligibilityFilter filter,int percentage )
    {
        if (filter(percentage))
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            Console.WriteLine("Not Eligible");
        }
    }

    static bool IsEligible(int percentage)
    {
        if (percentage > 75)
        {
            return true;
        }
        return false;
    }
}