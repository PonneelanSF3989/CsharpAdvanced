using System;
using System.IO;

namespace Exercise5
{
    public static partial  class Operation
    {
        public static void CreateFiles()
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
        }

        public static void ReadFiles()
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
                    line = sr.ReadLine();
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
        }
        public static void WriteFiles()
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
        }
        public static void MaiMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\nselect option\n\n1. Read File \n2. Write file \n3. exit");
                choice  = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    readFile();
                    break;
                }
                case 2:
                {
                    writeFile();
                    break;
                }
            
            
            }

            }while (choice !=3);

        }
    
    }
}