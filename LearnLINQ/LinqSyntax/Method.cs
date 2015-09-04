using System;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LinqSyntax
{
    public class Method
    {
        public static void MethodSyntax()
        {
            var studentList = new Helper();

            var teenAgeStudent = studentList.StudentData().Where(s => s.Age > 12 && s.Age < 20).ToList();

            foreach (var list in teenAgeStudent)
            {
                Console.WriteLine(list.StudentName);
            }
        }
    }
}
