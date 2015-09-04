using System;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class GroupingOperators
    {
        private readonly Helper _studentList = new Helper();

        public void GroupByOperators()
        {
            #region Query Syntax 

            var groupedQuery = from s in _studentList.StudentData()
                               group s by s.Age;

            foreach (var group in groupedQuery)
            {
                Console.WriteLine("Age Group: {0}", group.Key); //Each Group has a Key

                foreach (var student in group)
                {
                    Console.WriteLine("Student Name: {0}", student.StudentName);
                }
            }   
            #endregion

            #region Method Syntax

            var groudedMethod = _studentList.StudentData().GroupBy(s => s.Age);

            foreach (var group in groudedMethod)
            {
                Console.WriteLine("Age Group: {0}", group.Key); //Each Group has a Key

                foreach (var student in group)
                {
                    Console.Write("Student Name: {0}", student.StudentName);
                }
            }

            #endregion
        }

        public void ToLookUpOperator()
        {
            #region  Method Syntax  
            //Only in Method Syntax

            var lookupResult = _studentList.StudentData().ToLookup(s => s.Age);

            foreach (var lookup in lookupResult)
            {
                Console.WriteLine("Age Look up : {0}", lookup.Key); //Each group has a key

                foreach (var student in lookup)
                {
                    Console.WriteLine("Student Name: {0}", student.StudentName);
                }
            }

            #endregion
        }
    }
}
