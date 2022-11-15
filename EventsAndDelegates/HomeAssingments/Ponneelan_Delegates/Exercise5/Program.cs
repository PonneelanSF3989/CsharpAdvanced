using System;
namespace Exericse5;
public delegate bool MyFilterDelegate (int value1 , int value2); 
class Program
{
    public static void Main(string[] args)
    {
        int [] array = new int[]{2,4,55,4,6,8,3,11,22,66,44,99,77,55,67,43,34,56,21,90,87,78};
        int choice ;
       do 
       {
        
         Console.WriteLine("\n Bubble Sorting Menu");
         Console.WriteLine("\n1. Assending Order\n2. Dessinding Order\n3. Exit\n\nEnter Your Choice ");
         choice = int.Parse(Console.ReadLine());
         switch(choice)
         {
            case 1: 
            {
                BuubleSort(array,IsGreater);
                PrintArray(array);
                break;
            }
            case 2: 
            {
                BuubleSort(array,IsLower);
                PrintArray(array);
                break;
            }
            case 3: 
            {
                
                Console.Clear();
                Console.WriteLine("\nExit");
                break;
            }
            
         }
       
       }while(choice != 3);


    }

    static void PrintArray(int [] array)
    {
        for (int i = 0 ; i < array.Length - 1 ; i++)
        {
            Console.Write(array[i]+" "); 
        }
        Console.WriteLine("\n\n");
    }

    static void BuubleSort(int [] array,MyFilterDelegate filter)
    {
        int temp;
        for (int i = 0 ; i < array.Length -1 ; i++)
        {
            for (int j  = 0; j < array.Length -1 -i ; j++)
            {
                if(filter (array[j],array[j+1]))
                {
                    temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }


    static bool IsGreater(int value1, int value2)
    {
        if (value1 > value2)
        {
            return true;
        }
        return false;
    }
    static bool IsLower(int value1, int value2)
    {
        if (value1 < value2)
        {
            return true;
        }
        return false;
    }
}