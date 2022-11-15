using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Application

{
    
    public static class Operators
    {
        private static List<CustomerDetails> customerData = new List<CustomerDetails>();
        private static CustomerDetails customer;       
        public static void MainMenu()
        {
             int choice;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            Console.WriteLine();
            Console.WriteLine("Enter your Option");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine();
                    GetDetails();
                    break;
                }
                case 2:
                {
                    Console.WriteLine();
                    Login();
                    break;
                }
            }

        }while(choice != 3);
        }
        public static void Login()
        {
            //call default custructor to access methos
            CustomerDetails defaultCus = new CustomerDetails();

            string meterId;
            //get the meter id from user
                Console.WriteLine("Enter the customer Id ");
                meterId = Console.ReadLine();

                foreach (CustomerDetails cus in customerData)
                {
                    if (meterId == cus.MeterId)
                    {
                        customer = cus;
                        SubMenu();
                    }
                }

        }
        public static void GetDetails()
        {
            char isRepeat;
            do
            {
                Console.WriteLine("Enter the Customer Name");
                string name = Console.ReadLine();

                //phone number
                Console.WriteLine("Enter the Phone Number");
                long phone = long.Parse(Console.ReadLine());

                //mail id
                Console.WriteLine("enter the Mail Id");
                string mail = Console.ReadLine();

                //instance of the CustomerDetais class 
                CustomerDetails customer = new CustomerDetails(name,mail,phone);

                //add the insance to list
                customerData.Add(customer);

                //display the meter Id
                Console.WriteLine();
                Console.WriteLine($"Your Meter Id Is : {customer.MeterId}");
                Console.WriteLine();

                //add another user
                Console.WriteLine("Do you want add another user press 'y' else press 'n' ");
                isRepeat = char.Parse(Console.ReadLine().ToLower());
            }while(isRepeat == 'y');

        }
        public static void SubMenu()
        {
            int subMenuChoice;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Calculate Bill");
                            Console.WriteLine("2. Exit");
                            Console.WriteLine();

                            //get choice
                            subMenuChoice = int.Parse(Console.ReadLine());
                            
                            switch(subMenuChoice)
                            {
                                case 1:
                                {
                                    CalcuteBill();
                                    break;
                                }
                            }
                        }while(subMenuChoice !=2);
        }
    
        public static void CalcuteBill()
        {
            //get the total unit used
            double totalUnit;
            Console.WriteLine("Enter the Total unit");
            totalUnit = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //display bill
            Console.WriteLine($"Your Bill amount is {customer.ClaculateAmount(customer.CalculateUnit(totalUnit))}");
            Console.WriteLine();
        }
    
    }
}