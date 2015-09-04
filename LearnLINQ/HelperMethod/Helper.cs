using System.Collections.Generic;

namespace LearnLINQ.HelperMethod
{
    public class Helper
    {    
        public IList<Student> StudentData()
        {
            IList<Student> studentList = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "John", Age = 18 },
                new Student { StudentId = 2, StudentName = "Moin", Age = 21 },
                new Student { StudentId = 3, StudentName = "Bill", Age = 18 },
                new Student { StudentId = 2, StudentName = "Ram", Age = 20 },
                new Student { StudentId = 5, StudentName = "Ron", Age = 21 }

            };
            return studentList;
        }  
    }  
}
