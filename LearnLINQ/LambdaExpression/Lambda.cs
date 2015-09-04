using System;
using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LambdaExpression
{
    public class Lambda
    {
        private delegate bool IsTeenAger(Student student);

        public readonly IList<Student> StudentList = new List<Student>
        {
            //add some item to the List
            new Student { },
            new Student { }
        };

        public void FuncMethod()
        {     
            Func<Student, bool> isStudentTeenAger = s => s.Age < 12 && s.Age < 20;

            var teenStudents = StudentList.Where(isStudentTeenAger).ToList();
        }

        public void FuncQuery()
        {
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

            var teenStudents = from s in StudentList
                where isStudentTeenAger(s)
                select s;

            var t = StudentList.Where(isStudentTeenAger).ToList();
        }

        public static bool FuncLinq()
        {
            Student std = new Student();

            //using delegate
            IsTeenAger isStudentTeen = s => s.Age > 12 && s.Age < 20;

            isStudentTeen(std); // false

            //using Func delegate has return and input
            Func<Student, bool> isStudentteenager = s => s.Age > 12 && s.Age < 20;

            bool isTeen = isStudentteenager(std); //false

            return isTeen;
        }

        //bool IsStudentTeenAger(Student s)
        //{
        //    return s.Age > 12 && s.Age < 20;
        //}

        public static void ActionLinq()
        {
            //Action delegate has only input parameter
            Action<IEnumerable<Student>> printStudentDetail = s =>
            {
                foreach (var student in s)
                {
                    Console.WriteLine("Name: {0} Age: {1}", student.StudentName, student.Age);
                }
            };
               
            var helper = new Helper();

            printStudentDetail(helper.StudentData());
        } 
    }
}
