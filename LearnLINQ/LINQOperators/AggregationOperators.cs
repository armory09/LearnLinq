using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class AggregationOperators
    {
        readonly Helper _studentList = new Helper();
        public void AggregateOperator()
        {
            

            IList<string> strList = new List<string>
            {
                "One", "Two", "Three", "Four", "Five"
            };

            var outputWithOutSeeed = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            //one, Two, Three, Four, Five
            //^s1  ^s2   ^s2   ^s2  ^s2

            var outputWithSeedstring = _studentList.StudentData().Aggregate<Student, string>(
                "Student Names: ", (str, s) => str += s.StudentName + ",");

            //Student Names: John, Moin, Bill, Ram, Ron
        }

        public void AverageOperators()
        {
            var avgAge = _studentList.StudentData().Average(s => s.Age);
            //19.6
        }

        public void CountOperators()
        {
            var numOfStudents = _studentList.StudentData().Count();
            //5
            var numberOfStudents = _studentList.StudentData().Count(s => s.Age >= 18);
            // 3

            //Query syntax
            var totalAge = (from s in _studentList.StudentData()
                    select s.Age).Count();
        }

        public void MaxOperators()
        {
            var maxAge = _studentList.StudentData().Max(s => s.Age);
            //21
        }

        
    }
}
