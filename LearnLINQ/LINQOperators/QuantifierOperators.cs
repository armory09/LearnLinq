using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{   
    //All, Any, Contains are not supported in query syntax in C# or in VB.NET
    public class QuantifierOperators
    {
        //bool isallStudentTeenager = 
        readonly Helper _studentList = new Helper();


        //paramater _studenList
        public bool AllOperator(IList<Student> student )
        {
            return student.All(s => s.Age > 12 && s.Age < 20);
            //return false
            //evaluate all if they meet the condition
        }

        //parameter _studentList
        public bool AnyOperator(IList<Student> student)
        {
            return student.Any(s => s.Age > 12 && s.Age < 20);
            //return true
            //evaluate any would meet the condition
        }

        public bool ContainsOperator(IList<Student> students)
        {
            var ctr = new Student
            {
                StudentName = "er",
                Age = 20,
                StudentId = 2
            };

            return students.Contains(ctr, new StudentCompare());
        }    
        //to compare values
        class StudentCompare : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentId == y.StudentId && x.StudentName.ToLower() == y.StudentName.ToLower() && x.StudentId == y.StudentId)
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
