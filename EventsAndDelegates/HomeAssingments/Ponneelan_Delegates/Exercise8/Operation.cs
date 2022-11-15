using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise8
{
    public  delegate void MyDelegate();
    public static  class Operation
    {
       
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
}