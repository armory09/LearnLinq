using System;
using System.Collections.Generic;
using LearnLINQ.CollectionGenerics;
using LearnLINQ.Delegate;
using LearnLINQ.Enum;
using LearnLINQ.Generics;
using LearnLINQ.HelperMethod;
using LearnLINQ.LambdaExpression;
using LearnLINQ.LinqSyntax;
using LearnLINQ.LINQOperators;

namespace LearnLINQ
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            Helper studentList = new Helper();

            Console.WriteLine("****Query Syntax in Linq****");
            Query.QuerySyntax();

            Console.WriteLine("****Method Syntax in Linq****");
            Method.MethodSyntax();

            Console.WriteLine("****Lambda Expression Action Delegate****");
            Lambda.ActionLinq();

            Console.WriteLine("****Lambda Expression Func Delegate****");
            Console.WriteLine(Lambda.FuncLinq());

            Console.WriteLine("****Enum****");
            Console.WriteLine("Day: {0} No: {1}", Week.Friday, (int) Week.Friday);
            Console.WriteLine("****Print out all week in enum****");


            foreach (var name in System.Enum.GetNames(typeof (Week)))
            {
                Console.WriteLine(name);      
            }
            

            Console.WriteLine("****Delegate****");
            //Print delegates PrintNumber    
            Delegates.Print printDel = Delegates.Printnumber;     
            printDel(10000);
            printDel(200);                        

            //Print delegates Money
            printDel = Delegates.PrintMoney;
            printDel(10000);
            printDel(200);
            Console.WriteLine("****Delegates as parameters");
            //delegate as parameter
            Delegates.PrintHelper(Delegates.Printnumber, 10000);
            Delegates.PrintHelper(Delegates.PrintMoney, 10000);

            Console.WriteLine("****Delegates multicast");
            //multicast
            Delegates.Print printMulti = Delegates.Printnumber;
            printMulti += Delegates.PrintMoney;
            printMulti += Delegates.PrintHexadecimal;

            printMulti(10000);

            Console.WriteLine("****Generic****");
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            int val = intGenericClass.GenericMethod(200);

            //string generic
            Console.WriteLine("***Generic String****");
            var stringGenericClass = new MyGenericClass<string>("Hello generic world");
            stringGenericClass.GenericProperty = "This is a generic property example";
            string result = stringGenericClass.GenericMethod("Generic Parameter");

            Console.WriteLine("****Generic Delegate");   
            GenericDelegates.Add<int> sum = GenericDelegates.Addnumber;
            Console.WriteLine(sum(10, 20));
            GenericDelegates.Add<string> conct = GenericDelegates.Concate;
            Console.WriteLine(conct("Hello", "World"));

            Console.WriteLine("****Generic Collections****");

            string[] strArray = {"Hello", "World"};
            ILists.Print(strArray); 
            
            List<string> strList = new List<string>
            {
                "Hello",
                "World"
            };   
            ILists.Print(strList);
            Console.WriteLine("****Filter Operators****");
            FilteringOperators s = new FilteringOperators();

            s.OfTypeClause();

            Console.WriteLine("****Grouping Operators****");  
            GroupingOperators g = new GroupingOperators(); 
            g.ToLookUpOperator();

            Console.WriteLine("****Joining Operators****");
            JoiningOperators j = new JoiningOperators();     
            j.InnerJoin();

            Console.WriteLine("****Quantifier Operators****");
            QuantifierOperators q = new QuantifierOperators();
            Console.WriteLine(q.ContainsOperator(studentList.StudentData()));

            Console.WriteLine("****Intersect Operators****");
            SetOperators p = new SetOperators();
            p.IntersectOperator();
            Console.WriteLine("****Union Operators****");
            p.UnionOperator();

            Console.ReadLine();
        }
    }
}
