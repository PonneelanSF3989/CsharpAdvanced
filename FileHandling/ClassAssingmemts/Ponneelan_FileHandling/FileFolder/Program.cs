using System;
using System.IO;
using FileFolder;
namespace FileFolder;


class program 
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\PonneelanRamanathan\OneDrive - Syncfusion\Desktop\MyFolder"; 
        string folderPath = path + "/Ponneelan";

        if(!Directory.Exists(folderPath))
        {
            Console.WriteLine("\nFolder Not found \nNew Directory Created");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("\nDirectory Already Exist");
        }

        string filePath =  folderPath + "/newFile.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not Found \nSo, creating new File");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine("\nfile already exits");
        }




        Console.WriteLine("\nselect option \n\n2. Create Folder \n2. Create File\n3. Delete Folder \n4. Delete File");
        int choice =  int.Parse(Console.ReadLine());

        do
        {
            switch (choice)
        {
            case 1:
            {
                Console.WriteLine("Enter the folder name to create");
                string folderName = Console.ReadLine();
                string newPath = path + "/" + folderName;
                if(!Directory.Exists(newPath))
                {
                    Console.WriteLine("\nFolder Not found \nNew Directory Created");
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    Console.WriteLine("\nDirectory Already Exist");
                }
                break;
            }
            case 2:
            {
                Console.WriteLine("Enter the file name to create");
                string fileName = Console.ReadLine();
                Console.WriteLine("Enter the file Extension to create");
                string extension = Console.ReadLine();
                string newFile = path+"/"+fileName+"."+extension;
                if (!File.Exists(newFile))
                {
                    Console.WriteLine("\nFile Not found \nSo, create a New file");
                    File.Create(newFile);
                }
                else
                {
                    Console.WriteLine("\nFile Already Exist");
                }
                break;
            }
            case 3: 
            {
                foreach(string folders in Directory.GetDirectories(path))
                {
                    Console.WriteLine(folders);
                }
                Console.WriteLine("\nEnter the folder name to delte");
                string deleteFolder  = Console.ReadLine();
                string  newPath = path + "/" + deleteFolder;
                try
                {
                    foreach(string folders in Directory.GetDirectories(path))
                    {
                        if (deleteFolder == folders)
                        {
                            Directory.Delete(newPath);
                            Console.WriteLine("Folder delete Successfully");
                        }
                    }
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("\nDirectory Not Found");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                break;
            }
            case 4:
            {
                foreach(string files in Directory.GetFiles(path))
                {
                    Console.WriteLine(files);
                }
                Console.WriteLine("Enter the file name to delete");
                string fileNameToDelete = Console.ReadLine();
                Console.WriteLine("Enter the Extension of the file");
                string fileExtension = Console.ReadLine();
                string deleteFile = path + "/" +fileNameToDelete + "." + fileExtension;
                try
                {
                    foreach (string files in Directory.GetFiles(path))
                    {
                        if (files == deleteFile)
                        {
                            Console.WriteLine("\n FIle deleted sucessdully");
                            File.Delete(deleteFile);
                        }
                    }
                }
                catch (FileNotFoundException e )
                {
                    Console.WriteLine("\nFile not found");
                }
                break;
            }
        }
        }while (choice !=5);


    }
}