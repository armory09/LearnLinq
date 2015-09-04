using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LearnLINQ.HelperMethod;

namespace LearnLINQ.LINQOperators
{

    public class JoiningOperators
    {
        readonly IList<Standard> _standartList = new List<Standard>
        {
            new Standard { StandardId = 1, StandardName = "Standard 1"},
            new Standard { StandardId = 2, StandardName = "Standard 2"},
            new Standard { StandardId = 3, StandardName = "Standard 3"}
        };

        readonly Helper _studentList = new Helper();

        public void InnerJoin()
        {

            IList<Student> sampleStudentList = new List<Student>();
            IList<Standard> sampleStandardList = new List<Standard>();

            #region Method Syntax

            var methodSyntaxJoin = _studentList.StudentData().Join( //outer sequence
                _standartList,                                     //inner sequence
                student => student.StudentId,                      //outerKeySelector
                standard => standard.StandardId,                   //innerKeySelector
                (student, standard) => new
                {
                    StudentName = student.StudentName,
                    stid = standard.StandardId

                }).Where(o => o.stid == 2); //with where clause
                               //^ reference to standard id

            foreach (var join in methodSyntaxJoin)
            {
                Console.WriteLine("Student Name: {0} - Standard Name: {1}", join.StudentName, join.stid);
            }
            
            #endregion

            #region Query Sytanx

            var querySyntaxJoin = from s in _studentList.StudentData()
                join st in _standartList on s.StudentId equals st.StandardId
                join sq in sampleStudentList on s.StudentId equals  sq.StudentId
                where s.Age >= 20
                select new
                {
                    StudentName = s.StudentName,
                    StandardName = st.StandardName
                };  //Multiple query with where clause

            var queryMultiple = from sStudent in sampleStudentList
                join sStandard in sampleStandardList on sStudent.StudentId equals sStandard.StandardId
                join sList in _standartList on sStudent.StudentId equals sList.StandardId
                select new
                {
                    StudentNam = sStudent.StudentName,
                    StandardNam = sStandard.StandardName,
                    SsListName =  sList.StandardName
                };

            #endregion
        }
    }
}
                            