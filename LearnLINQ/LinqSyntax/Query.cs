using System;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LinqSyntax
{
    public class Query
    {
        public static void QuerySyntax()
        {
            var studentList = new Helper();
            var teenAgeStudent = from s in studentList.StudentData()
                                 where s.Age > 12 && s.Age < 20
                                 select s;

            foreach (var list in teenAgeStudent)
            {
                Console.WriteLine(list.StudentName);
            }
        }
    }
}
