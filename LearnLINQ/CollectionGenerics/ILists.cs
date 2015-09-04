using System;
using System.Collections.Generic;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.CollectionGenerics
{
    public class ILists
    {
        public ILists()
        {
            //initialize IList int and add item
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            //initialize IList string and add item
            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);
            //initialize IList custom elements and add item
            IList<Student> studentList = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Jonathan", Age = 24},
                new Student { StudentId = 2, StudentName = "Keneth", Age = 22}
            };
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());

            //add items using AddRange(IEnumerable<T> collection)
            List<Student> ctr = new List<Student>();
            ctr.AddRange(studentList);
            //output use foreach
            ctr.ForEach(s => Console.WriteLine(s.StudentName));
            //Jonathan
            //Keneth

            foreach (var student in ctr)
            {
                Console.WriteLine(student.StudentName);
            }
            //Jonathan
            //Keneth

            //Access using index
            int elem = intList[1]; // return 20  
        }

        public static void Print(IList<string> list)
        {
            Console.WriteLine("Count {0}", list.Count);
            foreach (var ls in list)
            {
                Console.WriteLine(ls);
            }
        }  
    }
}
