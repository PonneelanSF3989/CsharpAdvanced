using System;
using System.IO;
using System.Collections.Generic;
namespace ReadWriteCSV;

class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("\ncreating nee folder ");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            Console.WriteLine("\nFolder exist");
        }
        if (!File.Exists("TestFolder/Data.csv"))
        {
            Console.WriteLine("\ncreating new file");
            File.Create("TestFolder/Data.csv");
        }
        else 
        {
            Console.WriteLine("\nfile exist");
        }





        List<StudentDetails> studentData = new List<StudentDetails>();

        studentData.Add(new StudentDetails(){Name = "Ravi",FatherName = "Ettaparajan" , Gender = Gender.male, DOB = new DateTime(2000,10,17)});
        studentData.Add(new StudentDetails(){Name = "Raj",FatherName = "jaya" , Gender = Gender.male, DOB = new DateTime(2000,10,17)});
        studentData.Add(new StudentDetails(){Name = "kavi",FatherName = "moorthi" , Gender = Gender.male, DOB = new DateTime(2000,10,17)});
        studentData.Add(new StudentDetails(){Name = "mohan",FatherName = "poopathi" , Gender = Gender.male, DOB = new DateTime(2000,10,17)});
        Insert(studentData);
        Display();
        
    
    }

    static void Insert(List<StudentDetails> list)
    {
        
        StreamWriter sw =null;
        sw = new StreamWriter(File.OpenWrite("TestFolder\\Data.csv"));

        try
        {
            foreach(StudentDetails student in list)
        {
            sw.WriteLine(student.Name +","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy"));
        }
        }
        catch(Exception e)
        {
            
            Console.WriteLine(e);
        }
        finally
        {
            sw.Close();
        }
    }


    static void Display()
    {

        StreamReader sr = null;
        List<StudentDetails> list1 = new List<StudentDetails>();
        if (File.Exists("TestFolder/Data.csv"))
        {
            
            sr = new StreamReader(File.OpenRead("TestFolder\\Data.csv"));
           


            while(!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var values = line.Split(',');
                if (values[0] !="")
                {
                    list1.Add(new StudentDetails(){Name = values[0],FatherName = values[1],Gender =Enum.Parse<Gender>(values[2].ToString()), DOB = DateTime.ParseExact(values[3].ToString(),"dd/MM/yyyy",null)});
                }
            }

        }
        else
        {
            Console.WriteLine("\nfile exist");
        }

        sr.Close();

        foreach(StudentDetails student in list1)
        {
            Console.WriteLine($"Name : {student.Name}   Father Name : {student.FatherName}   Gender : {student.Gender}  DOB : {student.DOB}");
        }



    }

}