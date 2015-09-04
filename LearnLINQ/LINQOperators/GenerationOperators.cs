using System.Collections.Generic;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{
    public class GenerationOperators
    {
        private readonly IList<Student> _studentEmptyList = new List<Student>();

        public void DefaultIfEmptyOperator()
        {
            var newStudentWithOutValueList = _studentEmptyList.DefaultIfEmpty();
            // Count: 1 newStudentList.Count()
            //Element: null newStudentList.ElementAt(0) == null ? "null" : newStudentList.ElementAt(0).StudentName

            IList<int> intList = new List<int>();
            var newIntList = intList.DefaultIfEmpty();
            //Count: 1  newIntList.Count()
            //Element: 0 newIntList.ElementAt(0) == null ? "null" : newIntList.ElementAt(0).StudentName
            //0 is default value for int data type

            _studentEmptyList.Add(new Student
            {
                StudentId = 1,
                StudentName = "Bill"
            });

            var newStudentWithValueList = _studentEmptyList.DefaultIfEmpty();
            //Count: 1 newStudentWithValueList.Count(0)
            //Element: Bill newStudentWithValueList.ElementAt(0) == null ? "null" : newStudentWithValueList.ElementAt(0).StudentName 

        }

        public void EnumerableEmpty()
        {
            //Empty, Range and Repeat method are not extension method of IEnumerable<T>.
            //They are generic static method of static Enumerable class.

            var emptyStudentCollection = Enumerable.Empty<Student>();
            //Student Count: 0 emptyStudentColletion.Count()

            var emptyIntCollection = Enumerable.Empty<int>();
            //Int Count: 0 emptyIntCollection.Count()
        }
    }
}
