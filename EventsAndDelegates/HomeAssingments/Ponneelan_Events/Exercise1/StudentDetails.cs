using System;

namespace Exercise1
{
    public class StudentDetails
    {
        private static int s_StudentID = 1000;

       

        public string StudentID { get; set; }
        
        public string StudentName { get; set; }
        
        public string FatherName { get; set; }
        
        public int PhysicsMark { get; set; }
        public int  ChemistryMark { get; set; }
        
        public int MathMark { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        
        
        
        
        
        
        public StudentDetails(string studentName, string fatherName, int physicsMark, int chemistryMark, int mathMark)
        {   s_StudentID++;
            StudentID = "SID"+studentName;
            StudentName = studentName;
            FatherName = fatherName;
            PhysicsMark = physicsMark;
            ChemistryMark = chemistryMark;
            MathMark = mathMark;
        }

        public void DisplayDetails()
        {   Console.Clear();
            Console.WriteLine($"\nStuden ID : {StudentID}\nStuden Name : {StudentName}\nFather Name : {FatherName}\n");
        }
        public void MarkDetails()
        {
            
            Console.WriteLine($"Phisics Mark : {PhysicsMark}\nChemistry Mark : {ChemistryMark}\nMath Mark : {MathMark}\nTotal : {Total}\nAverage : {Math.Round(Average,2)}");
        }
        public void Caluclate()
        {
            Total = PhysicsMark+ChemistryMark+MathMark;
            Average = ((double)(Total)/300) * 100;
        }
    }
}