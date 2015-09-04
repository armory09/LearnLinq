using System;
using System.Collections;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class FilteringOperators
    {  
        public FilteringOperators() 
        { 
        }

        void WhereClause()
        {
            Helper studentList = new Helper();
            var filteredResult = from s in studentList.StudentData()
                                 where s.Age > 12 && s.Age < 20
                                 select s.StudentName;
            //John
            //Stebe
            //Ron 

            //using method syntax linq
            var filteredResult2 = studentList.StudentData().Where(s => s.Age < 12 && s.Age < 20);

            //return even index in studenlist
            var filteredResult3 = studentList.StudentData().Where((s, i) =>
            {
                if (i % 2 == 0)// if it is even element
                {
                    return true;
                }
                return false;
            });

            foreach (var student in filteredResult3)
            {
                Console.WriteLine(student.StudentName);
                //John
                //Bill
                //Ron
            }
            //Multiple Where clause
            //Query Syntax LINQ
            var resultsQ = from s in studentList.StudentData()
                           where s.Age > 12
                           where s.Age < 20
                           select s;
            //Method Sytax LINQ
            var resultsM = studentList.StudentData().Where(s => s.Age < 12).Where(s => s.Age < 20).ToList();
        }

        public void OfTypeClause()
        {
            //OfType operator filters the collection based on the ability to cast to a specific type
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student
            {
                StudentId    = 1,
                StudentName = "Bill"
            });

            //output string ony
            var stringResult = from s in mixedList.OfType<string>()
                select s;
            //One
            //Two
            var studentOut = from s in mixedList.OfType<Student>()
                select s;

            var mthod = mixedList.OfType<Student>().ToList();

            foreach (var student in mthod)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}
