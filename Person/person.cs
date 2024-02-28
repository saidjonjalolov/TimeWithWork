using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeWithWork.Person
{
    public class person
    {
       public string firstName;
       public string lastName;
       public int age;
       public string FirstName 
       {
        get 
        {
            return firstName;
        }
       }
       public string LastName{
        get {
            return lastName;
        }
       }
       public int Age {
        get {
            return age;
        }
       }
    }
}