using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyPerson
    {
        private int _age = 0;
        public MyPerson(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
