using System;
using System.Collections.Generic;
namespace FilterDelegate;

public delegate bool MyFilterDelegate (Person p);



class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person(){Name = "vasanth",Age = 10};
        Person person2 = new Person(){Name = "Ponnelan",Age = 22};
        Person person3 = new Person(){Name = "Ravi",Age = 40};
        Person person4 = new Person(){Name = "Basker",Age = 50};
        Person person5 = new Person(){Name = "Ganesh",Age = 60};

        people.Add(person1);
        people.Add(person2);
        people.Add(person3);
        people.Add(person4);
        people.Add(person5);


        DisplayPeople("Child", people,IsChild);
        DisplayPeople("Adult", people,IsAdult);
        DisplayPeople("Senior", people,IsSenior);
        DisplayPeople("Voter", people,IsVoter);

    }



    static List<Person> people = new List<Person>();




    static bool IsChild(Person p)
    {
        return p.Age<=10;
    }
    static bool IsAdult(Person p)
    {
        if( p.Age>10 && p.Age<50)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
    static bool IsSenior(Person p)
    {
        return p.Age>50;
    }
    static bool IsVoter(Person p)
    {
        return p.Age>18;
    }





    static void DisplayPeople(string title,List<Person> people,MyFilterDelegate filter)
    {
        Console.WriteLine("People in :"+title+ "list are");
        foreach(Person p in people)
        {
            if (filter(p))
            {
                Console.WriteLine($"{p.Name} is {p.Age} year old");
            }
        }
    }


    
}