using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        private string _firstName = "";
        private string _lastName = "";

        private int _plz = 0;
    
        // a constructor
        public Person()
        {
            _firstName = "dummy";
            _lastName = "dummy";
        }

        // a constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // a function
        // as input
        public void SetPLZ(int plz)
        {
            _plz = plz;
        }

        // as output
        public int GetPLZ()
        {
            return _plz;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"Der Name der Person ist {_firstName} {_lastName} und die PLZ {_plz}");
        }
    }
}
