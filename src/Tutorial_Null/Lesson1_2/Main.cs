using System;
//using System.Collections.Generic;
using System.Linq;

namespace Tutorial_Null.Lesson1_2
{
    class Main
    {
        public void Run()
        {
            Console.WriteLine($"{new Person().name}");
        }
    }
    class Person
    {
        public string name = String.Empty;
    }
}
