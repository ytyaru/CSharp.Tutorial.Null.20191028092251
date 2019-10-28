using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial_Null.Lesson0
{
    class Main
    {
        public void Run()
        {
            Code0();
            Code1();
            Code2();
            Code2_0();
            Code2_1();
        }
        private void Code0()
        {
            int a = 0;
//            int b = null; // error CS0037: Null 非許容の値型であるため、Null を 'int' に変換できません
            int? c = null;
            int? d = 0;
            Console.WriteLine($"a: {a}, c: {c}, d: {d}");
        }
        private void Code1()
        {
            string a = "A";
            string b = null;
            string? c = "C";
            string? d = null;
            Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}");
        }
        private void Code2()
        {
            List<int> list0 = null;
//            Console.WriteLine($"list.Count: {list0.Count}"); // System.NullReferenceException
            Console.WriteLine($"list.Count: {list0?.Count}");
            List<int>? list1 = null;
//            Console.WriteLine($"list.Count: {list1.Count}"); // System.NullReferenceException
            Console.WriteLine($"list.Count: {list1?.Count}");
        }
        private void Code2_0()
        {
            List<int> list0 = null;
            List<int> list1 = list0 ?? new List<int>() { 1, 3, 5 };
            Console.WriteLine($"list1.Count: {list1.Count}");
        }
        private void Code2_1()
        {
            List<int> list0 = null;
            List<int> list1 = new List<int>() { 1, 3, 5 };
            List<int> list2 = list0 ?? list1;
            Console.WriteLine($"list2.Count: {list2.Count}");
        }
    }
}
