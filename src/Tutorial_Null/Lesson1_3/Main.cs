using System;
//using System.Collections.Generic;
using System.Linq;

namespace Tutorial_Null.Lesson1_3
{
    class Main
    {
        public void Run()
        {
            Person p = null;
            Console.WriteLine($"{p.name}");
            Console.WriteLine(p.name);
        }
    }
    class Person
    {
        public string name = String.Empty;
//        public string name = "init vlaue.";
    }
}
