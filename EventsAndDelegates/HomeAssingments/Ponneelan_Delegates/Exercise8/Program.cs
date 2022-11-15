using System;
namespace Exercise8;

public delegate void Calculator(); 
public delegate int Calculator1(int value1, int value2);
class program
{
    static Calculator newCalculator = new Calculator(MainMenu);
    static Calculator1 cal1 = new Calculator1(Operation.Addition);
    static Calculator1 cal2 = new Calculator1(Operation.Subraction);
    static Calculator1 cal3 = new Calculator1(Operation.Multiplication);
    static Calculator1 cal4 = new Calculator1(Operation.Division);


    
    public static void Main(string[] args)
    {
        newCalculator();

    }

     public static void MainMenu()
    {
        int choice ;
        do
        {
            Console.WriteLine("\n\nCalculator menu");

            Console.WriteLine("\nenter the number one");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nenter the number two");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n1. addition\n2. subration\n3. multiplication\n4. division\n5. exit\n\nenter your choice : ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: 
                {
                    Console.WriteLine("Addition     "+cal1(number1,number2));
                    break;
                }
                case 2: 
                {
                    Console.WriteLine("Subration    "+cal2(number1,number2));
                    break;
                }
                case 3: 
                {
                    Console.WriteLine("Multipication : "+cal3(number1,number2));
                    break;
                }
                case 4: 
                {
                    Console.WriteLine("Division   "+cal4(number1,number2));
                    break;
                }
                case 5: 
                {
                    Console.WriteLine("\n\nexit!!!");
                    break;
                }
            }
        }while(choice != 5);

    }
}