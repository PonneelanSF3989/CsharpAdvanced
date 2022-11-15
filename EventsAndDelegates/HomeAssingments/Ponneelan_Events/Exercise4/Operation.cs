using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4
{
    public static partial class Operation
    {
        public static Calculator newCalculator;
        public static void GetNumber()
        {
            Console.WriteLine("\nEnter the Number one");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Number two");
            int number2 = int.Parse(Console.ReadLine());

            newCalculator = new Calculator(number1,number2);
        }

        public static  void MainMenu()
        {
            int choice;
            do
            {
                
                Console.WriteLine("\n\nCalculator\n\n");

                getValues();
                Console.WriteLine("1. Addition\n2. Subraction\n3. Multiplicaton\n4. Division\n5. Exit");
                Console.WriteLine("\nEnter Your Choice ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: 
                    {
                        addition();
                        
                        break;
                    }
                    case 2: 
                    {
                        subration();
                        
                        break;
                    }
                    case 3: 
                    {
                        multiplicaton();
                        
                        break;
                    }
                    case 4: 
                    {
                        division();
                        Console.Clear();
                        break;
                    }
                    case 5: 
                    {
                        Console.Clear();
                        Console.WriteLine("Exit!!!");
                        break;
                    }
                }
            }while(choice != 5);
        }
        public static void Add()
        {
            newCalculator.Addition();
        }
        public static void Sub()
        {
            newCalculator.Subraction();
        }
        public static void Mul()
        {
            newCalculator.Multiplication();
        }
        public static void Div()
        {
            newCalculator.Division();
        }
        public static  void CallEvent()
        {
            
        }
    
    }
}