using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Calculator
    {
        

        public int  Number1 { get; set; }
        public int  Number2 { get; set; }
        
        public dynamic Result { get; set; }

        public Calculator(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
           
        }
       
        public void Addition()
        {
            Result = Number1 + Number2;
            Console.WriteLine($"\nAddition of two numbers is {Result}");
        }
        public void Subraction()
        {
            Result = Number1 - Number2;
            Console.WriteLine($"\nSubraction of two numbers is {Result}");

        }
        public void Multiplication()
        {
            Result = Number1 * Number2;
            Console.WriteLine($"\nMultiplication of two numbers is {Result}");

        }
        public void Division()
        {
            Result = Number1 / Number2;
            Console.WriteLine($"\nDivison of two numbers is {Result}");

        }
        
    }
}