using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Employee
    {
        //members -> variables,constants,methods,events,constructors etc.....
        //variables
        public string firstName = "Joe", lastName = "Doe", id = "101";
        public const string planet = "Earth";

        //methods-> Behaviours
        public void DoTask(string firstName,string lastName, string id,float hours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            //hours = 8;
            Console.WriteLine($"{firstName} {lastName} writes program in C# for {hours} hours over weekdays");
        }

    }
}
