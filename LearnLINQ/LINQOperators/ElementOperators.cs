using System;
using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class ElementOperators
    {
        private readonly Helper _studentList = new Helper();

        public void ElementAtOperator()
        {
            #region ElementAt
            var student1 = _studentList.StudentData().ElementAt(2);
            //Bill
            var student2 = _studentList.StudentData().ElementAt(4);
            //Ron
            var student3 = _studentList.StudentData().ElementAt(6);
            //throws ArgumentOutOfRangeException
            #endregion

            #region ElementAtOrDefault

            var st = _studentList.StudentData().ElementAtOrDefault(2);
            //Bill
            var st2 = _studentList.StudentData().ElementAtOrDefault(6);
            //returns null because null is default value for object

            IList<int> intList = new List<int> { 1, 2, 3, 4, 5 };

            var intVal = intList.ElementAtOrDefault(6);
            //return 0 because 0 is default value for int

            #endregion
        }

        public void FirstOperator()
        {
            #region First
            var firstStudent = _studentList.StudentData().First();
            //John

            var firstTeenAgerStudent = _studentList.StudentData().First(s => s.Age > 12 && s.Age < 20);
            //Bill

            var student = _studentList.StudentData().First(s => s.Age > 30);
            //throws InvalidOperationException: Sequence contains no matching elements
            #endregion

            #region FirstOrDefault

            var firstStudent2 = _studentList.StudentData().FirstOrDefault();
            //John
            var firstTeenagerStudent = _studentList.StudentData().FirstOrDefault(s => s.Age > 12 && s.Age < 20);
            //Bill

            var student2 = _studentList.StudentData().FirstOrDefault(s => s.Age > 30);
            //null is default value for object

            #endregion
        }

        public void LastOperator()
        {
            #region Last

            var lastStudent = _studentList.StudentData().Last();
            //Ron
            var lastTeenagerStudent = _studentList.StudentData().Last(s => s.Age > 12 && s.Age < 20);
            //Ron

            var student = _studentList.StudentData().Last(s => s.Age > 30);
            //Throws InvalidOperationException: Sequence contains no matching element

            #endregion

            #region LastOrDefault

            var lastStudent2 = _studentList.StudentData().LastOrDefault();
            //Ron
            var lastTeenagerStudent2 = _studentList.StudentData().LastOrDefault(s => s.Age > 12 && s.Age < 20);
            //Ron
            var student2 = _studentList.StudentData().LastOrDefault(s => s.Age > 30);
            //null is default value for object

            #endregion
        }

        public void SingleOperator()
        {
            IList<int> intList = new List<int> { 1 };

            #region Single

            var singleStudent = _studentList.StudentData().Single();
            //throws InvalidOperationException as collection contains more than one element 
            var singleTeenAgerStudent = _studentList.StudentData().Single(s => s.Age > 12 && s.Age < 20);
            //Ron
            var intVal = intList.Single();
            //returns 1

            #endregion

            #region SingleOrDefault

            IList<Student> studentList = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "John", Age = 24},
                new Student { StudentId = 2,StudentName = "Moin", Age = 14},
                new Student { StudentId = 3 , StudentName = "Bill", Age = 20},
                new Student {StudentId = 4, StudentName = "Ram", Age = 20}
            };

            IList<int> intList2 = new List<int> { 1, 2, 3, 4, 5 };

            var singleTeenagerStudent = studentList.SingleOrDefault(s => s.Age > 20 && s.Age < 20);
            //Moin

            var intVal2 = intList.SingleOrDefault(s => s > 4);
            //single integer greater than 4 = 5 from intlist2

            var intVal3 = intList.SingleOrDefault(s => s > 10);
            //single integer greater then 10 = 0 from intlist2
            #endregion

        }
    }
}
