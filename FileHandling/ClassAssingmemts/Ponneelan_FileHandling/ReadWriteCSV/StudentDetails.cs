using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWriteCSV
{
    public enum Gender {Default,male,female}
    public class StudentDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        

        // public StudentDetails(string name, string fatherName, Gender gender,DateTime ,)
        // {

        // }
        
        
        
    }
}