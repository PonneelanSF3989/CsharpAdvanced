using System;
using System.IO;
namespace ReadWriteTxtFile;

class program
{
    public static void Main(string[] args)
    {
       if (!Directory.Exists("TestFolder"))
       {
            Console.WriteLine("\n creating new folder");
            Directory.CreateDirectory("TestFolder");
       }
       else
       {
        Console.WriteLine("Folder Exist");
       }


       if (!File.Exists("TestFolder/Test.txt"))
       {
            Console.WriteLine("\nCreate new file");
            File.Create("TestFolder/Test.txt");
       }
       else 
       {
            Console.WriteLine("\nFile already exist");
       }

        int choice;
        

        do
        {
        Console.WriteLine("\nselect option\n\n1. Create folder \n 2. delete folder \n3. exit");
        choice  = int.Parse(Console.ReadLine());

        switch (choice)
        {
          
           
            case 1:
            {
                string line;
                StreamReader sr = null;
                try
                {
                    sr = new StreamReader("TestFolder/Test.txt");
                    line = sr.ReadLine();
                    while(line!=null)
                    {
                        Console.WriteLine(line);
                        sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sr.Close();
                }
                break;
            }
            case 2:
            {
                string newlIne ;
                StreamWriter sw =null;
                string[] old = File.ReadAllLines("TestFolder/Test.txt");
                try
                {
                    sw = new StreamWriter("TestFolder/Test.txt");
                    Console.WriteLine("\nEnter the content to add the file");
                    newlIne = Console.ReadLine();
                    string old1 = "";
                    foreach(string lines in old)
                    {
                        old1 = old1+"\n"+lines;
                    }
                    old1= old1 +"\n"+newlIne;
                    sw.WriteLine(old1);

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sw.Close();
                }
                break;
            }
        
        
        }

        }while (choice !=0);

    }
}