using System;
using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class SetOperators
    {
        private readonly IList<Student> _studentList1 = new List<Student>
        {
            new Student {StudentId = 1, StudentName = "John", Age = 18},
            new Student {StudentId = 2, StudentName = "Steve", Age = 15},
            new Student {StudentId = 3, StudentName = "Bill", Age = 25},
            new Student {StudentId = 5, StudentName = "Ron", Age = 19}
        };

        private readonly IList<Student> _studentList2 = new List<Student>
        {
            new Student {StudentId = 3, StudentName = "Bill", Age = 25},
            new Student {StudentId = 5, StudentName = "Ron", Age = 19}
        };


        private readonly IList<string> _strList1 = new List<string> {"One", "Two", "Three", "Four", "Five"};
        private readonly IList<string> _strList2 = new List<string> {"Four", "Five", "Six", "Seven", "Eight"};


        public void DistinctOperator()
        {
            IList<string> strList = new List<string>
            {
                "One", "Two", "Three", "Two", "Three"
            };
            var distinctString = strList.Distinct();
            //One Two Three


            //Compare with object
            IList<Student> studentList = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "John", Age = 18},
                new Student { StudentId = 2, StudentName = "Steve", Age = 15},
                new Student { StudentId = 3, StudentName = "Bill", Age = 25},
                new Student { StudentId = 3, StudentName = "Bill", Age = 25},
                new Student { StudentId = 3, StudentName = "Bill", Age = 25},
                new Student { StudentId = 3, StudentName = "Bill", Age = 25},
                new Student {StudentId = 5, StudentName = "Ron", Age = 19}
            };

            var distinctStudents = studentList.Distinct(new StudentComparer());

            foreach (var student in distinctStudents)
            {
                Console.WriteLine(student.StudentName);
            }
            //John
            //Steve
            //Bil
            //Ron
        }

        class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentId == y.StudentId && x.StudentName.ToLower() == y.StudentName.ToLower())
                    return true;

                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.GetHashCode();
            }
        }

        public void ExceptOperator()
        {
            var result = _strList1.Except(_strList2);
            //One
            //Two
            //Three


            //Compare with object
            //Comparing with object is not working


            var resultedCOl = _studentList1.Except(_studentList2, new StudentComparer());

            foreach (var student in resultedCOl)
            {
                Console.WriteLine(student.StudentName);
            }
        }

        public void IntersectOperator()
        {

            var result = _strList1.Intersect(_strList2);

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

        public void UnionOperator()
        {
            var resultedCol = _studentList1.Union(_studentList2, new StudentComparer());

            foreach (var student in resultedCol)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}
