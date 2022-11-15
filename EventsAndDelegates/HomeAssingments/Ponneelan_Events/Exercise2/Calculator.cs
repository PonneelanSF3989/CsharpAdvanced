using System;

namespace Exercise2
{
    public class Calculator
    {
        

        public int  Number1 { get; set; }
        public int  Number2 { get; set; }
        public dynamic Result { get; set; }
        
       
        
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